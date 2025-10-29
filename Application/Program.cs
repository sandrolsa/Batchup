using System;
using System.Windows.Forms;
using Batchup.Presentation.Views;

namespace Batchup
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializar a View principal. Ajuste se preferir abrir FrmAgendar diretamente.
            Application.Run(new FrmPrincipal());
        }
    }
}