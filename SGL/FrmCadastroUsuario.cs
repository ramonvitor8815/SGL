using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGL
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();

            txt_Senha.UseSystemPasswordChar = true;
            chk_Ativo.Checked = true;
            btn_Salvar.Click += btn_Salvar_Click;
            btn_Cancelar.Click += btn_Cancelar_Click;

            Tema.Aplicar(this);
            this.AcceptButton = btn_Salvar;
            this.CancelButton = btn_Cancelar;

            // Permite maximizar e mantém o conteúdo centralizado
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            foreach (Control c in this.Controls)
                c.Anchor = AnchorStyles.None;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nome.Text))
            { MessageBox.Show("Informe o nome."); txt_Nome.Focus(); return; }

            if (string.IsNullOrWhiteSpace(txt_Login.Text))
            { MessageBox.Show("Informe o login."); txt_Login.Focus(); return; }

            if (txt_Senha.Text.Length < 4)
            { MessageBox.Show("A senha deve ter pelo menos 4 caracteres."); txt_Senha.Focus(); return; }

            try
            {
                using (var conn = Conexao.Criar())
                {
                    conn.Open();
                    string sql = @"INSERT INTO usuario (nome, login, senha, ativo)
                                   VALUES (@nome, @login, @senha, @ativo)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", txt_Nome.Text.Trim());
                        cmd.Parameters.AddWithValue("@login", txt_Login.Text.Trim());
                        cmd.Parameters.AddWithValue("@senha", Seguranca.GerarHash(txt_Senha.Text));
                        cmd.Parameters.AddWithValue("@ativo", chk_Ativo.Checked ? 1 : 0);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Usuário cadastrado com sucesso!");
                this.Close();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Já existe um usuário com este login.");
                txt_Login.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
