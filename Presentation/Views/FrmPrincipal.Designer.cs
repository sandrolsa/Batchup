namespace Batchup.Presentation.Views
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.icoTitle = new System.Windows.Forms.PictureBox();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlButoes = new System.Windows.Forms.Panel();
            this.btnCriar = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgendar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.lblNome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnFechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dragPrincipal = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoTitle)).BeginInit();
            this.pnlButoes.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.icoTitle);
            this.pnlTitulo.Controls.Add(this.lblSubTitle);
            this.pnlTitulo.Controls.Add(this.lblTitle);
            this.pnlTitulo.Location = new System.Drawing.Point(12, 56);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(528, 133);
            this.pnlTitulo.TabIndex = 0;
            // 
            // icoTitle
            // 
            this.icoTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icoTitle.BackgroundImage")));
            this.icoTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icoTitle.Location = new System.Drawing.Point(236, 12);
            this.icoTitle.Name = "icoTitle";
            this.icoTitle.Size = new System.Drawing.Size(56, 56);
            this.icoTitle.TabIndex = 2;
            this.icoTitle.TabStop = false;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(183, 110);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(163, 20);
            this.lblSubTitle.TabIndex = 0;
            this.lblSubTitle.Text = "Gerenciador de backup";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(197, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Batchup";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlButoes
            // 
            this.pnlButoes.Controls.Add(this.btnCriar);
            this.pnlButoes.Controls.Add(this.btnExcluir);
            this.pnlButoes.Controls.Add(this.btnAgendar);
            this.pnlButoes.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButoes.Location = new System.Drawing.Point(12, 189);
            this.pnlButoes.Name = "pnlButoes";
            this.pnlButoes.Size = new System.Drawing.Size(528, 361);
            this.pnlButoes.TabIndex = 0;
            // 
            // btnCriar
            // 
            this.btnCriar.Animated = true;
            this.btnCriar.BackColor = System.Drawing.Color.Transparent;
            this.btnCriar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCriar.BorderColor = System.Drawing.Color.Empty;
            this.btnCriar.BorderRadius = 15;
            this.btnCriar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnCriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriar.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCriar.CustomImages.ImageSize = new System.Drawing.Size(80, 80);
            this.btnCriar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCriar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCriar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCriar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCriar.FillColor = System.Drawing.SystemColors.Window;
            this.btnCriar.FocusedColor = System.Drawing.SystemColors.ControlLight;
            this.btnCriar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCriar.ForeColor = System.Drawing.Color.White;
            this.btnCriar.HoverState.FillColor = System.Drawing.SystemColors.Window;
            this.btnCriar.HoverState.Image = global::Batchup.Properties.Resources.hover_adiciona;
            this.btnCriar.Image = global::Batchup.Properties.Resources.adiciona;
            this.btnCriar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCriar.ImageSize = new System.Drawing.Size(80, 80);
            this.btnCriar.IndicateFocus = true;
            this.btnCriar.Location = new System.Drawing.Point(22, 31);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnCriar.PressedDepth = 50;
            this.btnCriar.ShadowDecoration.BorderRadius = 30;
            this.btnCriar.ShadowDecoration.Depth = 10;
            this.btnCriar.ShadowDecoration.Enabled = true;
            this.btnCriar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnCriar.Size = new System.Drawing.Size(486, 80);
            this.btnCriar.TabIndex = 2;
            this.btnCriar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCriar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnCriar.UseTransparentBackground = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            this.btnCriar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnCriar_Paint);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Animated = true;
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluir.BorderColor = System.Drawing.Color.Empty;
            this.btnExcluir.BorderRadius = 15;
            this.btnExcluir.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcluir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcluir.FillColor = System.Drawing.Color.White;
            this.btnExcluir.FocusedColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.HoverState.FillColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.HoverState.Image = global::Batchup.Properties.Resources.hover_excluir;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExcluir.ImageSize = new System.Drawing.Size(80, 80);
            this.btnExcluir.IndicateFocus = true;
            this.btnExcluir.Location = new System.Drawing.Point(22, 253);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExcluir.PressedDepth = 50;
            this.btnExcluir.ShadowDecoration.BorderRadius = 30;
            this.btnExcluir.ShadowDecoration.Depth = 10;
            this.btnExcluir.ShadowDecoration.Enabled = true;
            this.btnExcluir.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnExcluir.Size = new System.Drawing.Size(486, 80);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExcluir.UseTransparentBackground = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.Paint += new System.Windows.Forms.PaintEventHandler(this.btnExcluir_Paint);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Animated = true;
            this.btnAgendar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgendar.BorderColor = System.Drawing.Color.Empty;
            this.btnAgendar.BorderRadius = 15;
            this.btnAgendar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgendar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgendar.FillColor = System.Drawing.Color.White;
            this.btnAgendar.FocusedColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgendar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgendar.ForeColor = System.Drawing.Color.White;
            this.btnAgendar.HoverState.FillColor = System.Drawing.SystemColors.Window;
            this.btnAgendar.HoverState.Image = global::Batchup.Properties.Resources.hover_agenda;
            this.btnAgendar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgendar.Image")));
            this.btnAgendar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgendar.ImageSize = new System.Drawing.Size(80, 80);
            this.btnAgendar.IndicateFocus = true;
            this.btnAgendar.Location = new System.Drawing.Point(22, 142);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAgendar.PressedDepth = 50;
            this.btnAgendar.ShadowDecoration.BorderRadius = 30;
            this.btnAgendar.ShadowDecoration.Depth = 10;
            this.btnAgendar.ShadowDecoration.Enabled = true;
            this.btnAgendar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnAgendar.Size = new System.Drawing.Size(486, 80);
            this.btnAgendar.TabIndex = 3;
            this.btnAgendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgendar.UseTransparentBackground = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            this.btnAgendar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAgendar_Paint);
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.lblNome);
            this.pnlRodape.Location = new System.Drawing.Point(12, 564);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(528, 43);
            this.pnlRodape.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = false;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(0, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(528, 43);
            this.lblNome.TabIndex = 0;
            this.lblNome.TabStop = false;
            this.lblNome.Text = resources.GetString("lblNome.Text");
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.Controls.Add(this.btnMinimizar);
            this.guna2ContainerControl1.Controls.Add(this.btnFechar);
            this.guna2ContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(552, 49);
            this.guna2ContainerControl1.TabIndex = 3;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Animated = true;
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizar.FillColor = System.Drawing.Color.White;
            this.btnMinimizar.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.HoverState.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btnMinimizar.IconColor = System.Drawing.Color.Silver;
            this.btnMinimizar.Location = new System.Drawing.Point(441, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(55, 50);
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.UseTransparentBackground = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.btnFechar.FillColor = System.Drawing.Color.White;
            this.btnFechar.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnFechar.HoverState.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btnFechar.IconColor = System.Drawing.Color.Silver;
            this.btnFechar.Location = new System.Drawing.Point(496, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(55, 50);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TabStop = false;
            this.btnFechar.UseTransparentBackground = true;
            // 
            // dragPrincipal
            // 
            this.dragPrincipal.DockIndicatorTransparencyValue = 0.6D;
            this.dragPrincipal.TargetControl = this.guna2ContainerControl1;
            this.dragPrincipal.UseTransparentDrag = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(552, 619);
            this.ControlBox = false;
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlButoes);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batchup";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoTitle)).EndInit();
            this.pnlButoes.ResumeLayout(false);
            this.pnlRodape.ResumeLayout(false);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlButoes;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox icoTitle;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnAgendar;
        private Guna.UI2.WinForms.Guna2Button btnCriar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNome;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizar;
        private Guna.UI2.WinForms.Guna2ControlBox btnFechar;
        private Guna.UI2.WinForms.Guna2DragControl dragPrincipal;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}