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
                    if (string.IsNullOrEmpty(txt.Text))
                        txt.Text = txt.PlaceholderText;
                }

                if (control.HasChildren)
                    Preencher(control);
            }
        }
    }
}