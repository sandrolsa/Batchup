using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Batchup.Config;
using Batchup.Controlador;
using Batchup.Servicos;

namespace Batchup.Interface
{
    public partial class FrmConexao : Form
    {
        #region LOAD
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

        #region ENTER TESTA
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

        #region VOLTAR
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal.Show();
        }
        #endregion Voltar

        #region FECHAR
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // tenta usar a referência passada
            FrmPrincipal principal = frmPrincipal;

            // se a referência for nula, tenta achar uma instância aberta do app
            if (principal == null)
                principal = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();

            // se não encontrou, cria uma nova instância
            if (principal == null)
                principal = new FrmPrincipal();

            // mostra o principal e deixa o FrmConexao fechar (não cancela o evento)
            principal.Show();
            // NOTA: não colocar e.Cancel = true aqui se você quer que o FrmConexao seja fechado de verdade
        }
        #endregion

        #region DIRETORIO
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

        #region INI
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

        #region AVANÇAR
        private void btnAvancar_Click(object sender, EventArgs e)
        {
            ArquivoConexao.ConfigConexao = new ConfigConexao
                           (
                            txtServidor.Text,
                            txtPorta.Text,
                            txtUsuario.Text,
                            txtSenha.Text,
                            txtBanco.Text
                            );

            if (frmBackup == null || frmBackup.IsDisposed)
            {
                frmBackup = new FrmBackup(this);
            }
            this.Hide();
            frmBackup.Show();
        }
        #endregion

        #region TESTAR
        private void btnTestar_Click(object sender, EventArgs e)
        {
            PreencherBox.Preencher(this);
            ArquivoConexao.ConfigConexao = new ConfigConexao
                (
                txtServidor.Text,
                txtPorta.Text,
                txtUsuario.Text,
                txtSenha.Text,
                txtBanco.Text
                );
            string resultado = ControleConexao.TestarConexao(ArquivoConexao.ConfigConexao);
            MessageBox.Show(resultado, "Teste de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

    }
}
