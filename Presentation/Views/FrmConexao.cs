using System;
using System.Windows.Forms;
using Batchup.Presentation.IViews;

namespace Batchup.Presentation.Views
{
    public partial class FrmConexao : Form, IFrmConexao
    {
        // Propriedades da Interface View
        public string Servidor { get => txtServidor.Text; set => txtServidor.Text = value; }
        public string Porta { get => txtPorta.Text; set => txtPorta.Text = value; }
        public string Usuario { get => txtUsuario.Text; set => txtUsuario.Text = value; }
        public string Senha { get => txtSenha.Text; set => txtSenha.Text = value; }
        public string Banco { get => txtBanco.Text; set => txtBanco.Text = value; }
        public string Diretorio { get => txtDiretorio.Text; set => txtDiretorio.Text = value; }

        // Eventos
        public event EventHandler VoltarClicked;
        public event EventHandler DiretorioClicked;
        public event EventHandler CarregarClicked;
        public event EventHandler AvancarClicked;
        public event EventHandler TestarClicked;
        public event EventHandler FecharClicked;

        public FrmConexao()
        {
            InitializeComponent();
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            btnVoltar.Click += (s, e) => VoltarClicked?.Invoke(this, EventArgs.Empty);
            btnDir.Click += (s, e) => DiretorioClicked?.Invoke(this, EventArgs.Empty);
            btnCarregar.Click += (s, e) => CarregarClicked?.Invoke(this, EventArgs.Empty);
            btnAvancar.Click += (s, e) => AvancarClicked?.Invoke(this, EventArgs.Empty);
            btnTestar.Click += (s, e) => TestarClicked?.Invoke(this, EventArgs.Empty);
            btnFechar.Click += (s, e) => FecharClicked?.Invoke(this, EventArgs.Empty);
        }

        // Métodos da Interface
        public void ShowMessage(string message, string title, MessageBoxIcon icon)
            => MessageBox.Show(this, message, title, MessageBoxButtons.OK, icon);
        public void ShowForm() => this.ShowDialog();
        public new void Show() => base.Show();
        public new void Hide() => base.Hide();
        public new void Close() => base.Close();
    }
}