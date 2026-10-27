using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Preço Combustível
            btn_SalvarPreco.Click += btn_SalvarPreco_Click;
            btn_ConsultarPreco.Click += btn_ConsultarPreco_Click;
            btn_EditarPreco.Click += btn_EditarPreco_Click;
            btn_ExcluirPreco.Click += btn_ExcluirPreco_Click;

            // Viagem
            btn_SalvarViagem.Click += btn_SalvarViagem_Click;
            btn_ConsultarViagem.Click += btn_ConsultarViagem_Click;
            btn_EditarViagem.Click += btn_EditarViagem_Click;
            btn_ExcluirViagem.Click += btn_ExcluirViagem_Click;
            chk_TemChegada.CheckedChanged += chk_TemChegada_CheckedChanged;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;

            // Motorista
            btn_SalvarMotorista.Click += btn_SalvarMotorista_Click;
            btn_ConsultarMotorista.Click += btn_ConsultarMotorista_Click;
            btn_EditarMotorista.Click += btn_EditarMotorista_Click;
            btn_ExcluirMotorista.Click += btn_ExcluirMotorista_Click;

            InicializarExtras();
            Tema.Aplicar(this);
        }

        private void tab_veiculo_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtp_Chegada.Enabled = chk_TemChegada.Checked;
            CarregarCombosViagem();
        }

        // ================= VEÍCULO =================

        private void btn_SalvarVeiculo_Click(object sender, EventArgs e)
        {
            if (!ValidarVeiculo()) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = @"INSERT INTO veiculo (modelo, placa, consumo_medio, carga_maxima)
                                   VALUES (@modelo, @placa, @consumo, @carga)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        PreencherParametrosVeiculo(cmd);
                        cmd.ExecuteNonQuery();
                        txt_VeiculoID.Text = cmd.LastInsertedId.ToString();
                    }
                }
                MessageBox.Show("Veículo salvo com sucesso!");
                LimparVeiculo();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Já existe um veículo com esta placa.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void btn_ConsultarVeiculo_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_VeiculoID.Text, out id))
            {
                MessageBox.Show("Digite o ID do veículo para consultar.");
                return;
            }
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = "SELECT * FROM veiculo WHERE veiculoID = @id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txt_Modelo.Text = dr["modelo"].ToString();
                                txt_Placa.Text = dr["placa"].ToString();
                                txt_Consumo.Text = dr["consumo_medio"].ToString();
                                txt_Carga.Text = dr["carga_maxima"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Veículo não encontrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
            }
        }

        private void btn_EditarVeiculo_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_VeiculoID.Text, out id))
            {
                MessageBox.Show("Consulte um veículo antes de editar.");
                return;
            }
            if (!ValidarVeiculo()) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = @"UPDATE veiculo SET modelo=@modelo, placa=@placa,
                                   consumo_medio=@consumo, carga_maxima=@carga
                                   WHERE veiculoID=@id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        PreencherParametrosVeiculo(cmd);
                        cmd.Parameters.AddWithValue("@id", id);
                        int linhas = cmd.ExecuteNonQuery();
                        MessageBox.Show(linhas > 0 ? "Veículo atualizado!" : "Veículo não encontrado.");
                    }
                }
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Já existe outro veículo com esta placa.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar: " + ex.Message);
            }
        }

        private void btn_ExcluirVeiculo_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_VeiculoID.Text, out id))
            {
                MessageBox.Show("Digite o ID do veículo para excluir.");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir este veículo?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("DELETE FROM veiculo WHERE veiculoID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int linhas = cmd.ExecuteNonQuery();
                        MessageBox.Show(linhas > 0 ? "Veículo excluído!" : "Veículo não encontrado.");
                    }
                }
                LimparVeiculo();
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("Este veículo possui viagens e não pode ser excluído.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

        private bool ValidarVeiculo()
        {
            decimal consumo, carga;
            LimparAvisos();

            if (string.IsNullOrWhiteSpace(txt_Modelo.Text))
                return Invalido(txt_Modelo, "Informe o modelo do veículo.");

            if (txt_Placa.Text.Trim().Length != 7)
                return Invalido(txt_Placa, "A placa deve ter 7 caracteres.");

            if (!decimal.TryParse(txt_Consumo.Text, out consumo) || consumo <= 0)
                return Invalido(txt_Consumo, "Informe um consumo médio válido (use vírgula, ex.: 2,5).");

            if (!string.IsNullOrWhiteSpace(txt_Carga.Text) && !decimal.TryParse(txt_Carga.Text, out carga))
                return Invalido(txt_Carga, "Carga máxima inválida.");

            return true;
        }

        private void PreencherParametrosVeiculo(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@modelo", txt_Modelo.Text.Trim());
            cmd.Parameters.AddWithValue("@placa", txt_Placa.Text.Trim().ToUpper());
            cmd.Parameters.AddWithValue("@consumo", decimal.Parse(txt_Consumo.Text));
            if (string.IsNullOrWhiteSpace(txt_Carga.Text))
                cmd.Parameters.AddWithValue("@carga", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@carga", decimal.Parse(txt_Carga.Text));
        }

        private void LimparVeiculo()
        {
            txt_VeiculoID.Clear(); txt_Modelo.Clear(); txt_Placa.Clear();
            txt_Consumo.Clear(); txt_Carga.Clear();
        }

        // ================= MOTORISTA =================

        private void btn_SalvarMotorista_Click(object sender, EventArgs e)
        {
            if (!ValidarMotorista()) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = @"INSERT INTO motorista (nome, cnh, telefone)
                                   VALUES (@nome, @cnh, @telefone)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        PreencherParametrosMotorista(cmd);
                        cmd.ExecuteNonQuery();
                        txt_MotoristaID.Text = cmd.LastInsertedId.ToString();
                    }
                }
                MessageBox.Show("Motorista salvo com sucesso!");

                // grava o endereço antes de limpar (usa o ID recém-criado)
                SalvarEnderecoMotorista();
                LimparMotorista();
                LimparEnderecoMotorista();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Já existe um motorista com esta CNH.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void btn_ConsultarMotorista_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_MotoristaID.Text, out id))
            {
                MessageBox.Show("Digite o ID do motorista para consultar.");
                return;
            }
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = "SELECT * FROM motorista WHERE motoristaID = @id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txt_Nome.Text = dr["nome"].ToString();
                                txt_Cnh.Text = dr["cnh"].ToString();
                                txt_Telefone.Text = dr["telefone"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Motorista não encontrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
            }
        }

        private void btn_EditarMotorista_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_MotoristaID.Text, out id))
            {
                MessageBox.Show("Consulte um motorista antes de editar.");
                return;
            }
            if (!ValidarMotorista()) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = @"UPDATE motorista SET nome=@nome, cnh=@cnh, telefone=@telefone
                                   WHERE motoristaID=@id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        PreencherParametrosMotorista(cmd);
                        cmd.Parameters.AddWithValue("@id", id);
                        int linhas = cmd.ExecuteNonQuery();
                        MessageBox.Show(linhas > 0 ? "Motorista atualizado!" : "Motorista não encontrado.");
                    }
                }
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Já existe outro motorista com esta CNH.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar: " + ex.Message);
            }
        }

        private void btn_ExcluirMotorista_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_MotoristaID.Text, out id))
            {
                MessageBox.Show("Digite o ID do motorista para excluir.");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir este motorista?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("DELETE FROM motorista WHERE motoristaID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int linhas = cmd.ExecuteNonQuery();
                        MessageBox.Show(linhas > 0 ? "Motorista excluído!" : "Motorista não encontrado.");
                    }
                }
                LimparMotorista();
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("Este motorista possui viagens e não pode ser excluído.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

        private bool ValidarMotorista()
        {
            LimparAvisos();

            if (string.IsNullOrWhiteSpace(txt_Nome.Text))
                return Invalido(txt_Nome, "Informe o nome do motorista.");

            if (SomenteDigitos(txt_Cnh.Text).Length != 11)
                return Invalido(txt_Cnh, "A CNH deve ter 11 números.");

            int tamTel = SomenteDigitos(txt_Telefone.Text).Length;
            if (tamTel < 10 || tamTel > 11)
                return Invalido(txt_Telefone, "Informe o telefone com DDD (10 ou 11 números).");

            return true;
        }

        private void PreencherParametrosMotorista(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@nome", txt_Nome.Text.Trim());
            cmd.Parameters.AddWithValue("@cnh", SomenteDigitos(txt_Cnh.Text));
            cmd.Parameters.AddWithValue("@telefone", SomenteDigitos(txt_Telefone.Text));
        }

        private void LimparMotorista()
        {
            txt_MotoristaID.Clear(); txt_Nome.Clear();
            txt_Cnh.Clear(); txt_Telefone.Clear();
        }

        private void LimparEnderecoMotorista()
        {
            txt_Cep.Clear(); txt_Logradouro.Clear(); txt_Bairro.Clear();
            txt_Cidade.Clear(); txt_Uf.Clear();
        }

        private string SomenteDigitos(string texto)
        {
            return new string((texto ?? "").Where(char.IsDigit).ToArray());
        }

        // ================= ROTA =================

        private void btn_SalvarRota_Click(object sender, EventArgs e)
        {
            if (!ValidarRota()) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = @"INSERT INTO rota (origem, destino, distancia)
                                   VALUES (@origem, @destino, @distancia)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        PreencherParametrosRota(cmd);
                        cmd.ExecuteNonQuery();
                        txt_RotaID.Text = cmd.LastInsertedId.ToString();
                    }
                }
                MessageBox.Show("Rota salva com sucesso!");
                LimparRota();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void btn_ConsultarRota_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_RotaID.Text, out id))
            {
                MessageBox.Show("Digite o ID da rota para consultar.");
                return;
            }
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = "SELECT * FROM rota WHERE rotaID = @id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txt_Origem.Text = dr["origem"].ToString();
                                txt_Destino.Text = dr["destino"].ToString();
                                txt_Distancia.Text = dr["distancia"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Rota não encontrada.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
            }
        }

        private void btn_EditarRota_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_RotaID.Text, out id))
            {
                MessageBox.Show("Consulte uma rota antes de editar.");
                return;
            }
            if (!ValidarRota()) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = @"UPDATE rota SET origem=@origem, destino=@destino, distancia=@distancia
                                   WHERE rotaID=@id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        PreencherParametrosRota(cmd);
                        cmd.Parameters.AddWithValue("@id", id);
                        int linhas = cmd.ExecuteNonQuery();
                        MessageBox.Show(linhas > 0 ? "Rota atualizada!" : "Rota não encontrada.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar: " + ex.Message);
            }
        }

        private void btn_ExcluirRota_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_RotaID.Text, out id))
            {
                MessageBox.Show("Digite o ID da rota para excluir.");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir esta rota?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("DELETE FROM rota WHERE rotaID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int linhas = cmd.ExecuteNonQuery();
                        MessageBox.Show(linhas > 0 ? "Rota excluída!" : "Rota não encontrada.");
                    }
                }
                LimparRota();
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("Esta rota possui viagens e não pode ser excluída.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

        private bool ValidarRota()
        {
            decimal distancia;
            LimparAvisos();

            if (string.IsNullOrWhiteSpace(txt_Origem.Text))
                return Invalido(txt_Origem, "Informe a origem da rota.");

            if (string.IsNullOrWhiteSpace(txt_Destino.Text))
                return Invalido(txt_Destino, "Informe o destino da rota.");

            if (!decimal.TryParse(txt_Distancia.Text, out distancia) || distancia <= 0)
                return Invalido(txt_Distancia, "Informe uma distância válida em Km (ex.: 430,50).");

            return true;
        }

        private void PreencherParametrosRota(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@origem", txt_Origem.Text.Trim());
            cmd.Parameters.AddWithValue("@destino", txt_Destino.Text.Trim());
            cmd.Parameters.AddWithValue("@distancia", decimal.Parse(txt_Distancia.Text));
        }

        private void LimparRota()
        {
            txt_RotaID.Clear(); txt_Origem.Clear();
            txt_Destino.Clear(); txt_Distancia.Clear();
        }

        // ================= PREÇO COMBUSTÍVEL =================

        private void btn_SalvarPreco_Click(object sender, EventArgs e)
        {
            if (!ValidarPreco()) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = @"INSERT INTO preco_combustivel (combustivel, preco, data_consulta)
                                   VALUES (@combustivel, @preco, @data)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        PreencherParametrosPreco(cmd);
                        cmd.ExecuteNonQuery();
                        txt_PrecoID.Text = cmd.LastInsertedId.ToString();
                    }
                }
                MessageBox.Show("Preço salvo com sucesso!");
                LimparPreco();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void btn_ConsultarPreco_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_PrecoID.Text, out id))
            {
                MessageBox.Show("Digite o ID do preço para consultar.");
                return;
            }
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = "SELECT * FROM preco_combustivel WHERE precoID = @id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                cmb_Combustivel.SelectedIndex =
                                    cmb_Combustivel.FindStringExact(dr["combustivel"].ToString());
                                txt_Preco.Text = dr["preco"].ToString();
                                dtp_DataConsulta.Value = Convert.ToDateTime(dr["data_consulta"]);
                            }
                            else
                            {
                                MessageBox.Show("Preço não encontrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
            }
        }

        private void btn_EditarPreco_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_PrecoID.Text, out id))
            {
                MessageBox.Show("Consulte um preço antes de editar.");
                return;
            }
            if (!ValidarPreco()) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = @"UPDATE preco_combustivel
                                   SET combustivel=@combustivel, preco=@preco, data_consulta=@data
                                   WHERE precoID=@id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        PreencherParametrosPreco(cmd);
                        cmd.Parameters.AddWithValue("@id", id);
                        int linhas = cmd.ExecuteNonQuery();
                        MessageBox.Show(linhas > 0 ? "Preço atualizado!" : "Preço não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar: " + ex.Message);
            }
        }

        private void btn_ExcluirPreco_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_PrecoID.Text, out id))
            {
                MessageBox.Show("Digite o ID do preço para excluir.");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir este preço?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("DELETE FROM preco_combustivel WHERE precoID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int linhas = cmd.ExecuteNonQuery();
                        MessageBox.Show(linhas > 0 ? "Preço excluído!" : "Preço não encontrado.");
                    }
                }
                LimparPreco();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

        private bool ValidarPreco()
        {
            decimal preco;
            LimparAvisos();

            if (cmb_Combustivel.SelectedIndex < 0)
                return Invalido(cmb_Combustivel, "Selecione o combustível.");

            // a coluna é DECIMAL(4,2), então o valor máximo é 99,99
            if (!decimal.TryParse(txt_Preco.Text, out preco) || preco <= 0 || preco >= 100)
                return Invalido(txt_Preco, "Informe um preço válido (ex.: 6,29).");

            return true;
        }

        private void PreencherParametrosPreco(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@combustivel", cmb_Combustivel.Text);
            cmd.Parameters.AddWithValue("@preco", decimal.Parse(txt_Preco.Text));
            cmd.Parameters.AddWithValue("@data", dtp_DataConsulta.Value);
        }

        private void LimparPreco()
        {
            txt_PrecoID.Clear();
            cmb_Combustivel.SelectedIndex = -1;
            txt_Preco.Clear();
            dtp_DataConsulta.Value = DateTime.Now;
        }

        // ================= VIAGEM =================

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Text == "Viagem")
                CarregarCombosViagem();
        }

        private void chk_TemChegada_CheckedChanged(object sender, EventArgs e)
        {
            dtp_Chegada.Enabled = chk_TemChegada.Checked;
        }

        private void CarregarCombosViagem()
        {
            try
            {
                CarregarCombo(cmb_Veiculo,
                    "SELECT veiculoID AS id, CONCAT(placa, ' - ', modelo) AS descricao FROM veiculo ORDER BY placa");
                CarregarCombo(cmb_Rota,
                    "SELECT rotaID AS id, CONCAT(origem, ' > ', destino) AS descricao FROM rota ORDER BY origem");
                CarregarCombo(cmb_Motorista,
                    "SELECT motoristaID AS id, nome AS descricao FROM motorista ORDER BY nome");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as listas: " + ex.Message);
            }
        }

        private void CarregarCombo(ComboBox cmb, string sql)
        {
            object selecionado = cmb.SelectedValue;
            var tabela = new DataTable();
            using (var conn = Conexao.Criar())
            using (var da = new MySqlDataAdapter(sql, conn))
            {
                da.Fill(tabela);
            }
            cmb.DisplayMember = "descricao";
            cmb.ValueMember = "id";
            cmb.DataSource = tabela;
            if (selecionado != null) cmb.SelectedValue = selecionado;
            else cmb.SelectedIndex = -1;
        }

        private void btn_SalvarViagem_Click(object sender, EventArgs e)
        {
            if (!ValidarViagem()) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = @"INSERT INTO viagem (veiculoID, motoristaID, rotaID, data_saida, data_chegada, situacao)
                                   VALUES (@veiculo, @motorista, @rota, @saida, @chegada, @situacao)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        PreencherParametrosViagem(cmd);
                        cmd.ExecuteNonQuery();
                        txt_ViagemID.Text = cmd.LastInsertedId.ToString();
                    }
                }
                MessageBox.Show("Viagem salva com sucesso! Situação: " + SituacaoViagem());
                LimparViagem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void btn_ConsultarViagem_Click(object sender, EventArgs e)
        {
            // ID vazio: abre a tela de pesquisa com filtros
            if (string.IsNullOrWhiteSpace(txt_ViagemID.Text))
            {
                using (var frm = new FrmConsultarViagem())
                {
                    frm.ShowDialog(this);
                }
                return;
            }

            int id;
            if (!int.TryParse(txt_ViagemID.Text, out id))
            {
                MessageBox.Show("O ID da viagem deve ser um número.");
                return;
            }
            try
            {
                CarregarCombosViagem();
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = "SELECT * FROM viagem WHERE viagemID = @id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                cmb_Veiculo.SelectedValue = Convert.ToInt32(dr["veiculoID"]);
                                cmb_Motorista.SelectedValue = Convert.ToInt32(dr["motoristaID"]);
                                cmb_Rota.SelectedValue = Convert.ToInt32(dr["rotaID"]);
                                dtp_Saida.Value = Convert.ToDateTime(dr["data_saida"]);

                                if (dr["data_chegada"] == DBNull.Value)
                                {
                                    chk_TemChegada.Checked = false;
                                }
                                else
                                {
                                    chk_TemChegada.Checked = true;
                                    dtp_Chegada.Value = Convert.ToDateTime(dr["data_chegada"]);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Viagem não encontrada.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
            }
        }

        private void btn_EditarViagem_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_ViagemID.Text, out id))
            {
                MessageBox.Show("Consulte uma viagem antes de editar.");
                return;
            }
            if (!ValidarViagem()) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = @"UPDATE viagem SET veiculoID=@veiculo, motoristaID=@motorista, rotaID=@rota,
                                   data_saida=@saida, data_chegada=@chegada, situacao=@situacao
                                   WHERE viagemID=@id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        PreencherParametrosViagem(cmd);
                        cmd.Parameters.AddWithValue("@id", id);
                        int linhas = cmd.ExecuteNonQuery();
                        MessageBox.Show(linhas > 0
                            ? "Viagem atualizada! Situação: " + SituacaoViagem()
                            : "Viagem não encontrada.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar: " + ex.Message);
            }
        }

        private void btn_ExcluirViagem_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_ViagemID.Text, out id))
            {
                MessageBox.Show("Digite o ID da viagem para excluir.");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir esta viagem?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("DELETE FROM viagem WHERE viagemID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int linhas = cmd.ExecuteNonQuery();
                        MessageBox.Show(linhas > 0 ? "Viagem excluída!" : "Viagem não encontrada.");
                    }
                }
                LimparViagem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

        private string SituacaoViagem()
        {
            return chk_TemChegada.Checked ? "Concluída" : "Em Andamento";
        }

        private bool ValidarViagem()
        {
            LimparAvisos();

            if (cmb_Veiculo.SelectedValue == null)
                return Invalido(cmb_Veiculo, "Selecione o veículo da viagem.");

            if (cmb_Rota.SelectedValue == null)
                return Invalido(cmb_Rota, "Selecione a rota da viagem.");

            if (cmb_Motorista.SelectedValue == null)
                return Invalido(cmb_Motorista, "Selecione o motorista da viagem.");

            if (chk_TemChegada.Checked && dtp_Chegada.Value < dtp_Saida.Value)
                return Invalido(dtp_Chegada, "A data de chegada não pode ser anterior à data de saída.");

            return true;
        }

        private void PreencherParametrosViagem(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@veiculo", Convert.ToInt32(cmb_Veiculo.SelectedValue));
            cmd.Parameters.AddWithValue("@motorista", Convert.ToInt32(cmb_Motorista.SelectedValue));
            cmd.Parameters.AddWithValue("@rota", Convert.ToInt32(cmb_Rota.SelectedValue));
            cmd.Parameters.AddWithValue("@saida", dtp_Saida.Value);
            if (chk_TemChegada.Checked)
                cmd.Parameters.AddWithValue("@chegada", dtp_Chegada.Value);
            else
                cmd.Parameters.AddWithValue("@chegada", DBNull.Value);
            cmd.Parameters.AddWithValue("@situacao", SituacaoViagem());
        }

        private void LimparViagem()
        {
            txt_ViagemID.Clear();
            dtp_Saida.Value = DateTime.Now;
            dtp_Chegada.Value = DateTime.Now;
            chk_TemChegada.Checked = false;
            cmb_Veiculo.SelectedIndex = -1;
            cmb_Rota.SelectedIndex = -1;
            cmb_Motorista.SelectedIndex = -1;
        }
    }
}