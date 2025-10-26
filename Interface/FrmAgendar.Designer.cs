namespace Batchup.Interface
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ContainerControl1.SuspendLayout();
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
            this.guna2ContainerControl1.Controls.Add(this.guna2ControlBox2);
            this.guna2ContainerControl1.Controls.Add(this.guna2ControlBox1);
            this.guna2ContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(552, 49);
            this.guna2ContainerControl1.TabIndex = 0;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
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
            // FrmAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 619);
            this.ControlBox = false;
            this.Controls.Add(this.guna2ContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAgendar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgendar";
            this.guna2ContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm brdAgendar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}