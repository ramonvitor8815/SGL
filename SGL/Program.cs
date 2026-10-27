using System;
using System.Windows.Forms;

namespace SGL
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                // Tela de login: se fechar sem entrar, o sistema encerra
                using (var login = new FrmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK) break;
                }

                var principal = new Form1();
                Application.Run(principal);

                // Só volta ao login se o usuário clicou em Sair
                if (!principal.VoltarAoLogin) break;
            }
        }
    }
}
