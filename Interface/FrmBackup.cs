using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Batchup.Config;
using Batchup.Controlador;
using Batchup.Servicos;

namespace Batchup.Interface
{
    public partial class FrmBackup : Form
    {
        #region LOAD
        private FrmPrincipal frmPrincipal;
        private readonly FrmConexao frmConexao;
        public FrmBackup(FrmConexao conexao)
        {
            InitializeComponent ();
            frmConexao = conexao;
        }
        public FrmBackup(FrmPrincipal principal)
        {
            InitializeComponent();
            frmPrincipal = principal;
        }
        public FrmBackup()
        {
            InitializeComponent();
            this.AcceptButton = btnConcluir;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //RegistrarEnterNosTextBoxes(this);
        }
        #endregion LOAD

        #region FECHAR
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Se está fechando pelo X e não há outros forms abertos, fecha a aplicação
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Verifica se há outros forms abertos além deste
                var outrosForms = Application.OpenForms.Cast<Form>()
                    .Where(f => f != this && !f.IsDisposed)
                    .ToList();

                if (!outrosForms.Any())
                {
                    // Se não há outros forms, fecha a aplicação
                    Application.Exit();
                }
                else
                {
                    // Se há outros forms, apenas esconde este
                    e.Cancel = true;
                    this.Hide();

                    // Mostra o FrmPrincipal se existir
                    var principal = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
                    principal?.Show();
                }
            }
        }
        #endregion FECHAR

        #region VOLTAR
        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            this.Hide();

            // Tenta mostrar o FrmConexao se existir
            if (frmConexao != null && !frmConexao.IsDisposed)
            {
                frmConexao.Show();
            }
            else
            {
                // Se não tem FrmConexao, volta para o Principal
                var principal = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
                if (principal != null)
                {
                    principal.Show();
                }
                else
                {
                    new FrmPrincipal().Show();
                }
            }
        }
        #endregion VOLTAR

        #region BTN_DIR
        private void btnDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Selecione a pasta para salvar o backup.";
                fbd.SelectedPath = @"C:\Database\Backup\On\";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtDirBackup.Text = fbd.SelectedPath;
                }
            }
        }
        #endregion BTN_DIR

        #region BTN_WHATEVER
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Selecione a pasta para salvar a cópia.";
                fbd.SelectedPath = @"Rede";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtDirBackup.Text = fbd.SelectedPath;
                }
            }
        }
        #endregion BTN_WHATERVER

        #region BTN_CONCLUIR
        private void btnConcluir_Click(object sender, EventArgs e)
        {
            PreencherBox.Preencher(this);

            // VALIDAÇÃO DE NÚMEROS
            if (!int.TryParse(txtCaixa.Text, out int caixa) || caixa <= 0)
            {
                MessageBox.Show("Caixa deve ser um número válido maior que zero!");
                txtCaixa.Focus();
                return;
            }

            if (!int.TryParse(txtDias.Text, out int dias) || dias <= 0)
            {
                MessageBox.Show("Dias deve ser um número válido maior que zero!");
                txtDias.Focus();
                return;
            }

            var configBackup = new ConfigBackup
            {
                Empresa = txtEmpresa.Text,
                Caixa = int.Parse(txtCaixa.Text),
                Dias = int.Parse(txtDias.Text),
                LocalBackup = txtDirBackup.Text,
                LocalCopia = txtDirCopia.Text
            };

            string destinoBat = Path.Combine(txtDirBackup.Text, $"{configBackup.Empresa}.bat");
            var controleBackup = new ControleBackup();
            controleBackup.CriarArquivoBat(ArquivoConexao.ConfigConexao, configBackup, destinoBat);
            var controleArquivos = new ControleArquivos();
            controleArquivos.CopiarArquivos(txtDirBackup.Text);
            MessageBox.Show("Bat configurada com sucesso!", "Concluído",
       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
