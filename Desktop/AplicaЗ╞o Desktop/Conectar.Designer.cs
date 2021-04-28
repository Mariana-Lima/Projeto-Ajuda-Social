namespace Aplicação
{
    partial class frmConectar
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vOLTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuario = new System.Windows.Forms.MaskedTextBox();
            this.btnConectarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vOLTARToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 26);
            // 
            // vOLTARToolStripMenuItem
            // 
            this.vOLTARToolStripMenuItem.Name = "vOLTARToolStripMenuItem";
            this.vOLTARToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.vOLTARToolStripMenuItem.Text = "VOLTAR";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(57, 25);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(0, 543);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(584, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Todos os Direitos Reservados 2020";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblLoginUsuario.Location = new System.Drawing.Point(111, 310);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(77, 26);
            this.lblLoginUsuario.TabIndex = 3;
            this.lblLoginUsuario.Text = "Login:";
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblSenhaUsuario.Location = new System.Drawing.Point(103, 359);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(87, 26);
            this.lblSenhaUsuario.TabIndex = 4;
            this.lblSenhaUsuario.Text = "Senha:";
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Location = new System.Drawing.Point(194, 316);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(288, 20);
            this.txtLoginUsuario.TabIndex = 5;
            this.txtLoginUsuario.TextChanged += new System.EventHandler(this.txtLoginUsuario_TextChanged);
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Location = new System.Drawing.Point(196, 365);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.PasswordChar = '*';
            this.txtSenhaUsuario.Size = new System.Drawing.Size(286, 20);
            this.txtSenhaUsuario.TabIndex = 6;
            this.txtSenhaUsuario.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtSenhaUsuario_MaskInputRejected);
            // 
            // btnConectarUsuario
            // 
            this.btnConectarUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConectarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectarUsuario.Location = new System.Drawing.Point(244, 444);
            this.btnConectarUsuario.Name = "btnConectarUsuario";
            this.btnConectarUsuario.Size = new System.Drawing.Size(134, 41);
            this.btnConectarUsuario.TabIndex = 7;
            this.btnConectarUsuario.Text = "CONECTAR";
            this.btnConectarUsuario.UseVisualStyleBackColor = false;
            this.btnConectarUsuario.Click += new System.EventHandler(this.btnConectarUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(74, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "CONECTAR-SE NO SISTEMA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aplicação.Properties.Resources.login__3_;
            this.pictureBox2.Location = new System.Drawing.Point(364, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 130);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Aplicação.Properties.Resources.LOGOA;
            this.pictureBox3.Location = new System.Drawing.Point(81, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // frmConectar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConectarUsuario);
            this.Controls.Add(this.txtSenhaUsuario);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.lblSenhaUsuario);
            this.Controls.Add(this.lblLoginUsuario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConectar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CONECTAR";
            this.Load += new System.EventHandler(this.frmConectar_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckConectar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblConectar;
        private System.Windows.Forms.MenuStrip voltar;
        private System.Windows.Forms.ToolStripMenuItem txtvoltar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vOLTARToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.Label lblSenhaUsuario;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.MaskedTextBox txtSenhaUsuario;
        private System.Windows.Forms.Button btnConectarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}