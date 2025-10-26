using System.Windows.Forms;

namespace Batchup.Servicos
{
    public static class PreencherBox
    {
        public static void Preencher(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2TextBox txt)
                {
                    // IGNORAR CAMPOS ESPECÍFICOS
                    if (ignorar(txt))
                        continue;

                    if (string.IsNullOrEmpty(txt.Text))
                        txt.Text = txt.PlaceholderText;
                }

                if (control.HasChildren)
                    Preencher(control);
            }
        }

        private static bool ignorar(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            // IGNORAR Senha (FrmConexao) e DirCopia (FrmBackup)
            string nome = (string)textBox.Name.Clone();
            return nome.Contains("Senha") || nome.Contains("DirCopia");
        }
    }
}