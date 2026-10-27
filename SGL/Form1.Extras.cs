using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGL
{
    public partial class Form1
    {
        // ---------- campos usados pelos recursos extras ----------

        // Vira true quando o usuário clica em "Sair" (o Program.cs volta para o login)
        public bool VoltarAoLogin;

        private Button btn_Sair;
        private Button btn_NovoVeiculo, btn_NovoMotorista, btn_NovoRota, btn_NovoPreco, btn_NovoViagem;
        private TextBox txt_PesquisarVeiculo, txt_PesquisarMotorista, txt_PesquisarRota,
                        txt_PesquisarPreco, txt_PesquisarViagem;

        private readonly Dictionary<DataGridView, TextBox> _pesquisas = new Dictionary<DataGridView, TextBox>();

        private readonly ErrorProvider _erro = new ErrorProvider();
        private readonly List<Control> _camposComAviso = new List<Control>();

        private string _rotaAoEntrar = "";
        private int _rotaSeq = 0;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);
        private const int EM_SETCUEBANNER = 0x1501;

        private void InicializarExtras()
        {
            _erro.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // Aparência dos grids
            ConfigurarGrid(dgv_Veiculo);
            ConfigurarGrid(dgv_Motorista);
            ConfigurarGrid(dgv_Rota);
            ConfigurarGrid(dgv_Preco);
            ConfigurarGrid(dgv_Viagem);

            // Campos de ID: só leitura (o número vem do banco)
            DeixarSomenteLeitura(txt_VeiculoID);
            DeixarSomenteLeitura(txt_MotoristaID);
            DeixarSomenteLeitura(txt_RotaID);
            DeixarSomenteLeitura(txt_PrecoID);
            DeixarSomenteLeitura(txt_ViagemID);

            // Botões "Novo" (um por aba) e campo de pesquisa (um por grid)
            btn_NovoVeiculo = CriarBotaoNovo("btn_NovoVeiculo", btn_SalvarVeiculo, btn_EditarVeiculo,
                btn_ConsultarVeiculo, btn_ExcluirVeiculo, dgv_Veiculo);
            btn_NovoMotorista = CriarBotaoNovo("btn_NovoMotorista", btn_SalvarMotorista, btn_EditarMotorista,
                btn_ConsultarMotorista, btn_ExcluirMotorista, dgv_Motorista);
            btn_NovoRota = CriarBotaoNovo("btn_NovoRota", btn_SalvarRota, btn_EditarRota,
                btn_ConsultarRota, btn_ExcluirRota, dgv_Rota);
            btn_NovoPreco = CriarBotaoNovo("btn_NovoPreco", btn_SalvarPreco, btn_EditarPreco,
                btn_ConsultarPreco, btn_ExcluirPreco, dgv_Preco);
            btn_NovoViagem = CriarBotaoNovo("btn_NovoViagem", btn_SalvarViagem, btn_EditarViagem,
                btn_ConsultarViagem, btn_ExcluirViagem, dgv_Viagem);

            txt_PesquisarVeiculo = CriarPesquisa("txt_PesquisarVeiculo", dgv_Veiculo);
            txt_PesquisarMotorista = CriarPesquisa("txt_PesquisarMotorista", dgv_Motorista);
            txt_PesquisarRota = CriarPesquisa("txt_PesquisarRota", dgv_Rota);
            txt_PesquisarPreco = CriarPesquisa("txt_PesquisarPreco", dgv_Preco);
            txt_PesquisarViagem = CriarPesquisa("txt_PesquisarViagem", dgv_Viagem);

            btn_NovoVeiculo.Click += (s, e) => NovoCadastro("veiculo", txt_VeiculoID, LimparVeiculo);
            btn_NovoMotorista.Click += (s, e) => NovoCadastro("motorista", txt_MotoristaID,
                () => { LimparMotorista(); LimparEnderecoMotorista(); });
            btn_NovoRota.Click += (s, e) => NovoCadastro("rota", txt_RotaID, LimparRota);
            btn_NovoPreco.Click += (s, e) => NovoCadastro("preco_combustivel", txt_PrecoID, LimparPreco);
            btn_NovoViagem.Click += (s, e) => NovoCadastro("viagem", txt_ViagemID, LimparViagem);

            // Botão Sair (embaixo, à direita): volta para a tela de login
            this.ClientSize = new Size(this.ClientSize.Width, this.ClientSize.Height + 46);
            btn_Sair = new Button();
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Text = "Sair";
            btn_Sair.Size = new Size(100, 34);
            btn_Sair.Location = new Point(tabControl1.Right - btn_Sair.Width, tabControl1.Bottom + 8);
            btn_Sair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Sair.Click += btn_Sair_Click;
            this.Controls.Add(btn_Sair);

            // Clique na linha carrega o registro nos campos
            dgv_Veiculo.CellClick += dgv_Veiculo_CellClick;
            dgv_Motorista.CellClick += dgv_Motorista_CellClick;
            dgv_Rota.CellClick += dgv_Rota_CellClick;
            dgv_Preco.CellClick += dgv_Preco_CellClick;
            dgv_Viagem.CellClick += dgv_Viagem_CellClick;

            // Atualiza o grid depois de salvar, editar ou excluir
            btn_SalvarVeiculo.Click += (s, e) => CarregarGridVeiculo();
            btn_EditarVeiculo.Click += (s, e) => CarregarGridVeiculo();
            btn_ExcluirVeiculo.Click += (s, e) => CarregarGridVeiculo();

            btn_SalvarMotorista.Click += (s, e) => { SalvarEnderecoMotorista(); CarregarGridMotorista(); };
            btn_EditarMotorista.Click += (s, e) => { SalvarEnderecoMotorista(); CarregarGridMotorista(); };
            btn_ConsultarMotorista.Click += (s, e) => CarregarEnderecoMotorista();
            btn_ExcluirMotorista.Click += (s, e) => { LimparEnderecoSeVazio(); CarregarGridMotorista(); };

            btn_SalvarRota.Click += (s, e) => CarregarGridRota();
            btn_EditarRota.Click += (s, e) => CarregarGridRota();
            btn_ExcluirRota.Click += (s, e) => CarregarGridRota();

            btn_SalvarPreco.Click += (s, e) => CarregarGridPreco();
            btn_EditarPreco.Click += (s, e) => CarregarGridPreco();
            btn_ExcluirPreco.Click += (s, e) => CarregarGridPreco();

            btn_SalvarViagem.Click += (s, e) => CarregarGridViagem();
            btn_EditarViagem.Click += (s, e) => CarregarGridViagem();
            btn_ExcluirViagem.Click += (s, e) => CarregarGridViagem();

            // ViaCEP
            btn_BuscarCep.Click += btn_BuscarCep_Click;

            // Distância automática: ao sair dos campos Origem/Destino
            txt_Origem.Enter += (s, e) => _rotaAoEntrar = ChaveRota();
            txt_Destino.Enter += (s, e) => _rotaAoEntrar = ChaveRota();
            txt_Origem.Leave += (s, e) => AoSairOrigemDestino();
            txt_Destino.Leave += (s, e) => AoSairOrigemDestino();

            // Some o aviso vermelho assim que o usuário corrige o campo
            LigarLimpezaDeAvisos(this);

            // Carrega os grids quando o formulário abre
            this.Load += (s, e) => CarregarTodosGrids();
        }

        // ================= BOTÃO SAIR =================

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Deseja sair e voltar para a tela de login?", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            VoltarAoLogin = true;
            this.Close();
        }

        // ================= BOTÃO NOVO =================

        private void DeixarSomenteLeitura(TextBox txt)
        {
            txt.ReadOnly = true;
            txt.BackColor = SystemColors.Window;
            txt.TabStop = false;
        }

        // Cria o "Novo" na posição do "Salvar" e empurra os outros botões para a direita
        private Button CriarBotaoNovo(string nome, Button salvar, Button editar, Button consultar,
                                      Button excluir, DataGridView dgv)
        {
            var novo = new Button();
            novo.Name = nome;
            novo.Text = "Novo";
            novo.Size = salvar.Size;
            novo.Location = salvar.Location;

            int deslocamento = salvar.Width + (editar.Left - salvar.Right);
            salvar.Left += deslocamento;
            editar.Left += deslocamento;
            consultar.Left += deslocamento;
            excluir.Left += deslocamento;

            salvar.Parent.Controls.Add(novo);

            // se os botões encostarem no grid, o grid diminui um pouco pela esquerda
            int folga = excluir.Right + 8 - dgv.Left;
            if (folga > 0)
            {
                dgv.Left += folga;
                dgv.Width -= folga;
            }
            return novo;
        }

        // Limpa os campos e mostra o próximo ID que o banco vai gerar (1, 2, 3...)
        private void NovoCadastro(string tabela, TextBox txtId, Action limpar)
        {
            limpar();
            LimparAvisos();
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();

                    // MySQL 8 guarda o contador em cache; isto força a leitura atual
                    try
                    {
                        using (var c0 = new MySqlCommand("SET SESSION information_schema_stats_expiry = 0", conn))
                            c0.ExecuteNonQuery();
                    }
                    catch (MySqlException) { /* versões antigas do MySQL não têm esta opção */ }

                    string sql = @"SELECT AUTO_INCREMENT FROM information_schema.TABLES
                                   WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = @t";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@t", tabela);
                        object r = cmd.ExecuteScalar();
                        txtId.Text = (r == null || r == DBNull.Value) ? "1" : Convert.ToString(r);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao preparar o novo cadastro: " + ex.Message);
            }
        }

        // ================= PESQUISA NOS GRIDS =================

        private TextBox CriarPesquisa(string nome, DataGridView dgv)
        {
            var txt = new TextBox();
            txt.Name = nome;
            txt.Left = dgv.Left;
            txt.Top = dgv.Top;
            txt.Width = dgv.Width;
            txt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            dgv.Parent.Controls.Add(txt);
            dgv.Top += 28;
            dgv.Height -= 28;

            // texto cinza de dica ("Pesquisar...")
            txt.HandleCreated += (s, e) => DefinirDica(txt);
            if (txt.IsHandleCreated) DefinirDica(txt);

            txt.TextChanged += (s, e) => FiltrarGrid(dgv, txt.Text);
            _pesquisas[dgv] = txt;
            return txt;
        }

        private void DefinirDica(TextBox txt)
        {
            SendMessage(txt.Handle, EM_SETCUEBANNER, (IntPtr)1, "Pesquisar...");
        }

        private void FiltrarGrid(DataGridView dgv, string texto)
        {
            var tabela = dgv.DataSource as DataTable;
            if (tabela == null) return;

            texto = (texto ?? "").Trim();
            if (texto.Length == 0)
            {
                tabela.DefaultView.RowFilter = "";
                return;
            }

            string t = texto.Replace("'", "''")
                            .Replace("[", "[[]")
                            .Replace("%", "[%]")
                            .Replace("*", "[*]");

            var partes = new List<string>();
            foreach (DataColumn col in tabela.Columns)
                partes.Add("Convert([" + col.ColumnName + "], 'System.String') LIKE '%" + t + "%'");

            try
            {
                tabela.DefaultView.RowFilter = string.Join(" OR ", partes.ToArray());
            }
            catch (Exception)
            {
                tabela.DefaultView.RowFilter = "";
            }
        }

        // ================= AVISOS DE VALIDAÇÃO (ErrorProvider) =================

        // Mostra o ícone vermelho no campo, avisa o usuário e devolve false
        private bool Invalido(Control campo, string mensagem)
        {
            _erro.SetError(campo, mensagem);
            if (campo is TextBox || campo is ComboBox)
                campo.BackColor = Color.MistyRose;
            _camposComAviso.Add(campo);

            MessageBox.Show(mensagem);
            campo.Focus();
            return false;
        }

        private void LimparAvisos()
        {
            foreach (Control c in _camposComAviso)
                LimparAviso(c);
            _camposComAviso.Clear();
        }

        private void LimparAviso(Control c)
        {
            _erro.SetError(c, "");
            if (c is TextBox || c is ComboBox)
                c.BackColor = SystemColors.Window;
        }

        private void LigarLimpezaDeAvisos(Control pai)
        {
            foreach (Control c in pai.Controls)
            {
                if (c is TextBox)
                    c.TextChanged += (s, e) => LimparAviso((Control)s);
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndexChanged += (s, e) => LimparAviso((Control)s);
                else if (c is DateTimePicker)
                    ((DateTimePicker)c).ValueChanged += (s, e) => LimparAviso((Control)s);

                if (c.HasChildren) LigarLimpezaDeAvisos(c);
            }
        }

        // ================= DISTÂNCIA AUTOMÁTICA (Photon + OSRM) =================

        private string ChaveRota()
        {
            return (txt_Origem.Text.Trim() + "|" + txt_Destino.Text.Trim()).ToLower();
        }

        private void AoSairOrigemDestino()
        {
            // só busca se origem/destino mudaram desde que o usuário entrou nos campos
            if (ChaveRota() == _rotaAoEntrar) return;
            BuscarDistanciaRota();
        }

        private async void BuscarDistanciaRota()
        {
            string origem = txt_Origem.Text.Trim();
            string destino = txt_Destino.Text.Trim();
            if (origem.Length == 0 || destino.Length == 0) return;

            int meuNumero = ++_rotaSeq;   // se o usuário mudar de novo, só vale a última busca
            string textoAntigo = txt_Distancia.Text;
            txt_Distancia.Text = "Calculando...";

            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; // TLS 1.2

                double[] a = await BuscarCoordenada(origem);
                double[] b = await BuscarCoordenada(destino);

                if (IsDisposed || meuNumero != _rotaSeq) return;

                if (a == null || b == null)
                {
                    txt_Distancia.Text = textoAntigo;
                    MessageBox.Show("Não encontrei " + (a == null ? "a origem" : "o destino") +
                                    ". Tente escrever assim: Cidade, UF (ex.: Campinas, SP).\n" +
                                    "Você também pode digitar a distância manualmente.");
                    return;
                }

                string url = "https://router.project-osrm.org/route/v1/driving/" +
                             a[1].ToString(CultureInfo.InvariantCulture) + "," + a[0].ToString(CultureInfo.InvariantCulture) + ";" +
                             b[1].ToString(CultureInfo.InvariantCulture) + "," + b[0].ToString(CultureInfo.InvariantCulture) +
                             "?overview=false";
                string json = await BaixarTexto(url);

                if (IsDisposed || meuNumero != _rotaSeq) return;

                var m = Regex.Match(json, "\"distance\"\\s*:\\s*([0-9]+(\\.[0-9]+)?)");
                if (!m.Success)
                {
                    txt_Distancia.Text = textoAntigo;
                    MessageBox.Show("Não foi possível calcular o trajeto entre esses locais. Digite a distância manualmente.");
                    return;
                }

                double metros = double.Parse(m.Groups[1].Value, CultureInfo.InvariantCulture);
                txt_Distancia.Text = (metros / 1000.0).ToString("0.00");
            }
            catch (WebException ex)
            {
                if (IsDisposed || meuNumero != _rotaSeq) return;
                txt_Distancia.Text = textoAntigo;

                string detalhe = ex.Message;
                var resp = ex.Response as HttpWebResponse;
                if (resp != null)
                    detalhe += "\nCódigo HTTP: " + (int)resp.StatusCode + "\nServidor: " + resp.ResponseUri.Host;

                MessageBox.Show("Não foi possível consultar a distância. Verifique a internet ou digite o Km manualmente.\n\n" + detalhe);
            }
            catch (Exception ex)
            {
                if (IsDisposed || meuNumero != _rotaSeq) return;
                txt_Distancia.Text = textoAntigo;
                MessageBox.Show("Erro ao calcular a distância: " + ex.Message);
            }
        }

        // Devolve { latitude, longitude } ou null se o local não for achado (busca só no Brasil)
        private async System.Threading.Tasks.Task<double[]> BuscarCoordenada(string local)
        {
            string url = "https://photon.komoot.io/api/?limit=1&bbox=-74,-34,-34,6&q=" + Uri.EscapeDataString(local);
            string json = await BaixarTexto(url);

            var m = Regex.Match(json, "\"coordinates\"\\s*:\\s*\\[\\s*(-?[0-9]+(?:\\.[0-9]+)?)\\s*,\\s*(-?[0-9]+(?:\\.[0-9]+)?)\\s*\\]");
            if (!m.Success) return null;

            double lon = double.Parse(m.Groups[1].Value, CultureInfo.InvariantCulture);
            double lat = double.Parse(m.Groups[2].Value, CultureInfo.InvariantCulture);
            return new double[] { lat, lon };
        }

        private async System.Threading.Tasks.Task<string> BaixarTexto(string url)
        {
            using (var wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                wc.Headers[HttpRequestHeader.UserAgent] = "SGL-Logistica/1.0";
                return await wc.DownloadStringTaskAsync(url);
            }
        }

        // ================= GRIDS =================

        private void ConfigurarGrid(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CarregarGrid(DataGridView dgv, string sql)
        {
            try
            {
                var tabela = new DataTable();
                using (var conn = Conexao.Criar())
                using (var da = new MySqlDataAdapter(sql, conn))
                {
                    da.Fill(tabela);
                }
                dgv.DataSource = tabela;

                // mantém a pesquisa digitada depois de recarregar
                TextBox pesquisa;
                if (_pesquisas.TryGetValue(dgv, out pesquisa) && pesquisa.Text.Trim().Length > 0)
                    FiltrarGrid(dgv, pesquisa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista: " + ex.Message);
            }
        }

        private void CarregarTodosGrids()
        {
            CarregarGridVeiculo();
            CarregarGridMotorista();
            CarregarGridRota();
            CarregarGridPreco();
            CarregarGridViagem();
        }

        private void CarregarGridVeiculo()
        {
            CarregarGrid(dgv_Veiculo,
                @"SELECT veiculoID AS 'ID', modelo AS 'Modelo', placa AS 'Placa',
                         consumo_medio AS 'Consumo (Km/L)', carga_maxima AS 'Carga máx. (Kg)'
                  FROM veiculo ORDER BY veiculoID");
        }

        private void CarregarGridMotorista()
        {
            CarregarGrid(dgv_Motorista,
                @"SELECT motoristaID AS 'ID', nome AS 'Nome', cnh AS 'CNH', telefone AS 'Telefone'
                  FROM motorista ORDER BY motoristaID");
        }

        private void CarregarGridRota()
        {
            CarregarGrid(dgv_Rota,
                @"SELECT rotaID AS 'ID', origem AS 'Origem', destino AS 'Destino',
                         distancia AS 'Distância (Km)'
                  FROM rota ORDER BY rotaID");
        }

        private void CarregarGridPreco()
        {
            CarregarGrid(dgv_Preco,
                @"SELECT precoID AS 'ID', combustivel AS 'Combustível', preco AS 'Preço (R$)',
                         data_consulta AS 'Data da consulta'
                  FROM preco_combustivel ORDER BY precoID");
        }

        private void CarregarGridViagem()
        {
            CarregarGrid(dgv_Viagem,
                @"SELECT v.viagemID AS 'ID', ve.placa AS 'Veículo (Placa)', m.nome AS 'Motorista',
                         CONCAT(r.origem, ' > ', r.destino) AS 'Rota',
                         v.data_saida AS 'Saída', v.data_chegada AS 'Chegada', v.situacao AS 'Status'
                  FROM viagem v
                  INNER JOIN veiculo ve ON ve.veiculoID = v.veiculoID
                  INNER JOIN motorista m ON m.motoristaID = v.motoristaID
                  INNER JOIN rota r ON r.rotaID = v.rotaID
                  ORDER BY v.viagemID");
        }

        // Clique numa linha: coloca o ID no campo e usa o botão Consultar já existente

        private void dgv_Veiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txt_VeiculoID.Text = dgv_Veiculo.Rows[e.RowIndex].Cells[0].Value.ToString();
            btn_ConsultarVeiculo_Click(sender, e);
        }

        private void dgv_Motorista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txt_MotoristaID.Text = dgv_Motorista.Rows[e.RowIndex].Cells[0].Value.ToString();
            btn_ConsultarMotorista_Click(sender, e);
            CarregarEnderecoMotorista();
        }

        private void dgv_Rota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txt_RotaID.Text = dgv_Rota.Rows[e.RowIndex].Cells[0].Value.ToString();
            btn_ConsultarRota_Click(sender, e);
        }

        private void dgv_Preco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txt_PrecoID.Text = dgv_Preco.Rows[e.RowIndex].Cells[0].Value.ToString();
            btn_ConsultarPreco_Click(sender, e);
        }

        private void dgv_Viagem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txt_ViagemID.Text = dgv_Viagem.Rows[e.RowIndex].Cells[0].Value.ToString();
            btn_ConsultarViagem_Click(sender, e);
        }

        // ================= VIACEP (endereço do motorista) =================

        private void btn_BuscarCep_Click(object sender, EventArgs e)
        {
            string cep = SomenteDigitos(txt_Cep.Text);
            if (cep.Length != 8)
            {
                MessageBox.Show("Informe um CEP com 8 números.");
                txt_Cep.Focus();
                return;
            }
            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; // TLS 1.2

                string json;
                using (var wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    json = wc.DownloadString("https://viacep.com.br/ws/" + cep + "/json/");
                }

                if (Regex.IsMatch(json, "\"erro\"\\s*:\\s*(true|\"true\")"))
                {
                    MessageBox.Show("CEP não encontrado.");
                    return;
                }

                txt_Logradouro.Text = ValorJson(json, "logradouro");
                txt_Bairro.Text = ValorJson(json, "bairro");
                txt_Cidade.Text = ValorJson(json, "localidade");
                txt_Uf.Text = ValorJson(json, "uf");
            }
            catch (WebException)
            {
                MessageBox.Show("Não foi possível consultar o CEP. Verifique a internet e tente de novo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar o CEP: " + ex.Message);
            }
        }

        // Lê um campo de texto simples do JSON devolvido pelo ViaCEP
        private string ValorJson(string json, string campo)
        {
            var m = Regex.Match(json, "\"" + campo + "\"\\s*:\\s*\"([^\"]*)\"");
            return m.Success ? Regex.Unescape(m.Groups[1].Value) : "";
        }

        // Roda depois do Salvar/Editar do motorista (que já gravou nome, CNH e telefone)
        private void SalvarEnderecoMotorista()
        {
            int id;
            if (!int.TryParse(txt_MotoristaID.Text, out id)) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = @"UPDATE motorista SET cep=@cep, logradouro=@log, bairro=@bairro,
                                   cidade=@cidade, uf=@uf WHERE motoristaID=@id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@cep", SomenteDigitos(txt_Cep.Text));
                        cmd.Parameters.AddWithValue("@log", txt_Logradouro.Text.Trim());
                        cmd.Parameters.AddWithValue("@bairro", txt_Bairro.Text.Trim());
                        cmd.Parameters.AddWithValue("@cidade", txt_Cidade.Text.Trim());
                        cmd.Parameters.AddWithValue("@uf", txt_Uf.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o endereço: " + ex.Message);
            }
        }

        private void CarregarEnderecoMotorista()
        {
            int id;
            if (!int.TryParse(txt_MotoristaID.Text, out id)) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = "SELECT cep, logradouro, bairro, cidade, uf FROM motorista WHERE motoristaID=@id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txt_Cep.Text = dr["cep"].ToString();
                                txt_Logradouro.Text = dr["logradouro"].ToString();
                                txt_Bairro.Text = dr["bairro"].ToString();
                                txt_Cidade.Text = dr["cidade"].ToString();
                                txt_Uf.Text = dr["uf"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o endereço: " + ex.Message);
            }
        }

        private void LimparEnderecoSeVazio()
        {
            // o ID só fica vazio se o motorista foi realmente excluído
            if (string.IsNullOrWhiteSpace(txt_MotoristaID.Text))
            {
                txt_Cep.Clear(); txt_Logradouro.Clear(); txt_Bairro.Clear();
                txt_Cidade.Clear(); txt_Uf.Clear();
            }
        }
    }
}
