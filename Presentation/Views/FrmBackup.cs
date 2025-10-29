using System;
using System.Reflection;
using System.Windows.Forms;
using Batchup.Presentation.IViews;
using Guna.UI2.WinForms;

namespace Batchup.Presentation.Views
{
    public partial class FrmBackup : Form, IFrmBackup
    {
        // Propriedades da Interface
        public string Empresa { get => txtEmpresa.Text; set => txtEmpresa.Text = value; }
        public string Caixa { get => txtCaixa.Text; set => txtCaixa.Text = value; }
        public string Dias { get => txtDias.Text; set => txtDias.Text = value; }
        public string LocalBackup { get => txtDirBackup.Text; set => txtDirBackup.Text = value; }
        public string LocalCopia { get => txtDirCopia.Text; set => txtDirCopia.Text = value; }

        // Eventos da Interface
        public event EventHandler VoltarClicked;
        public event EventHandler LocalBackupClicked;
        public event EventHandler LocalCopiaClicked;
        public event EventHandler ConcluirClicked;
        public event EventHandler FecharClicked;

        public FrmBackup()
        {
            InitializeComponent();
            ConectarEventos();
        }

        private void ConectarEventos()
        {
            btnVoltar.Click += (s, e) => VoltarClicked?.Invoke(this, EventArgs.Empty);
            btnDir.Click += (s, e) => LocalBackupClicked?.Invoke(this, EventArgs.Empty);
            btnDirCopia.Click += (s, e) => LocalCopiaClicked?.Invoke(this, EventArgs.Empty);
            btnConcluir.Click += (s, e) => ConcluirClicked?.Invoke(this, EventArgs.Empty);
            btnFechar.Click += (s, e) => FecharClicked?.Invoke(this, EventArgs.Empty);
        }

        // Métodos da Interface
        public void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, icon);
        }

        public void ShowForm()
        {
            this.Show();
        }

        public new void Show()
        {
            base.Show();
        }

        public new void Hide()
        {
            base.Hide();
        }

        public new void Close()
        {
            base.Close();
        }

        // CORREÇÃO: Adicione este método para forçar o fechamento
        public void ForceClose()
        {
            this.Close();
        }
    }
}