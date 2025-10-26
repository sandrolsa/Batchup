using System;
using System.IO;
using System.Windows.Forms;
using Batchup.Config;
using Batchup.Controlador;
using Batchup.Servicos;

namespace Batchup.Interface
{
    public partial class FrmConexao : Form
    {
        #region Load
        private FrmPrincipal frmPrincipal;
        private FrmBackup frmBackup;
        public FrmConexao (FrmPrincipal principal)
        {
            InitializeComponent ();
            frmPrincipal = principal;
        }
        public FrmConexao()
        {
            InitializeComponent();
            this.AcceptButton = btnTestar;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RegistrarEnterNosTextBoxes(this);
        }
        #endregion
        #region Pressionar Enter para testar
        private void RegistrarEnterNosTextBoxes(Control container)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is Guna.UI2.WinForms.Guna2TextBox txt)
                {
                    txt.KeyDown += (s, ev) =>
                    {
                        if (ev.KeyCode == Keys.Enter)
                        {
                            ev.SuppressKeyPress = true; // evita beep
                            btnTestar.PerformClick();
                        }
                    };
                }

                // se o controle tiver filhos, entra neles também
                if (ctrl.HasChildren)
                    RegistrarEnterNosTextBoxes(ctrl);
            }
        }
        #endregion

        #region Voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal.Show();
        }
        #endregion Voltar

        #region Fechar
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Diretório
        private void btnDir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecione o arquivo DbMysql para leitura.";
                ofd.InitialDirectory = @"C:\Checkout_On\";
                ofd.Filter = "Arquivos INI (*.ini)|*.ini|Todos os arquivos (*.*)|*.*";
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtDiretorio.Text = ofd.FileName;
                }
            }
        }
        #endregion

        #region Carregar .ini
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiretorio.Text) || !File.Exists(txtDiretorio.Text))
            {
                MessageBox.Show("Por favor, selecione um arquivo .ini primeiro.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var (servidor, porta, banco, usuario, senha) = ArquivoIni.LerIni(txtDiretorio.Text);
                txtServidor.Text = servidor;
                txtPorta.Text = porta;
                txtUsuario.Text = usuario;
                txtSenha.Text = senha;
                txtBanco.Text = banco;

                MessageBox.Show("Dados carregados com sucesso!",
                    "Leitura concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao ler o arquivo .ini:\n{ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Avançar
        private void btnAvancar_Click(object sender, EventArgs e)
        {
            

            if (frmBackup == null || frmBackup.IsDisposed)
            {
                frmBackup = new FrmBackup(this);
            }
            this.Hide();
            frmBackup.Show();
        }
        #endregion

        #region Testar
        private void btnTestar_Click(object sender, EventArgs e)
        {
            PreencherBox.Preencher(this);
            ConfigConexao config = new ConfigConexao
                (
                txtServidor.Text,
                txtPorta.Text,
                txtUsuario.Text,
                txtSenha.Text,
                txtBanco.Text
                );
            string resultado = ControleConexao.TestarConexao(config);
            MessageBox.Show(resultado, "Teste de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

    }
}
