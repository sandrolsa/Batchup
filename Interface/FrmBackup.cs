using System;
using System.IO;
using System.Windows.Forms;
using Batchup.Config;
using Batchup.Controlador;
using Batchup.Servicos;

namespace Batchup.Interface
{
    public partial class FrmBackup : Form
    {
        private FrmConexao frmConexao;
        public FrmBackup(FrmConexao conexao)
        {
            InitializeComponent ();
            frmConexao = conexao;
        }
        public FrmBackup()
        {
            InitializeComponent();
            this.AcceptButton = btnConcluir;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RegistrarEnterNosTextBoxes(this);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            frmConexao.Show();
        }
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
                            btnConcluir.PerformClick();
                        }
                    };
                }

                // se o controle tiver filhos, entra neles também
                if (ctrl.HasChildren)
                    RegistrarEnterNosTextBoxes(ctrl);
            }
        }

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

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            PreencherBox.Preencher(this);

            var configBackup = new ConfigBackup
            {
                Empresa = txtEmpresa.Text,
                Caixa = int.Parse(txtCaixa.Text),
                Dias = int.Parse(txtDias.Text),
                LocalBackup = txtDirBackup.Text,
                LocalCopia = txtDirCopia.Text
            };

            var configConexao = ConfigurarConexao();
            string destinoBat = Path.Combine(txtDirBackup.Text, $"{configBackup.Empresa}.bat");

            var controleBackup = new ControleBackup();
            controleBackup.CriarArquivoBat(configConexao, configBackup, destinoBat);
            ControleArquivos(txtDirBackup.Text);

            copiarArquivos (txtDirBackup.Text);

            MessageBox.Show("Bat configurada com sucesso!", "Concluído",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
