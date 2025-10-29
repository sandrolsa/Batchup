using System;
using System.Drawing;
using System.Windows.Forms;
using Batchup.Presentation.Presenters;
using Batchup.Presentation.IViews;

namespace Batchup.Presentation.Views
{
    public partial class FrmPrincipal : Form, IFrmPrincipal
    {
        private FrmPrincipalPresenter _presenter;

        #region Implementação da Interface
        public event EventHandler CriarBackupClicked;
        public event EventHandler AgendarBackupClicked;
        public event EventHandler ExcluirBackupClicked;
        public event EventHandler FecharClicked;

        public void ShowForm(Form form) => form.Show();

        public void ShowMessage(string title, string message, MessageBoxIcon icon)
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, icon);
        }

        public void HideForm() => this.Hide();
        #endregion

        public FrmPrincipal()
        {
            InitializeComponent();
            _presenter = new FrmPrincipalPresenter(this);
        }

        #region Eventos dos Botões
        private void btnCriar_Click(object sender, EventArgs e)
        {
            CriarBackupClicked?.Invoke(this, EventArgs.Empty);
        }
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            AgendarBackupClicked?.Invoke(this, EventArgs.Empty);
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirBackupClicked?.Invoke(this, EventArgs.Empty);
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            FecharClicked?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region Render Texto dos Botões
        private void btnCriar_Paint(object sender, PaintEventArgs e)
        {
            RenderButtonText(e.Graphics, "Criar Backup", "Cria um novo arquivo .bat");
        }

        private void btnAgendar_Paint(object sender, PaintEventArgs e)
        {
            RenderButtonText(e.Graphics, "Agendar Backup", "Cria uma tarefa agendada.");
        }

        private void btnExcluir_Paint(object sender, PaintEventArgs e)
        {
            RenderButtonText(e.Graphics, "Excluir Backup", "Exclui a bat e a agenda.");
        }

        private void RenderButtonText(Graphics g, string title, string subtitle)
        {
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Texto principal
            using (var fontTitle = new Font("Segoe UI", 11, FontStyle.Bold))
            using (var brushTitle = new SolidBrush(Color.Black))
                g.DrawString(title, fontTitle, brushTitle, new PointF(80, 15));

            // Subtítulo
            using (var fontSub = new Font("Segoe UI", 9))
            using (var brushSub = new SolidBrush(Color.DimGray))
                g.DrawString(subtitle, fontSub, brushSub, new PointF(80, 32));
        }
        #endregion
        public void ShowView()
        {
            this.Show(); // GARANTE que o form seja realmente exibido
            this.BringToFront(); // Traz para frente
            this.Focus(); // Dá foco
        }
    }
}
