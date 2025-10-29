using System;
using System.Windows.Forms;

namespace Batchup.Presentation.IViews
{
    public interface IFrmBackup
    {
        // Propriedades dos Controles do Form
        string Empresa { get; set; }
        string Caixa { get; set; }
        string Dias { get; set; }
        string LocalBackup { get; set; }
        string LocalCopia { get; set; }

        // Eventos do Form
        event EventHandler VoltarClicked;
        event EventHandler LocalBackupClicked;
        event EventHandler LocalCopiaClicked;
        event EventHandler ConcluirClicked;
        event EventHandler FecharClicked;

        // Métodos
        void Show();
        void Hide();
        void Close();
        void ShowMessage(string message, string title, MessageBoxIcon icon);
        void ShowForm();
    }
}