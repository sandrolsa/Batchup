using System;
using System.Windows.Forms;

namespace Batchup.Presentation.IViews
{
    public interface IFrmConexao
    {
        // Propriedades
        string Servidor { get; set; }
        string Porta { get; set; }
        string Usuario { get; set; }
        string Senha { get; set; }
        string Banco { get; set; }
        string Diretorio { get; set; }

        // Eventos disparados pela View
        event EventHandler VoltarClicked;
        event EventHandler DiretorioClicked;
        event EventHandler CarregarClicked;
        event EventHandler AvancarClicked;
        event EventHandler TestarClicked;
        event EventHandler FecharClicked;

        // Métodos que o presenter pode chamar
        void Show();
        void Hide();
        void Close();
        void ShowMessage(string message, string title, MessageBoxIcon icon);
        void ShowForm();
    }
}