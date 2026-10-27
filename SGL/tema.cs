using System;
using System.Drawing;
using System.Windows.Forms;

namespace SGL
{
    public static class Tema
    {
        private static readonly Color Fundo = Color.FromArgb(244, 247, 251);
        private static readonly Color Azul = Color.FromArgb(37, 99, 235);
        private static readonly Color AzulEscuro = Color.FromArgb(30, 64, 175);
        private static readonly Color Verde = Color.FromArgb(22, 163, 74);
        private static readonly Color Vermelho = Color.FromArgb(220, 38, 38);
        private static readonly Color Cinza = Color.FromArgb(100, 116, 139);
        private static readonly Color Texto = Color.FromArgb(30, 41, 59);
        private static readonly Color LinhaAlternada = Color.FromArgb(238, 242, 255);

        private const AnchorStyles TodosLados =
            AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

        public static void Aplicar(Form form)
        {
            form.BackColor = Fundo;
            form.ForeColor = Texto;
            AplicarEm(form.Controls);
        }

        private static void AplicarEm(Control.ControlCollection controles)
        {
            foreach (Control c in controles)
            {
                Estilizar(c);
                if (c.HasChildren) AplicarEm(c.Controls);
            }
        }

        private static void Estilizar(Control c)
        {
            if (c is Button)
            {
                var b = (Button)c;
                string nome = b.Name.ToLower();
                Color cor = Azul;
                if (nome.Contains("excluir")) cor = Vermelho;
                else if (nome.Contains("novo")) cor = Verde;
                else if (nome.Contains("limpar") || nome.Contains("cancelar") || nome.Contains("sair")) cor = Cinza;

                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = cor;
                b.ForeColor = Color.White;
                b.FlatAppearance.MouseOverBackColor = Escurecer(cor);
                b.Cursor = Cursors.Hand;
            }
            else if (c is DataGridView)
            {
                var g = (DataGridView)c;
                g.EnableHeadersVisualStyles = false;
                g.BackgroundColor = Color.White;
                g.BorderStyle = BorderStyle.None;
                g.GridColor = Color.FromArgb(226, 232, 240);
                g.ColumnHeadersDefaultCellStyle.BackColor = AzulEscuro;
                g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                g.ColumnHeadersDefaultCellStyle.SelectionBackColor = AzulEscuro;
                g.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                g.AlternatingRowsDefaultCellStyle.BackColor = LinhaAlternada;
                g.DefaultCellStyle.SelectionBackColor = Azul;
                g.DefaultCellStyle.SelectionForeColor = Color.White;

                g.Anchor = TodosLados; // o grid cresce com a janela
            }
            else if (c is TabControl)
            {
                c.Anchor = TodosLados; // as abas crescem com a janela
            }
            else if (c is TabPage)
            {
                var t = (TabPage)c;
                t.UseVisualStyleBackColor = false;
                t.BackColor = Fundo;
            }
            else if (c is GroupBox)
            {
                c.ForeColor = AzulEscuro;

                // a caixa que contém um grid (ex.: "Resultados da Viagem") cresce com a janela
                foreach (Control filho in c.Controls)
                {
                    if (filho is DataGridView)
                    {
                        c.Anchor = TodosLados;
                        break;
                    }
                }
            }
            else if (c is Label)
            {
                var l = (Label)c;
                l.BackColor = Color.Transparent;
                l.ForeColor = l.Font.Size >= 14 ? AzulEscuro : Texto;
            }
            else if (c is CheckBox)
            {
                c.BackColor = Color.Transparent;
                c.ForeColor = Texto;
            }
        }

        private static Color Escurecer(Color cor)
        {
            return Color.FromArgb(cor.R * 80 / 100, cor.G * 80 / 100, cor.B * 80 / 100);
        }
    }
}
