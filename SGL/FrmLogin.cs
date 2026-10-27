using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGL
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            txt_Senha.UseSystemPasswordChar = true;
            this.AcceptButton = btn_Entrar;
            btn_Entrar.Click += btn_Entrar_Click;
            btn_Cadastrar.Click += btn_Cadastrar_Click;

            Tema.Aplicar(this);

            // Permite maximizar e mantém o conteúdo centralizado
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            foreach (Control c in this.Controls)
                c.Anchor = AnchorStyles.None;
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Usuario.Text))
            {
                MessageBox.Show("Informe o usuário.");
                txt_Usuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_Senha.Text))
            {
                MessageBox.Show("Informe a senha.");
                txt_Senha.Focus();
                return;
            }

            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = "SELECT senha, ativo FROM usuario WHERE login = @login";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", txt_Usuario.Text.Trim());
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (!dr.Read() || !Seguranca.Verificar(txt_Senha.Text, dr["senha"].ToString()))
                            {
                                MessageBox.Show("Usuário ou senha incorretos.");
                                txt_Senha.Clear();
                                txt_Senha.Focus();
                                return;
                            }
                            if (Convert.ToInt32(dr["ativo"]) != 1)
                            {
                                MessageBox.Show("Este usuário está inativo. Procure o administrador.");
                                return;
                            }
                        }
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao entrar: " + ex.Message);
            }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmCadastroUsuario())
            {
                frm.ShowDialog(this);
            }
        }
    }
}
