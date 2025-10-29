using System;
using System.Windows.Forms;

namespace Batchup.Presentation.IViews
{
    public interface IFrmPrincipal
    {
        // Eventos disparados pela View
        event EventHandler CriarBackupClicked;
        event EventHandler AgendarBackupClicked;
        event EventHandler ExcluirBackupClicked;
        event EventHandler FecharClicked;

        // Métodos que o presenter pode chamar
        void ShowForm(Form form);
        void ShowMessage(string title, string message, MessageBoxIcon icon);
        void HideForm();
        void ShowView();
    }
}
