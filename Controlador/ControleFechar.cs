using System;
using System.Windows.Forms;

namespace Batchup.Interface
{
    public class ControleFechar : Form
    {
        protected Form formAnterior;

        public ControleFechar(Form formAnterior = null)
        {
            this.formAnterior = formAnterior;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Quando o usuário fecha o formulário secundário
            if (formAnterior != null)
            {
                formAnterior.Show();
                e.Cancel = true; // evita fechar completamente o app
                this.Hide();
            }
            else
            {
                Application.Exit(); // se não há anterior, fecha o app
            }
        }

        protected void Voltar()
        {
            if (formAnterior != null)
            {
                this.Hide();
                formAnterior.Show();
            }
        }
    }
}