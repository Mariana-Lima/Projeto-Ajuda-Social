namespace Aplicação
{
    partial class frmConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConta));
            this.lblConectar = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.MenuStrip();
            this.txtvoltar = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLogin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.voltar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConectar
            // 
            this.lblConectar.AutoSize = true;
            this.lblConectar.Font = new System.Drawing.Font("Microsoft Tai Le", 24.25F, System.Drawing.FontStyle.Bold);
            this.lblConectar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblConectar.Location = new System.Drawing.Point(107, 109);
            this.lblConectar.Name = "lblConectar";
            this.lblConectar.Size = new System.Drawing.Size(586, 43);
            this.lblConectar.TabIndex = 0;
            this.lblConectar.Text = "USUÁRIO CONECTADO NO SISTEMA";
            this.lblConectar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConectar.Click += new System.EventHandler(this.label1_Click);
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.Gray;
            this.voltar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.voltar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtvoltar});
            this.voltar.Location = new System.Drawing.Point(0, 0);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(784, 29);
            this.voltar.TabIndex = 1;
            this.voltar.Text = "menu";
            // 
            // txtvoltar
            // 
            this.txtvoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtvoltar.Name = "txtvoltar";
            this.txtvoltar.Size = new System.Drawing.Size(81, 25);
            this.txtvoltar.Text = "VOLTAR";
            this.txtvoltar.Click += new System.EventHandler(this.vOLTARToolStripMenuItem_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblLogin.Location = new System.Drawing.Point(293, 54);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(91, 25);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "LOGIN: ";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 541);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(784, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Todos os Direitos Reservados 2020";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblUsuario.Location = new System.Drawing.Point(360, 115);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(24, 25);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "- ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Location = new System.Drawing.Point(0, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 234);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblConectar);
            this.Controls.Add(this.voltar);
            this.MainMenuStrip = this.voltar;
            this.MaximizeBox = false;
            this.Name = "frmConta";
            this.Text = "Conta";
            this.Load += new System.EventHandler(this.frmConta_Load);
            this.voltar.ResumeLayout(false);
            this.voltar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConectar;
        private System.Windows.Forms.MenuStrip voltar;
        private System.Windows.Forms.ToolStripMenuItem txtvoltar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}