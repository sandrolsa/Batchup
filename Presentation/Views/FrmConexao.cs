using System;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Batchup.Presentation.IViews;
using Guna.UI2.WinForms;

namespace Batchup.Presentation.Views
{
    public partial class FrmConexao : Form, IFrmConexao
    {
        // ----------------------------------------------------
        // PROPRIEDADES DA INTERFACE (Mecanismo de Data Binding)
        // ----------------------------------------------------
        // Essas propriedades permitem que o Presenter LEIA e ESCREVA dados na UI,
        // sem saber o nome exato dos controles (ex: txtServidor).
        public string Servidor { get => txtServidor.Text; set => txtServidor.Text = value; }
        public string Porta { get => txtPorta.Text; set => txtPorta.Text = value; }
        public string Usuario { get => txtUsuario.Text; set => txtUsuario.Text = value; }
        public string Senha { get => txtSenha.Text; set => txtSenha.Text = value; }
        public string Banco { get => txtBanco.Text; set => txtBanco.Text = value; }
        public string Diretorio { get => txtDiretorio.Text; set => txtDiretorio.Text = value; }

        // ----------------------------------------------------
        // EVENTOS DA INTERFACE (Repassam Ações do Usuário)
        // ----------------------------------------------------
        // O Presenter se inscreve nestes eventos. A View apenas os dispara.
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
        // ----------------------------------------------------
        // ASSINATURA DE EVENTOS (Liga Controles aos Eventos da Interface)
        // ----------------------------------------------------
        // Esta é a única lógica de eventos permitida na View.
        // Ela mapeia o clique do botão (controle) para o disparo do evento (interface).
        private void SubscribeToEvents()
        {
            btnVoltar.Click += (s, e) => VoltarClicked?.Invoke(this, EventArgs.Empty);
            btnDir.Click += (s, e) => DiretorioClicked?.Invoke(this, EventArgs.Empty);
            btnCarregar.Click += (s, e) => CarregarClicked?.Invoke(this, EventArgs.Empty);
            btnAvancar.Click += (s, e) => AvancarClicked?.Invoke(this, EventArgs.Empty);
            btnTestar.Click += (s, e) => TestarClicked?.Invoke(this, EventArgs.Empty);
            btnFechar.Click += (s, e) => FecharClicked?.Invoke(this, EventArgs.Empty);
        }

        // ----------------------------------------------------
        // MÉTODOS DA INTERFACE (Comportamento Básico da UI)
        // ----------------------------------------------------
        // Implementações mínimas que o Presenter usa para manipular o display.
        public void ShowMessage(string message, string title, MessageBoxIcon icon)
            => MessageBox.Show(this, message, title, MessageBoxButtons.OK, icon);
        public void ShowForm() => this.ShowDialog();
        public new void Show() => base.Show();
        public new void Hide() => base.Hide();
        public new void Close() => base.Close();

        public void IfNullDefault()
        {
            IfNullDefault(this);
        }
        // ----------------------------------------------------
        // LÓGICA DE APRESENTAÇÃO (Preenchimento de Valor Padrão)
        // ----------------------------------------------------
        // Função pública chamada pelo Presenter para aplicar valores padrão.
        private void IfNullDefault(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Guna2TextBox txt)
                {
                    if (string.IsNullOrWhiteSpace(txt.Text) && !string.IsNullOrEmpty(txt.PlaceholderText))
                        txt.Text = txt.PlaceholderText;
                }

                if (ctrl.HasChildren)
                    IfNullDefault(ctrl);
            }
        }
    }
}
