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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.brdAgendar = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnFechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlNav = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlView = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lblAgendados = new System.Windows.Forms.Label();
            this.grdAgendados = new Guna.UI2.WinForms.Guna2DataGridView();
            this.timePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.grdArquivos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblArquivos = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picTitle = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSubAgendar = new System.Windows.Forms.Label();
            this.elipseGrid1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseGrid2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnVoltar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAvancar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ContainerControl1.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.pnlView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgendados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArquivos)).BeginInit();
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
            this.btnFechar.HoverState.FillColor = System.Drawing.Color.IndianRed;
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
            // pnlView
            // 
            this.pnlView.Controls.Add(this.lblSubAgendar);
            this.pnlView.Controls.Add(this.btnAdd);
            this.pnlView.Controls.Add(this.lblAgendados);
            this.pnlView.Controls.Add(this.grdAgendados);
            this.pnlView.Controls.Add(this.timePicker1);
            this.pnlView.Controls.Add(this.lblDataHora);
            this.pnlView.Controls.Add(this.grdArquivos);
            this.pnlView.Controls.Add(this.lblArquivos);
            this.pnlView.Location = new System.Drawing.Point(12, 132);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(528, 411);
            this.pnlView.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnAdd.BorderRadius = 8;
            this.btnAdd.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
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
            // grdAgendados
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.grdAgendados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAgendados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.grdAgendados.ColumnHeadersHeight = 4;
            this.grdAgendados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAgendados.DefaultCellStyle = dataGridViewCellStyle15;
            this.grdAgendados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdAgendados.Location = new System.Drawing.Point(18, 292);
            this.grdAgendados.Name = "grdAgendados";
            this.grdAgendados.RowHeadersVisible = false;
            this.grdAgendados.RowHeadersWidth = 51;
            this.grdAgendados.RowTemplate.Height = 24;
            this.grdAgendados.Size = new System.Drawing.Size(492, 108);
            this.grdAgendados.TabIndex = 5;
            this.grdAgendados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdAgendados.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdAgendados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdAgendados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdAgendados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdAgendados.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdAgendados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdAgendados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdAgendados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdAgendados.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdAgendados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdAgendados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdAgendados.ThemeStyle.HeaderStyle.Height = 4;
            this.grdAgendados.ThemeStyle.ReadOnly = false;
            this.grdAgendados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdAgendados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdAgendados.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdAgendados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdAgendados.ThemeStyle.RowsStyle.Height = 24;
            this.grdAgendados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdAgendados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // timePicker1
            // 
            this.timePicker1.BackColor = System.Drawing.Color.Transparent;
            this.timePicker1.BorderRadius = 8;
            this.timePicker1.Checked = true;
            this.timePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.timePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker1.IndicateFocus = true;
            this.timePicker1.Location = new System.Drawing.Point(17, 190);
            this.timePicker1.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.timePicker1.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.timePicker1.Name = "timePicker1";
            this.timePicker1.ShowUpDown = true;
            this.timePicker1.Size = new System.Drawing.Size(426, 44);
            this.timePicker1.TabIndex = 4;
            this.timePicker1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timePicker1.UseTransparentBackground = true;
            this.timePicker1.Value = new System.DateTime(2025, 10, 31, 18, 0, 0, 0);
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
            // grdArquivos
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.grdArquivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdArquivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.grdArquivos.ColumnHeadersHeight = 4;
            this.grdArquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdArquivos.DefaultCellStyle = dataGridViewCellStyle18;
            this.grdArquivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdArquivos.Location = new System.Drawing.Point(18, 38);
            this.grdArquivos.Name = "grdArquivos";
            this.grdArquivos.RowHeadersVisible = false;
            this.grdArquivos.RowHeadersWidth = 51;
            this.grdArquivos.RowTemplate.Height = 24;
            this.grdArquivos.Size = new System.Drawing.Size(492, 108);
            this.grdArquivos.TabIndex = 1;
            this.grdArquivos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdArquivos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdArquivos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdArquivos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdArquivos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdArquivos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdArquivos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdArquivos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdArquivos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdArquivos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdArquivos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdArquivos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdArquivos.ThemeStyle.HeaderStyle.Height = 4;
            this.grdArquivos.ThemeStyle.ReadOnly = false;
            this.grdArquivos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdArquivos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdArquivos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdArquivos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdArquivos.ThemeStyle.RowsStyle.Height = 24;
            this.grdArquivos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdArquivos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // elipseGrid1
            // 
            this.elipseGrid1.BorderRadius = 8;
            this.elipseGrid1.TargetControl = this.grdArquivos;
            // 
            // elipseGrid2
            // 
            this.elipseGrid2.BorderRadius = 8;
            this.elipseGrid2.TargetControl = this.grdAgendados;
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
            this.btnAvancar.Text = "Avançar  ⮞";
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
            ((System.ComponentModel.ISupportInitialize)(this.grdAgendados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArquivos)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView grdArquivos;
        private System.Windows.Forms.Label lblArquivos;
        private Guna.UI2.WinForms.Guna2Panel pnlNav;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler2;
        private Guna.UI2.WinForms.Guna2DateTimePicker timePicker1;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label lblAgendados;
        private Guna.UI2.WinForms.Guna2DataGridView grdAgendados;
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
    }
}