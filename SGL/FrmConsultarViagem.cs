using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGL
{
    public partial class FrmConsultarViagem : Form
    {
        // Botão criado por código (não precisa mexer no Designer)
        private Button btn_Detalhes;

        public FrmConsultarViagem()
        {
            InitializeComponent();

            // Eventos (o Load já é ligado pelo Designer)
            btnAplicarFiltros.Click += btnAplicarFiltros_Click;
            btn_Limpar.Click += btn_Limpar_Click;

            // Botão "Detalhes / Custo" dentro da caixa de filtros
            btn_Detalhes = new Button();
            btn_Detalhes.Name = "btn_Detalhes";
            btn_Detalhes.Text = "Custo da viagem";
            btn_Detalhes.Location = new Point(23, 280);
            btn_Detalhes.Size = new Size(196, 33);
            btn_Detalhes.Click += btn_Detalhes_Click;
            groupBox1.Controls.Add(btn_Detalhes);

            Tema.Aplicar(this);
        }

        private void FrmConsultarViagem_Load(object sender, EventArgs e)
        {
            cmb_Status.Items.Clear();
            cmb_Status.Items.Add("Todos");
            cmb_Status.Items.Add("Em Andamento");
            cmb_Status.Items.Add("Concluída");
            cmb_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Status.SelectedIndex = 0;

            // Datas só valem quando a caixinha estiver marcada
            dtp_SaidaDe.ShowCheckBox = true;
            dtp_SaidaAte.ShowCheckBox = true;
            dtp_SaidaDe.Checked = false;
            dtp_SaidaAte.Checked = false;

            dgv_Resultados.ReadOnly = true;
            dgv_Resultados.AllowUserToAddRows = false;
            dgv_Resultados.AllowUserToDeleteRows = false;
            dgv_Resultados.MultiSelect = false;
            dgv_Resultados.RowHeadersVisible = false;
            dgv_Resultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Resultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CarregarViagens();
        }

        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            CarregarViagens();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            cmb_Status.SelectedIndex = 0;
            dtp_SaidaDe.Checked = false;
            dtp_SaidaAte.Checked = false;
            CarregarViagens();
        }

        private void CarregarViagens()
        {
            try
            {
                var sql = new StringBuilder(
                    @"SELECT v.viagemID AS 'ID', ve.placa AS 'Veículo (Placa)', m.nome AS 'Motorista',
                             CONCAT(r.origem, ' > ', r.destino) AS 'Rota',
                             v.data_saida AS 'Saída', v.data_chegada AS 'Chegada', v.situacao AS 'Status'
                      FROM viagem v
                      INNER JOIN veiculo ve ON ve.veiculoID = v.veiculoID
                      INNER JOIN motorista m ON m.motoristaID = v.motoristaID
                      INNER JOIN rota r ON r.rotaID = v.rotaID
                      WHERE 1 = 1 ");

                var tabela = new DataTable();
                using (var conn = Conexao.Criar())
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    string status = cmb_Status.SelectedItem == null ? "Todos" : cmb_Status.SelectedItem.ToString();
                    if (status != "Todos")
                    {
                        sql.Append("AND v.situacao = @status ");
                        cmd.Parameters.AddWithValue("@status", status);
                    }
                    if (dtp_SaidaDe.Checked)
                    {
                        sql.Append("AND v.data_saida >= @de ");
                        cmd.Parameters.AddWithValue("@de", dtp_SaidaDe.Value.Date);
                    }
                    if (dtp_SaidaAte.Checked)
                    {
                        sql.Append("AND v.data_saida < @ate ");
                        cmd.Parameters.AddWithValue("@ate", dtp_SaidaAte.Value.Date.AddDays(1));
                    }
                    sql.Append("ORDER BY v.viagemID");
                    cmd.CommandText = sql.ToString();

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(tabela);
                    }
                }
                dgv_Resultados.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar as viagens: " + ex.Message);
            }
        }

        private void btn_Detalhes_Click(object sender, EventArgs e)
        {
            if (dgv_Resultados.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma viagem na lista.");
                return;
            }
            int id = Convert.ToInt32(dgv_Resultados.CurrentRow.Cells[0].Value);
            CalcularCustoViagem(id);
        }

        // Custo = (distância ÷ consumo médio) × preço mais recente do combustível
        private void CalcularCustoViagem(int viagemId)
        {
            try
            {
                decimal distancia = 0, consumo = 0;
                using (var conn = Conexao.Criar())
                {
                    conn.Open();

                    string sql = @"SELECT r.distancia, ve.consumo_medio
                                   FROM viagem v
                                   INNER JOIN rota r ON r.rotaID = v.rotaID
                                   INNER JOIN veiculo ve ON ve.veiculoID = v.veiculoID
                                   WHERE v.viagemID = @id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", viagemId);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (!dr.Read())
                            {
                                MessageBox.Show("Viagem não encontrada.");
                                return;
                            }
                            distancia = Convert.ToDecimal(dr["distancia"]);
                            consumo = Convert.ToDecimal(dr["consumo_medio"]);
                        }
                    }

                    object precoObj;
                    using (var cmd = new MySqlCommand(
                        "SELECT preco FROM preco_combustivel ORDER BY data_consulta DESC, precoID DESC LIMIT 1", conn))
                    {
                        precoObj = cmd.ExecuteScalar();
                    }
                    if (precoObj == null || precoObj == DBNull.Value)
                    {
                        MessageBox.Show("Cadastre o preço do combustível para calcular o custo.");
                        return;
                    }
                    decimal preco = Convert.ToDecimal(precoObj);

                    if (consumo <= 0)
                    {
                        MessageBox.Show("O consumo médio do veículo é inválido.");
                        return;
                    }

                    decimal litros = distancia / consumo;
                    decimal custo = litros * preco;
                    var cult = new CultureInfo("pt-BR");

                    MessageBox.Show(
                        "Distância: " + distancia.ToString("N2", cult) + " Km\n" +
                        "Consumo médio: " + consumo.ToString("N2", cult) + " Km/L\n" +
                        "Litros necessários: " + litros.ToString("N2", cult) + " L\n" +
                        "Preço do combustível: R$ " + preco.ToString("N2", cult) + "\n\n" +
                        "Custo estimado: R$ " + custo.ToString("N2", cult),
                        "Custo da viagem " + viagemId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular o custo: " + ex.Message);
            }
        }
    }
}
