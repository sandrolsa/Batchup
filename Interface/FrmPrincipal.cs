using System;
using System.Drawing;
using System.Windows.Forms;

namespace Batchup.Interface
{
    public partial class FrmPrincipal : Form
    {
        private FrmConexao frmConexao;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        #region  Texto dos Botões   
        //btnCriar Text
        private void btnCriar_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Texto principal
            using (var fontTitle = new Font("Segoe UI", 11, FontStyle.Bold))
            using (var brushTitle = new SolidBrush(Color.Black))
                g.DrawString("Criar Backup", fontTitle, brushTitle, new PointF(80, 15));

            // Subtítulo
            using (var fontSub = new Font("Segoe UI", 9))
            using (var brushSub = new SolidBrush(Color.DimGray))
                g.DrawString("Cria um novo arquivo .bat", fontSub, brushSub, new PointF(80, 32));
        }
        //btnAgendar Text
        private void btnAgendar_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Texto principal
            using (var fontTitle = new Font("Segoe UI", 11, FontStyle.Bold))
            using (var brushTitle = new SolidBrush(Color.Black))
                g.DrawString("Agendar Backup", fontTitle, brushTitle, new PointF(80, 15));

            // Subtítulo
            using (var fontSub = new Font("Segoe UI", 9))
            using (var brushSub = new SolidBrush(Color.DimGray))
                g.DrawString("Cria uma tarefa agendada.", fontSub, brushSub, new PointF(80, 32));
        }
        //btnExcluir Text
        private void btnExcluir_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Texto principal
            using (var fontTitle = new Font("Segoe UI", 11, FontStyle.Bold))
            using (var brushTitle = new SolidBrush(Color.Black))
                g.DrawString("Excluir Backup", fontTitle, brushTitle, new PointF(80, 15));

            // Subtítulo
            using (var fontSub = new Font("Segoe UI", 9))
            using (var brushSub = new SolidBrush(Color.DimGray))
                g.DrawString("Exclui a bat e a agenda.", fontSub, brushSub, new PointF(80, 32));
        }
        #endregion

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (frmConexao == null || frmConexao.IsDisposed)
            {
                frmConexao = new FrmConexao(this);
            }
            this.Hide();
            frmConexao.Show();
        }
    }
}
