namespace Batchup.Interface
{
    partial class FrmBackup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.subCopia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subCaixa = new System.Windows.Forms.Label();
            this.subEmpresa = new System.Windows.Forms.Label();
            this.subDir = new System.Windows.Forms.Label();
            this.txtDias = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtCaixa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.txtEmpresa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDirCopia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblDirCopia = new System.Windows.Forms.Label();
            this.txtDirBackup = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiretorio = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2Button();
            this.btnDirCopia = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnDir = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.lblSubTitle);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 69);
            this.panel1.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(60, 39);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(206, 20);
            this.lblSubTitle.TabIndex = 0;
            this.lblSubTitle.Text = "Configurações do arquivo bat";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(57, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Config Backup";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDirCopia);
            this.panel2.Controls.Add(this.btnDir);
            this.panel2.Controls.Add(this.subCopia);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.subCaixa);
            this.panel2.Controls.Add(this.subEmpresa);
            this.panel2.Controls.Add(this.subDir);
            this.panel2.Controls.Add(this.txtDias);
            this.panel2.Controls.Add(this.lblDias);
            this.panel2.Controls.Add(this.txtCaixa);
            this.panel2.Controls.Add(this.lblCaixa);
            this.panel2.Controls.Add(this.txtEmpresa);
            this.panel2.Controls.Add(this.txtDirCopia);
            this.panel2.Controls.Add(this.lblEmpresa);
            this.panel2.Controls.Add(this.lblDirCopia);
            this.panel2.Controls.Add(this.txtDirBackup);
            this.panel2.Controls.Add(this.lblDiretorio);
            this.panel2.Location = new System.Drawing.Point(12, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 415);
            this.panel2.TabIndex = 0;
            // 
            // subCopia
            // 
            this.subCopia.AutoSize = true;
            this.subCopia.BackColor = System.Drawing.Color.Transparent;
            this.subCopia.ForeColor = System.Drawing.Color.Black;
            this.subCopia.Location = new System.Drawing.Point(20, 382);
            this.subCopia.Name = "subCopia";
            this.subCopia.Size = new System.Drawing.Size(193, 16);
            this.subCopia.TabIndex = 0;
            this.subCopia.Text = "Diretorio para copia do backup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Exclui backups anteriores a X dias";
            // 
            // subCaixa
            // 
            this.subCaixa.AutoSize = true;
            this.subCaixa.BackColor = System.Drawing.Color.Transparent;
            this.subCaixa.ForeColor = System.Drawing.Color.Black;
            this.subCaixa.Location = new System.Drawing.Point(268, 169);
            this.subCaixa.Name = "subCaixa";
            this.subCaixa.Size = new System.Drawing.Size(109, 16);
            this.subCaixa.TabIndex = 0;
            this.subCaixa.Text = "Número do caixa";
            // 
            // subEmpresa
            // 
            this.subEmpresa.AutoSize = true;
            this.subEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.subEmpresa.ForeColor = System.Drawing.Color.Black;
            this.subEmpresa.Location = new System.Drawing.Point(20, 169);
            this.subEmpresa.Name = "subEmpresa";
            this.subEmpresa.Size = new System.Drawing.Size(198, 16);
            this.subEmpresa.TabIndex = 0;
            this.subEmpresa.Text = "Nome da empresa e do arquivo";
            // 
            // subDir
            // 
            this.subDir.AutoSize = true;
            this.subDir.BackColor = System.Drawing.Color.Transparent;
            this.subDir.ForeColor = System.Drawing.Color.Black;
            this.subDir.Location = new System.Drawing.Point(20, 73);
            this.subDir.Name = "subDir";
            this.subDir.Size = new System.Drawing.Size(183, 16);
            this.subDir.TabIndex = 0;
            this.subDir.Text = "Caminho do arquivo de dump";
            // 
            // txtDias
            // 
            this.txtDias.AcceptsReturn = true;
            this.txtDias.AcceptsTab = true;
            this.txtDias.AutoCompleteCustomSource.AddRange(new string[] {
            "7",
            "14",
            "30",
            "60",
            "90"});
            this.txtDias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDias.BorderColor = System.Drawing.Color.Gray;
            this.txtDias.BorderRadius = 5;
            this.txtDias.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDias.DefaultText = "";
            this.txtDias.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDias.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDias.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDias.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDias.ForeColor = System.Drawing.Color.Black;
            this.txtDias.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDias.Location = new System.Drawing.Point(18, 225);
            this.txtDias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDias.Name = "txtDias";
            this.txtDias.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtDias.PlaceholderText = "7";
            this.txtDias.SelectedText = "";
            this.txtDias.Size = new System.Drawing.Size(234, 35);
            this.txtDias.TabIndex = 5;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDias.Location = new System.Drawing.Point(22, 198);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(42, 23);
            this.lblDias.TabIndex = 0;
            this.lblDias.Text = "Dias";
            // 
            // txtCaixa
            // 
            this.txtCaixa.AcceptsReturn = true;
            this.txtCaixa.AcceptsTab = true;
            this.txtCaixa.AutoCompleteCustomSource.AddRange(new string[] {
            "01",
            "02",
            "05",
            "99"});
            this.txtCaixa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCaixa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCaixa.BorderColor = System.Drawing.Color.Gray;
            this.txtCaixa.BorderRadius = 5;
            this.txtCaixa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCaixa.DefaultText = "";
            this.txtCaixa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCaixa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCaixa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCaixa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCaixa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCaixa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCaixa.ForeColor = System.Drawing.Color.Black;
            this.txtCaixa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCaixa.Location = new System.Drawing.Point(266, 132);
            this.txtCaixa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCaixa.Name = "txtCaixa";
            this.txtCaixa.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtCaixa.PlaceholderText = "99";
            this.txtCaixa.SelectedText = "";
            this.txtCaixa.Size = new System.Drawing.Size(243, 35);
            this.txtCaixa.TabIndex = 4;
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCaixa.Location = new System.Drawing.Point(269, 105);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(52, 23);
            this.lblCaixa.TabIndex = 0;
            this.lblCaixa.Text = "Caixa";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.AcceptsReturn = true;
            this.txtEmpresa.AcceptsTab = true;
            this.txtEmpresa.AutoCompleteCustomSource.AddRange(new string[] {
            "Matriz"});
            this.txtEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmpresa.BorderColor = System.Drawing.Color.Gray;
            this.txtEmpresa.BorderRadius = 5;
            this.txtEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpresa.DefaultText = "";
            this.txtEmpresa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmpresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmpresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmpresa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmpresa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmpresa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmpresa.ForeColor = System.Drawing.Color.Black;
            this.txtEmpresa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmpresa.Location = new System.Drawing.Point(18, 132);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtEmpresa.PlaceholderText = "Matriz";
            this.txtEmpresa.SelectedText = "";
            this.txtEmpresa.Size = new System.Drawing.Size(234, 35);
            this.txtEmpresa.TabIndex = 3;
            // 
            // txtDirCopia
            // 
            this.txtDirCopia.AcceptsReturn = true;
            this.txtDirCopia.AcceptsTab = true;
            this.txtDirCopia.AutoCompleteCustomSource.AddRange(new string[] {
            "D:\\Backup\\Copia\\",
            "\\\\localhost\\DATABASE\\Backup\\Copia\\",
            "\\\\Servidor\\DATABASE\\Backup\\Copia\\",
            "\\\\Caixa-01\\DATABASE\\Backup\\Copia\\"});
            this.txtDirCopia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDirCopia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDirCopia.BorderColor = System.Drawing.Color.Gray;
            this.txtDirCopia.BorderRadius = 5;
            this.txtDirCopia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDirCopia.DefaultText = "";
            this.txtDirCopia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDirCopia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDirCopia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDirCopia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDirCopia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDirCopia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDirCopia.ForeColor = System.Drawing.Color.Black;
            this.txtDirCopia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDirCopia.Location = new System.Drawing.Point(18, 345);
            this.txtDirCopia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDirCopia.Name = "txtDirCopia";
            this.txtDirCopia.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtDirCopia.PlaceholderText = "\\\\localhost\\Database\\Copia\\";
            this.txtDirCopia.SelectedText = "";
            this.txtDirCopia.Size = new System.Drawing.Size(491, 35);
            this.txtDirCopia.TabIndex = 6;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.Location = new System.Drawing.Point(21, 105);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(75, 23);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblDirCopia
            // 
            this.lblDirCopia.AutoSize = true;
            this.lblDirCopia.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDirCopia.Location = new System.Drawing.Point(22, 318);
            this.lblDirCopia.Name = "lblDirCopia";
            this.lblDirCopia.Size = new System.Drawing.Size(147, 23);
            this.lblDirCopia.TabIndex = 0;
            this.lblDirCopia.Text = "Diretório de cópia";
            // 
            // txtDirBackup
            // 
            this.txtDirBackup.AcceptsReturn = true;
            this.txtDirBackup.AcceptsTab = true;
            this.txtDirBackup.AutoCompleteCustomSource.AddRange(new string[] {
            "C:\\Database\\Backup\\On\\"});
            this.txtDirBackup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDirBackup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDirBackup.BorderColor = System.Drawing.Color.Gray;
            this.txtDirBackup.BorderRadius = 5;
            this.txtDirBackup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDirBackup.DefaultText = "";
            this.txtDirBackup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDirBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDirBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDirBackup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDirBackup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDirBackup.FocusedState.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtDirBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDirBackup.ForeColor = System.Drawing.Color.Black;
            this.txtDirBackup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDirBackup.Location = new System.Drawing.Point(18, 36);
            this.txtDirBackup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDirBackup.Name = "txtDirBackup";
            this.txtDirBackup.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtDirBackup.PlaceholderText = "C:\\Database\\Backup\\On\\";
            this.txtDirBackup.SelectedText = "";
            this.txtDirBackup.Size = new System.Drawing.Size(491, 35);
            this.txtDirBackup.TabIndex = 1;
            // 
            // lblDiretorio
            // 
            this.lblDiretorio.AutoSize = true;
            this.lblDiretorio.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiretorio.Location = new System.Drawing.Point(21, 9);
            this.lblDiretorio.Name = "lblDiretorio";
            this.lblDiretorio.Size = new System.Drawing.Size(77, 23);
            this.lblDiretorio.TabIndex = 0;
            this.lblDiretorio.Text = "Diretório";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnConcluir);
            this.panel4.Controls.Add(this.btnVoltar);
            this.panel4.Location = new System.Drawing.Point(12, 554);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(528, 53);
            this.panel4.TabIndex = 0;
            // 
            // btnConcluir
            // 
            this.btnConcluir.BorderRadius = 5;
            this.btnConcluir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConcluir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConcluir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConcluir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConcluir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.btnConcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.ForeColor = System.Drawing.Color.White;
            this.btnConcluir.Location = new System.Drawing.Point(276, 3);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(249, 47);
            this.btnConcluir.TabIndex = 9;
            this.btnConcluir.Text = "Concluir ";
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BorderRadius = 5;
            this.btnVoltar.BorderThickness = 1;
            this.btnVoltar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoltar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVoltar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnVoltar.FocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(3, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(249, 47);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "⮜  Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnDirCopia
            // 
            this.btnDirCopia.BackColor = System.Drawing.Color.Transparent;
            this.btnDirCopia.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDirCopia.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnDirCopia.Image = global::Batchup.Properties.Resources.pasta;
            this.btnDirCopia.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDirCopia.ImageRotate = 0F;
            this.btnDirCopia.ImageSize = new System.Drawing.Size(28, 28);
            this.btnDirCopia.Location = new System.Drawing.Point(465, 345);
            this.btnDirCopia.Name = "btnDirCopia";
            this.btnDirCopia.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnDirCopia.Size = new System.Drawing.Size(34, 34);
            this.btnDirCopia.TabIndex = 7;
            this.btnDirCopia.UseTransparentBackground = true;
            this.btnDirCopia.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // btnDir
            // 
            this.btnDir.BackColor = System.Drawing.Color.Transparent;
            this.btnDir.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDir.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnDir.Image = global::Batchup.Properties.Resources.pasta;
            this.btnDir.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDir.ImageRotate = 0F;
            this.btnDir.ImageSize = new System.Drawing.Size(28, 28);
            this.btnDir.Location = new System.Drawing.Point(465, 37);
            this.btnDir.Name = "btnDir";
            this.btnDir.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnDir.Size = new System.Drawing.Size(34, 34);
            this.btnDir.TabIndex = 2;
            this.btnDir.UseTransparentBackground = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Batchup.Properties.Resources.titulo_pasta;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.Controls.Add(this.guna2ControlBox2);
            this.guna2ContainerControl1.Controls.Add(this.guna2ControlBox1);
            this.guna2ContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(552, 49);
            this.guna2ContainerControl1.TabIndex = 1;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.SystemColors.ControlLight;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Silver;
            this.guna2ControlBox2.Location = new System.Drawing.Point(441, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(55, 50);
            this.guna2ControlBox2.TabIndex = 0;
            this.guna2ControlBox2.TabStop = false;
            this.guna2ControlBox2.UseTransparentBackground = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.SystemColors.ControlLight;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Silver;
            this.guna2ControlBox1.Location = new System.Drawing.Point(496, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(55, 50);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.TabStop = false;
            this.guna2ControlBox1.UseTransparentBackground = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2ContainerControl1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(552, 619);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmBackup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batchup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnConcluir;
        private Guna.UI2.WinForms.Guna2Button btnVoltar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtDirBackup;
        private System.Windows.Forms.Label lblDiretorio;
        private Guna.UI2.WinForms.Guna2TextBox txtEmpresa;
        private Guna.UI2.WinForms.Guna2TextBox txtDirCopia;
        private System.Windows.Forms.Label lblDirCopia;
        private Guna.UI2.WinForms.Guna2TextBox txtDias;
        private System.Windows.Forms.Label lblDias;
        private Guna.UI2.WinForms.Guna2TextBox txtCaixa;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label subCopia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label subCaixa;
        private System.Windows.Forms.Label subEmpresa;
        private System.Windows.Forms.Label subDir;
        private Guna.UI2.WinForms.Guna2ImageButton btnDirCopia;
        private Guna.UI2.WinForms.Guna2ImageButton btnDir;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}