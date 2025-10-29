namespace Batchup.Presentation.Views
{
    partial class FrmConexao
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDir = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnCarregar = new Guna.UI2.WinForms.Guna2Button();
            this.lblDbMysql = new System.Windows.Forms.Label();
            this.txtDiretorio = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAvancar = new Guna.UI2.WinForms.Guna2Button();
            this.lblServidor = new System.Windows.Forms.Label();
            this.lblPorta = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.btnTestar = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBanco = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPorta = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtServidor = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnFechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.lblSubTitle);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 70);
            this.panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Batchup.Properties.Resources.conexao;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(60, 36);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(139, 20);
            this.lblSubTitle.TabIndex = 0;
            this.lblSubTitle.Text = "Configurar conexão";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(56, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(107, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Conexão";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDir);
            this.panel3.Controls.Add(this.btnCarregar);
            this.panel3.Controls.Add(this.lblDbMysql);
            this.panel3.Controls.Add(this.txtDiretorio);
            this.panel3.Location = new System.Drawing.Point(12, 398);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 150);
            this.panel3.TabIndex = 0;
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
            this.btnDir.Location = new System.Drawing.Point(464, 39);
            this.btnDir.Name = "btnDir";
            this.btnDir.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnDir.Size = new System.Drawing.Size(34, 34);
            this.btnDir.TabIndex = 8;
            this.btnDir.UseTransparentBackground = true;
            // 
            // btnCarregar
            // 
            this.btnCarregar.BorderRadius = 5;
            this.btnCarregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCarregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCarregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCarregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCarregar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.ForeColor = System.Drawing.Color.White;
            this.btnCarregar.Location = new System.Drawing.Point(18, 79);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(491, 47);
            this.btnCarregar.TabIndex = 9;
            this.btnCarregar.Text = "Carregar";
            // 
            // lblDbMysql
            // 
            this.lblDbMysql.AutoSize = true;
            this.lblDbMysql.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDbMysql.Location = new System.Drawing.Point(23, 14);
            this.lblDbMysql.Name = "lblDbMysql";
            this.lblDbMysql.Size = new System.Drawing.Size(78, 23);
            this.lblDbMysql.TabIndex = 0;
            this.lblDbMysql.Text = "DbMysql";
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.AcceptsReturn = true;
            this.txtDiretorio.AcceptsTab = true;
            this.txtDiretorio.AutoCompleteCustomSource.AddRange(new string[] {
            "C:\\Checkout_ON\\DbMysqlEst.ini",
            "C:\\Checkout_ON\\DbMysql.ini",
            "C:\\Total Control\\Total_On\\DbMysql.ini"});
            this.txtDiretorio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDiretorio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDiretorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDiretorio.BorderColor = System.Drawing.Color.Gray;
            this.txtDiretorio.BorderRadius = 5;
            this.txtDiretorio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiretorio.DefaultText = "";
            this.txtDiretorio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiretorio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiretorio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiretorio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiretorio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiretorio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiretorio.ForeColor = System.Drawing.Color.Black;
            this.txtDiretorio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiretorio.Location = new System.Drawing.Point(18, 37);
            this.txtDiretorio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtDiretorio.PlaceholderText = "C:\\Checkout_ON\\DbMysqlEst.ini";
            this.txtDiretorio.SelectedText = "";
            this.txtDiretorio.Size = new System.Drawing.Size(491, 35);
            this.txtDiretorio.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnVoltar);
            this.panel4.Controls.Add(this.btnAvancar);
            this.panel4.Location = new System.Drawing.Point(12, 554);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(528, 53);
            this.panel4.TabIndex = 0;
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
            this.btnVoltar.TabIndex = 10;
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
            this.btnAvancar.TabIndex = 11;
            this.btnAvancar.Text = "Avançar  ⮞";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServidor.Location = new System.Drawing.Point(22, 15);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(74, 23);
            this.lblServidor.TabIndex = 0;
            this.lblServidor.Text = "Servidor";
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPorta.Location = new System.Drawing.Point(272, 15);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(50, 23);
            this.lblPorta.TabIndex = 0;
            this.lblPorta.Text = "Porta";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(22, 80);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 23);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSenha.Location = new System.Drawing.Point(22, 145);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 23);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblBanco.Location = new System.Drawing.Point(23, 210);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(57, 23);
            this.lblBanco.TabIndex = 0;
            this.lblBanco.Text = "Banco";
            // 
            // btnTestar
            // 
            this.btnTestar.BorderRadius = 5;
            this.btnTestar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTestar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTestar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTestar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTestar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnTestar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestar.ForeColor = System.Drawing.Color.White;
            this.btnTestar.Location = new System.Drawing.Point(310, 233);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(199, 35);
            this.btnTestar.TabIndex = 6;
            this.btnTestar.Text = "✔  Testar Conexão";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTestar);
            this.panel2.Controls.Add(this.txtBanco);
            this.panel2.Controls.Add(this.txtSenha);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.txtPorta);
            this.panel2.Controls.Add(this.txtServidor);
            this.panel2.Controls.Add(this.lblBanco);
            this.panel2.Controls.Add(this.lblSenha);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.lblPorta);
            this.panel2.Controls.Add(this.lblServidor);
            this.panel2.Location = new System.Drawing.Point(12, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 275);
            this.panel2.TabIndex = 0;
            // 
            // txtBanco
            // 
            this.txtBanco.AcceptsTab = true;
            this.txtBanco.AutoCompleteCustomSource.AddRange(new string[] {
            "pdvserver",
            "tota_"});
            this.txtBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBanco.BorderColor = System.Drawing.Color.Gray;
            this.txtBanco.BorderRadius = 5;
            this.txtBanco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBanco.DefaultText = "";
            this.txtBanco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBanco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBanco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBanco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBanco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBanco.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBanco.ForeColor = System.Drawing.Color.Black;
            this.txtBanco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBanco.Location = new System.Drawing.Point(18, 233);
            this.txtBanco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtBanco.PlaceholderText = "pdvserver";
            this.txtBanco.SelectedText = "";
            this.txtBanco.Size = new System.Drawing.Size(286, 35);
            this.txtBanco.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.AcceptsTab = true;
            this.txtSenha.AutoCompleteCustomSource.AddRange(new string[] {
            "123456",
            "T0t4l@804",
            "Tot@l"});
            this.txtSenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSenha.BorderColor = System.Drawing.Color.Gray;
            this.txtSenha.BorderRadius = 5;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.DefaultText = "";
            this.txtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.Location = new System.Drawing.Point(18, 168);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSenha.PlaceholderText = "";
            this.txtSenha.SelectedText = "";
            this.txtSenha.Size = new System.Drawing.Size(491, 35);
            this.txtSenha.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AcceptsTab = true;
            this.txtUsuario.AutoCompleteCustomSource.AddRange(new string[] {
            "root",
            "tota_"});
            this.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUsuario.BorderColor = System.Drawing.Color.Gray;
            this.txtUsuario.BorderRadius = 5;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.Location = new System.Drawing.Point(18, 103);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.PlaceholderText = "root";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(491, 35);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtPorta
            // 
            this.txtPorta.AcceptsReturn = true;
            this.txtPorta.AcceptsTab = true;
            this.txtPorta.AutoCompleteCustomSource.AddRange(new string[] {
            "3306"});
            this.txtPorta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPorta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPorta.BorderColor = System.Drawing.Color.Gray;
            this.txtPorta.BorderRadius = 5;
            this.txtPorta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPorta.DefaultText = "";
            this.txtPorta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPorta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPorta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPorta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPorta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPorta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPorta.ForeColor = System.Drawing.Color.Black;
            this.txtPorta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPorta.Location = new System.Drawing.Point(266, 38);
            this.txtPorta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPorta.PlaceholderText = "3306";
            this.txtPorta.SelectedText = "";
            this.txtPorta.Size = new System.Drawing.Size(243, 35);
            this.txtPorta.TabIndex = 2;
            // 
            // txtServidor
            // 
            this.txtServidor.AcceptsTab = true;
            this.txtServidor.Animated = true;
            this.txtServidor.AutoCompleteCustomSource.AddRange(new string[] {
            "localhost",
            "145.223.31.141"});
            this.txtServidor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtServidor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtServidor.BorderColor = System.Drawing.Color.Gray;
            this.txtServidor.BorderRadius = 5;
            this.txtServidor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServidor.DefaultText = "";
            this.txtServidor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServidor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServidor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServidor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServidor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServidor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServidor.ForeColor = System.Drawing.Color.Black;
            this.txtServidor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServidor.Location = new System.Drawing.Point(18, 38);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtServidor.PlaceholderText = "localhost";
            this.txtServidor.SelectedText = "";
            this.txtServidor.Size = new System.Drawing.Size(243, 35);
            this.txtServidor.TabIndex = 1;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.Controls.Add(this.btnMinimizar);
            this.guna2ContainerControl1.Controls.Add(this.btnFechar);
            this.guna2ContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(552, 49);
            this.guna2ContainerControl1.TabIndex = 1;
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
            this.btnFechar.CustomClick = true;
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
//            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
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
            // FrmConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(552, 619);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmConexao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batchup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtDiretorio;
        private System.Windows.Forms.Label lblDbMysql;
        private Guna.UI2.WinForms.Guna2Button btnCarregar;
        private Guna.UI2.WinForms.Guna2Button btnAvancar;
        private Guna.UI2.WinForms.Guna2Button btnVoltar;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblBanco;
        private Guna.UI2.WinForms.Guna2Button btnTestar;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtBanco;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtPorta;
        private Guna.UI2.WinForms.Guna2TextBox txtServidor;
        private Guna.UI2.WinForms.Guna2ImageButton btnDir;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizar;
        private Guna.UI2.WinForms.Guna2ControlBox btnFechar;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}