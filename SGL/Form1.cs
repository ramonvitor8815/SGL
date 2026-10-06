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
            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    MessageBox.Show("Conectado ao banco com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão: " + ex.Message);
            }
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

        // ---------- Auxiliares do Veículo ----------

        private bool ValidarVeiculo()
        {
            decimal consumo, carga;

            if (string.IsNullOrWhiteSpace(txt_Modelo.Text))
            { MessageBox.Show("Informe o modelo do veículo."); txt_Modelo.Focus(); return false; }

            if (txt_Placa.Text.Trim().Length != 7)
            { MessageBox.Show("A placa deve ter 7 caracteres."); txt_Placa.Focus(); return false; }

            if (!decimal.TryParse(txt_Consumo.Text, out consumo) || consumo <= 0)
            { MessageBox.Show("Informe um consumo médio válido (use vírgula, ex.: 2,5)."); txt_Consumo.Focus(); return false; }

            if (!string.IsNullOrWhiteSpace(txt_Carga.Text) && !decimal.TryParse(txt_Carga.Text, out carga))
            { MessageBox.Show("Carga máxima inválida."); txt_Carga.Focus(); return false; }

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
    }
}