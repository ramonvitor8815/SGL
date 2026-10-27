using System;
using System.Data;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGL
{
    public partial class Form1
    {
        private void InicializarExtras()
        {
            // Aparência dos grids
            ConfigurarGrid(dgv_Veiculo);
            ConfigurarGrid(dgv_Motorista);
            ConfigurarGrid(dgv_Rota);
            ConfigurarGrid(dgv_Preco);
            ConfigurarGrid(dgv_Viagem);

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

            // Carrega os grids quando o formulário abre
            this.Load += (s, e) => CarregarTodosGrids();
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
                ServicePointManager.SecurityProtocol |= (SecurityProtocolType)3072; // TLS 1.2

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
