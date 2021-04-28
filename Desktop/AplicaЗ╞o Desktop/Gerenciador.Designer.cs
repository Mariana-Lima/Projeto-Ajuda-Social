namespace Aplicação
{
    partial class frmGerenciador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciador));
            this.MenuGerenciar = new System.Windows.Forms.MenuStrip();
            this.cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.trabalhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oficinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentacao = new System.Windows.Forms.ToolStripMenuItem();
            this.membrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voluntariadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltar = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblInfoG = new System.Windows.Forms.Label();
            this.lblInfoGerenciar = new System.Windows.Forms.Label();
            this.MenuGerenciar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuGerenciar
            // 
            this.MenuGerenciar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.MenuGerenciar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MenuGerenciar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastro,
            this.movimentacao,
            this.cONSULTAToolStripMenuItem,
            this.voltar});
            this.MenuGerenciar.Location = new System.Drawing.Point(0, 0);
            this.MenuGerenciar.Name = "MenuGerenciar";
            this.MenuGerenciar.Size = new System.Drawing.Size(984, 29);
            this.MenuGerenciar.TabIndex = 0;
            this.MenuGerenciar.Text = "menuStrip1";
            // 
            // cadastro
            // 
            this.cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabalhoToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.projetoToolStripMenuItem,
            this.oficinasToolStripMenuItem});
            this.cadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(106, 25);
            this.cadastro.Text = "CADASTRO";
            // 
            // trabalhoToolStripMenuItem
            // 
            this.trabalhoToolStripMenuItem.Name = "trabalhoToolStripMenuItem";
            this.trabalhoToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.trabalhoToolStripMenuItem.Text = "Novo Emprego";
            this.trabalhoToolStripMenuItem.Click += new System.EventHandler(this.trabalhoToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.cursoToolStripMenuItem.Text = "Cursos";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
            // 
            // projetoToolStripMenuItem
            // 
            this.projetoToolStripMenuItem.Name = "projetoToolStripMenuItem";
            this.projetoToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.projetoToolStripMenuItem.Text = "Projetos";
            this.projetoToolStripMenuItem.Click += new System.EventHandler(this.projetoToolStripMenuItem_Click);
            // 
            // oficinasToolStripMenuItem
            // 
            this.oficinasToolStripMenuItem.Name = "oficinasToolStripMenuItem";
            this.oficinasToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.oficinasToolStripMenuItem.Text = "Oficinas";
            this.oficinasToolStripMenuItem.Click += new System.EventHandler(this.oficinasToolStripMenuItem_Click);
            // 
            // movimentacao
            // 
            this.movimentacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membrosToolStripMenuItem,
            this.voluntariadosToolStripMenuItem});
            this.movimentacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.movimentacao.Name = "movimentacao";
            this.movimentacao.Size = new System.Drawing.Size(161, 25);
            this.movimentacao.Text = "MOVIMENTAÇÕES";
            // 
            // membrosToolStripMenuItem
            // 
            this.membrosToolStripMenuItem.Name = "membrosToolStripMenuItem";
            this.membrosToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.membrosToolStripMenuItem.Text = "Membros";
            this.membrosToolStripMenuItem.Click += new System.EventHandler(this.membrosToolStripMenuItem_Click);
            // 
            // voluntariadosToolStripMenuItem
            // 
            this.voluntariadosToolStripMenuItem.Name = "voluntariadosToolStripMenuItem";
            this.voluntariadosToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.voluntariadosToolStripMenuItem.Text = "Voluntariados";
            this.voluntariadosToolStripMenuItem.Click += new System.EventHandler(this.voluntariadosToolStripMenuItem_Click);
            // 
            // cONSULTAToolStripMenuItem
            // 
            this.cONSULTAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cONSULTAToolStripMenuItem.Name = "cONSULTAToolStripMenuItem";
            this.cONSULTAToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.cONSULTAToolStripMenuItem.Text = "CONSULTA";
            this.cONSULTAToolStripMenuItem.Click += new System.EventHandler(this.cONSULTAToolStripMenuItem_Click);
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(81, 25);
            this.voltar.Text = "VOLTAR";
            this.voltar.Click += new System.EventHandler(this.vOLTARToolStripMenuItem_Click);
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
            this.textBox1.Size = new System.Drawing.Size(984, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Todos os Direitos Reservados 2020";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.lblInfoG);
            this.splitContainer1.Panel2.Controls.Add(this.lblInfoGerenciar);
            this.splitContainer1.Size = new System.Drawing.Size(984, 503);
            this.splitContainer1.SplitterDistance = 491;
            this.splitContainer1.TabIndex = 5;
            // 
            // lblInfoG
            // 
            this.lblInfoG.AutoSize = true;
            this.lblInfoG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblInfoG.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblInfoG.Location = new System.Drawing.Point(91, 203);
            this.lblInfoG.Name = "lblInfoG";
            this.lblInfoG.Size = new System.Drawing.Size(329, 26);
            this.lblInfoG.TabIndex = 1;
            this.lblInfoG.Text = "CONTROLE DE ATIVIDADES";
            // 
            // lblInfoGerenciar
            // 
            this.lblInfoGerenciar.AutoSize = true;
            this.lblInfoGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblInfoGerenciar.ForeColor = System.Drawing.Color.White;
            this.lblInfoGerenciar.Location = new System.Drawing.Point(41, 207);
            this.lblInfoGerenciar.Name = "lblInfoGerenciar";
            this.lblInfoGerenciar.Size = new System.Drawing.Size(423, 80);
            this.lblInfoGerenciar.TabIndex = 0;
            this.lblInfoGerenciar.Text = "\r\n\r\nUtilize os recursos acima para iniciar uma atividade.\r\n\r\n";
            // 
            // frmGerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MenuGerenciar);
            this.MainMenuStrip = this.MenuGerenciar;
            this.MaximizeBox = false;
            this.Name = "frmGerenciador";
            this.Text = "Gerenciador";
            this.Load += new System.EventHandler(this.frmGerenciador_Load);
            this.MenuGerenciar.ResumeLayout(false);
            this.MenuGerenciar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuGerenciar;
        private System.Windows.Forms.ToolStripMenuItem cadastro;
        private System.Windows.Forms.ToolStripMenuItem trabalhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oficinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentacao;
        private System.Windows.Forms.ToolStripMenuItem membrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem voluntariadosToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblInfoGerenciar;
        private System.Windows.Forms.Label lblInfoG;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAToolStripMenuItem;
    }
}