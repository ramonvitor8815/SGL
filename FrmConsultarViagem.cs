using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGL
{
    public partial class FrmConsultarViagem : Form
    {
        public FrmConsultarViagem()
        {
            InitializeComponent();

            btn_AplicarFiltros.Click += btn_AplicarFiltros_Click;
            btn_Detalhes.Click += btn_Detalhes_Click;
        }

        private void FrmConsultarViagem_Load(object sender, EventArgs e)
        {
            // Status
            cmb_Status.Items.Clear();
            cmb_Status.Items.Add("Todos");
            cmb_Status.Items.Add("Em Andamento");
            cmb_Status.Items.Add("Concluída");
            cmb_Status.SelectedIndex = 0;

            // Período: só vale se a caixinha do DateTimePicker estiver marcada
            dtp_De.Format = DateTimePickerFormat.Short;
            dtp_Ate.Format = DateTimePickerFormat.Short;
            dtp_De.ShowCheckBox = true;
            dtp_Ate.ShowCheckBox = true;
            dtp_De.Checked = false;
            dtp_Ate.Checked = false;

            // Grid
            dgv_Resultados.ReadOnly = true;
            dgv_Resultados.AllowUserToAddRows = false;
            dgv_Resultados.AllowUserToDeleteRows = false;
            dgv_Resultados.MultiSelect = false;
            dgv_Resultados.RowHeadersVisible = false;
            dgv_Resultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Resultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CarregarViagens();
        }

        private void btn_AplicarFiltros_Click(object sender, EventArgs e)
        {
            if (dtp_De.Checked && dtp_Ate.Checked && dtp_Ate.Value.Date < dtp_De.Value.Date)
            {
                MessageBox.Show("A data final não pode ser anterior à data inicial.");
                return;
            }
            CarregarViagens();
        }

        private void CarregarViagens()
        {
            try
            {
                string sql = @"SELECT v.viagemID AS 'ID',
                                      ve.placa AS 'Veículo (Placa)',
                                      m.nome AS 'Motorista',
                                      CONCAT(r.origem, ' > ', r.destino) AS 'Rota',
                                      v.data_saida AS 'Data de Saída',
                                      v.data_chegada AS 'Data de Chegada',
                                      v.situacao AS 'Status'
                               FROM viagem v
                               INNER JOIN veiculo ve ON ve.veiculoID = v.veiculoID
                               INNER JOIN motorista m ON m.motoristaID = v.motoristaID
                               INNER JOIN rota r ON r.rotaID = v.rotaID
                               WHERE 1 = 1";

                using (var conn = Conexao.Criar())
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    if (cmb_Status.SelectedIndex > 0)
                    {
                        sql += " AND v.situacao = @status";
                        cmd.Parameters.AddWithValue("@status", cmb_Status.Text);
                    }
                    if (dtp_De.Checked)
                    {
                        sql += " AND v.data_saida >= @de";
                        cmd.Parameters.AddWithValue("@de", dtp_De.Value.Date);
                    }
                    if (dtp_Ate.Checked)
                    {
                        sql += " AND v.data_saida < @ate";
                        cmd.Parameters.AddWithValue("@ate", dtp_Ate.Value.Date.AddDays(1));
                    }
                    sql += " ORDER BY v.data_saida DESC";
                    cmd.CommandText = sql;

                    var tabela = new DataTable();
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(tabela);
                    }
                    dgv_Resultados.DataSource = tabela;
                }
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

            var c = dgv_Resultados.CurrentRow.Cells;
            string chegada = c["Data de Chegada"].Value == DBNull.Value
                ? "Ainda não chegou"
                : Convert.ToDateTime(c["Data de Chegada"].Value).ToString("dd/MM/yyyy HH:mm");

            MessageBox.Show(
                "Viagem Nº " + c["ID"].Value + "\n\n" +
                "Veículo: " + c["Veículo (Placa)"].Value + "\n" +
                "Motorista: " + c["Motorista"].Value + "\n" +
                "Rota: " + c["Rota"].Value + "\n" +
                "Saída: " + Convert.ToDateTime(c["Data de Saída"].Value).ToString("dd/MM/yyyy HH:mm") + "\n" +
                "Chegada: " + chegada + "\n" +
                "Status: " + c["Status"].Value,
                "Detalhes da viagem");
        }
    }
}
