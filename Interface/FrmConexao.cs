using System;
using System.Windows.Forms;

namespace Batchup.Interface
{
    public partial class FrmConexao : Form
    {
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
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDir_Click(object sender, EventArgs e)
        {

        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (frmBackup == null || frmBackup.IsDisposed)
            {
                frmBackup = new FrmBackup(this);
            }
            this.Hide();
            frmBackup.Show();
        }
    }
}
