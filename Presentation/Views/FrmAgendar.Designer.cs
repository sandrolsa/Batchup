using System.Runtime.Remoting.Activation;

namespace Batchup.Presentation.Views
{
    partial class FrmAgendar
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
            this.brdAgendar = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnFechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlNav = new Guna.UI2.WinForms.Guna2Panel();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAvancar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlView = new Guna.UI2.WinForms.Guna2Panel();
            this.listDisponiveis = new System.Windows.Forms.ListView();
            this.icons = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listAgendados = new System.Windows.Forms.ListBox();
            this.lblSubAgendar = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lblAgendados = new System.Windows.Forms.Label();
            this.timePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.lblArquivos = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.picTitle = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.elipseGrid1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseGrid2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ContainerControl1.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // brdAgendar
            // 
            this.brdAgendar.AnimateWindow = true;
            this.brdAgendar.AnimationInterval = 100;
            this.brdAgendar.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.brdAgendar.BorderRadius = 20;
            this.brdAgendar.ContainerControl = this;
            this.brdAgendar.DockForm = false;
            this.brdAgendar.DockIndicatorTransparencyValue = 0.6D;
            this.brdAgendar.ResizeForm = false;
            this.brdAgendar.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockForm = true;
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2ContainerControl1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.Controls.Add(this.btnMinimizar);
            this.guna2ContainerControl1.Controls.Add(this.btnFechar);
            this.guna2ContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(552, 49);
            this.guna2ContainerControl1.TabIndex = 0;
            this.guna2ContainerControl1.Text = "titleBar";
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
            // pnlNav
            // 
            this.pnlNav.Controls.Add(this.btnVoltar);
            this.pnlNav.Controls.Add(this.btnAvancar);
            this.pnlNav.Location = new System.Drawing.Point(12, 549);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(528, 53);
            this.pnlNav.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BorderRadius = 5;
            this.btnVoltar.BorderThickness = 1;
            this.btnVoltar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoltar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(3, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(249, 47);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "⮜  Voltar";
            // 
            // btnAvancar
            // 
            this.btnAvancar.BorderRadius = 5;
            this.btnAvancar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAvancar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAvancar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAvancar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAvancar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnAvancar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancar.ForeColor = System.Drawing.Color.White;
            this.btnAvancar.Location = new System.Drawing.Point(276, 3);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(249, 47);
            this.btnAvancar.TabIndex = 13;
            this.btnAvancar.Text = "Concluir ";
            // 
            // pnlView
            // 
            this.pnlView.Controls.Add(this.listDisponiveis);
            this.pnlView.Controls.Add(this.listAgendados);
            this.pnlView.Controls.Add(this.lblSubAgendar);
            this.pnlView.Controls.Add(this.btnAdd);
            this.pnlView.Controls.Add(this.lblAgendados);
            this.pnlView.Controls.Add(this.timePicker);
            this.pnlView.Controls.Add(this.lblDataHora);
            this.pnlView.Controls.Add(this.lblArquivos);
            this.pnlView.Location = new System.Drawing.Point(12, 132);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(528, 411);
            this.pnlView.TabIndex = 4;
            // 
            // listDisponiveis
            // 
            this.listDisponiveis.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listDisponiveis.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listDisponiveis.AutoArrange = false;
            this.listDisponiveis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDisponiveis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.icons});
            this.listDisponiveis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDisponiveis.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listDisponiveis.HideSelection = false;
            this.listDisponiveis.Location = new System.Drawing.Point(17, 31);
            this.listDisponiveis.MultiSelect = false;
            this.listDisponiveis.Name = "listDisponiveis";
            this.listDisponiveis.ShowGroups = false;
            this.listDisponiveis.Size = new System.Drawing.Size(489, 112);
            this.listDisponiveis.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listDisponiveis.TabIndex = 10;
            this.listDisponiveis.UseCompatibleStateImageBehavior = false;
            this.listDisponiveis.View = System.Windows.Forms.View.Details;
            // 
            // icons
            // 
            this.icons.Text = "";
            this.icons.Width = 300;
            // 
            // listAgendados
            // 
            this.listAgendados.FormattingEnabled = true;
            this.listAgendados.ItemHeight = 16;
            this.listAgendados.Location = new System.Drawing.Point(17, 284);
            this.listAgendados.Name = "listAgendados";
            this.listAgendados.Size = new System.Drawing.Size(489, 116);
            this.listAgendados.TabIndex = 9;
            // 
            // lblSubAgendar
            // 
            this.lblSubAgendar.AutoSize = true;
            this.lblSubAgendar.BackColor = System.Drawing.Color.Transparent;
            this.lblSubAgendar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubAgendar.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubAgendar.Location = new System.Drawing.Point(17, 234);
            this.lblSubAgendar.Name = "lblSubAgendar";
            this.lblSubAgendar.Size = new System.Drawing.Size(151, 20);
            this.lblSubAgendar.TabIndex = 8;
            this.lblSubAgendar.Text = "Máximo de 4 por dia.";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnAdd.BorderRadius = 8;
            this.btnAdd.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Enabled = false;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(456, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 44);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "+";
            this.btnAdd.TextFormatNoPrefix = true;
            // 
            // lblAgendados
            // 
            this.lblAgendados.AutoSize = true;
            this.lblAgendados.BackColor = System.Drawing.Color.Transparent;
            this.lblAgendados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAgendados.Location = new System.Drawing.Point(17, 264);
            this.lblAgendados.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.lblAgendados.Name = "lblAgendados";
            this.lblAgendados.Size = new System.Drawing.Size(150, 20);
            this.lblAgendados.TabIndex = 6;
            this.lblAgendados.Text = "Backups Agendados";
            // 
            // timePicker
            // 
            this.timePicker.BackColor = System.Drawing.Color.Transparent;
            this.timePicker.BorderRadius = 8;
            this.timePicker.Checked = true;
            this.timePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.IndicateFocus = true;
            this.timePicker.Location = new System.Drawing.Point(17, 190);
            this.timePicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.timePicker.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(426, 44);
            this.timePicker.TabIndex = 4;
            this.timePicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timePicker.UseTransparentBackground = true;
            this.timePicker.Value = new System.DateTime(2025, 10, 31, 18, 0, 0, 0);
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.BackColor = System.Drawing.Color.Transparent;
            this.lblDataHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDataHora.Location = new System.Drawing.Point(17, 162);
            this.lblDataHora.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(192, 20);
            this.lblDataHora.TabIndex = 2;
            this.lblDataHora.Text = "Data e hora para o backup";
            // 
            // lblArquivos
            // 
            this.lblArquivos.AutoSize = true;
            this.lblArquivos.BackColor = System.Drawing.Color.Transparent;
            this.lblArquivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblArquivos.Location = new System.Drawing.Point(17, 10);
            this.lblArquivos.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.lblArquivos.Name = "lblArquivos";
            this.lblArquivos.Size = new System.Drawing.Size(154, 20);
            this.lblArquivos.TabIndex = 0;
            this.lblArquivos.Text = "Arquivos disponíveis";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.picTitle);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.lblSubTitle);
            this.pnlTitle.Location = new System.Drawing.Point(12, 56);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(528, 70);
            this.pnlTitle.TabIndex = 8;
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.FillColor = System.Drawing.Color.Transparent;
            this.picTitle.Image = global::Batchup.Properties.Resources.calendario;
            this.picTitle.ImageRotate = 0F;
            this.picTitle.Location = new System.Drawing.Point(3, 3);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(64, 64);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitle.TabIndex = 2;
            this.picTitle.TabStop = false;
            this.picTitle.UseTransparentBackground = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(56, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(105, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Agendar";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(60, 36);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(118, 20);
            this.lblSubTitle.TabIndex = 0;
            this.lblSubTitle.Text = "Agendar backup";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // elipseGrid1
            // 
            this.elipseGrid1.BorderRadius = 8;
            this.elipseGrid1.TargetControl = this.listDisponiveis;
            // 
            // elipseGrid2
            // 
            this.elipseGrid2.BorderRadius = 8;
            // 
            // FrmAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(552, 619);
            this.ControlBox = false;
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.guna2ContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAgendar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgendar";
            this.guna2ContainerControl1.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.pnlView.ResumeLayout(false);
            this.pnlView.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm brdAgendar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizar;
        private Guna.UI2.WinForms.Guna2ControlBox btnFechar;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Guna.UI2.WinForms.Guna2Panel pnlView;
        private System.Windows.Forms.Label lblArquivos;
        private Guna.UI2.WinForms.Guna2Panel pnlNav;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler2;
        private Guna.UI2.WinForms.Guna2DateTimePicker timePicker;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label lblAgendados;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2PictureBox picTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubAgendar;
        private Guna.UI2.WinForms.Guna2Elipse elipseGrid1;
        private Guna.UI2.WinForms.Guna2Elipse elipseGrid2;
        private Guna.UI2.WinForms.Guna2Button btnVoltar;
        private Guna.UI2.WinForms.Guna2Button btnAvancar;
        private System.Windows.Forms.ListBox listAgendados;
        private System.Windows.Forms.ListView listDisponiveis;
        private System.Windows.Forms.ColumnHeader colImagem;
        private System.Windows.Forms.ColumnHeader colArquivo;
        private System.Windows.Forms.ColumnHeader icons;
    }
}