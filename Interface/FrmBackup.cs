using System.Windows.Forms;

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
    }
}
