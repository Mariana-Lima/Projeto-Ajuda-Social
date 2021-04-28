namespace Aplicação
{
    partial class frmManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManual));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.MenuStrip();
            this.clcVoltar = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblConexao = new System.Windows.Forms.Label();
            this.lblAcesso = new System.Windows.Forms.Label();
            this.lblInfoCadastro = new System.Windows.Forms.Label();
            this.lblInfoAcesso = new System.Windows.Forms.Label();
            this.lblInfoConexao = new System.Windows.Forms.Label();
            this.voltar.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(-1, 541);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(783, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Todos os Direitos Reservados 2020";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(50, 62);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(256, 26);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "MANUAL DE ACESSO\r\n";
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.voltar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.voltar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clcVoltar});
            this.voltar.Location = new System.Drawing.Point(0, 0);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(784, 29);
            this.voltar.TabIndex = 5;
            this.voltar.Text = "menu";
            // 
            // clcVoltar
            // 
            this.clcVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.clcVoltar.Name = "clcVoltar";
            this.clcVoltar.Size = new System.Drawing.Size(81, 25);
            this.clcVoltar.Text = "VOLTAR";
            this.clcVoltar.Click += new System.EventHandler(this.vOLTARToolStripMenuItem_Click);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblCadastro.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCadastro.Location = new System.Drawing.Point(51, 137);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(145, 24);
            this.lblCadastro.TabIndex = 6;
            this.lblCadastro.Text = "1. CADASTRO";
            // 
            // lblConexao
            // 
            this.lblConexao.AutoSize = true;
            this.lblConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblConexao.ForeColor = System.Drawing.Color.White;
            this.lblConexao.Location = new System.Drawing.Point(51, 362);
            this.lblConexao.Name = "lblConexao";
            this.lblConexao.Size = new System.Drawing.Size(137, 24);
            this.lblConexao.TabIndex = 7;
            this.lblConexao.Text = "3. CONEXÃO";
            // 
            // lblAcesso
            // 
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblAcesso.ForeColor = System.Drawing.Color.White;
            this.lblAcesso.Location = new System.Drawing.Point(51, 245);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Size = new System.Drawing.Size(117, 24);
            this.lblAcesso.TabIndex = 8;
            this.lblAcesso.Text = "2. ACESSO";
            this.lblAcesso.Click += new System.EventHandler(this.lblAcesso_Click);
            // 
            // lblInfoCadastro
            // 
            this.lblInfoCadastro.AutoSize = true;
            this.lblInfoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInfoCadastro.Location = new System.Drawing.Point(51, 179);
            this.lblInfoCadastro.Name = "lblInfoCadastro";
            this.lblInfoCadastro.Size = new System.Drawing.Size(662, 40);
            this.lblInfoCadastro.TabIndex = 9;
            this.lblInfoCadastro.Text = " Ainda não fez o Cadastro (Empresa) para acessar nosso portal Ajuda Social Admini" +
    "strativo?\r\nFavor se redirecionar à nossa página web ou Aplicativo mobile e reali" +
    "zar sua inscrição.\r\n";
            this.lblInfoCadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInfoAcesso
            // 
            this.lblInfoAcesso.AutoSize = true;
            this.lblInfoAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInfoAcesso.Location = new System.Drawing.Point(51, 291);
            this.lblInfoAcesso.Name = "lblInfoAcesso";
            this.lblInfoAcesso.Size = new System.Drawing.Size(685, 20);
            this.lblInfoAcesso.TabIndex = 10;
            this.lblInfoAcesso.Text = "Após o cadastro no Formulário (Empresa), conecte seu login para dar procedimento " +
    "ao sistema.\r\n";
            this.lblInfoAcesso.Click += new System.EventHandler(this.lblInfoAcesso_Click);
            // 
            // lblInfoConexao
            // 
            this.lblInfoConexao.AutoSize = true;
            this.lblInfoConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInfoConexao.Location = new System.Drawing.Point(51, 407);
            this.lblInfoConexao.Name = "lblInfoConexao";
            this.lblInfoConexao.Size = new System.Drawing.Size(685, 60);
            this.lblInfoConexao.TabIndex = 11;
            this.lblInfoConexao.Text = resources.GetString("lblInfoConexao.Text");
            this.lblInfoConexao.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // frmManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblInfoConexao);
            this.Controls.Add(this.lblInfoAcesso);
            this.Controls.Add(this.lblInfoCadastro);
            this.Controls.Add(this.lblAcesso);
            this.Controls.Add(this.lblConexao);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "frmManual";
            this.Text = "Manual";
            this.voltar.ResumeLayout(false);
            this.voltar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip voltar;
        private System.Windows.Forms.ToolStripMenuItem clcVoltar;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblConexao;
        private System.Windows.Forms.Label lblAcesso;
        private System.Windows.Forms.Label lblInfoCadastro;
        private System.Windows.Forms.Label lblInfoAcesso;
        private System.Windows.Forms.Label lblInfoConexao;
    }
}