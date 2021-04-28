namespace Aplicação
{
    partial class frmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTituloC = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.eMPREGOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.pesquisa = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.remover = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.gravar = new System.Windows.Forms.ToolStripButton();
            this.lblSalvar = new System.Windows.Forms.ToolStripLabel();
            this.voltarE = new System.Windows.Forms.MenuStrip();
            this.btnvoltar = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPREGOBindingNavigator)).BeginInit();
            this.eMPREGOBindingNavigator.SuspendLayout();
            this.voltarE.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(-2, 641);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1064, 20);
            this.textBox2.TabIndex = 68;
            this.textBox2.Text = "Todos os Direitos Reservados 2020";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblDescricao);
            this.splitContainer1.Panel1.Controls.Add(this.lblTituloC);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.txtTexto);
            this.splitContainer1.Panel2.Controls.Add(this.eMPREGOBindingNavigator);
            this.splitContainer1.Size = new System.Drawing.Size(1062, 603);
            this.splitContainer1.SplitterDistance = 529;
            this.splitContainer1.TabIndex = 69;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.Location = new System.Drawing.Point(51, 315);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(457, 34);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Utilize o recurso \"Pesquisar\" para encontrar um arquivo salvo\r\n no computador, co" +
    "mo vgas, cursos, projetos e oficinas.";
            // 
            // lblTituloC
            // 
            this.lblTituloC.AutoSize = true;
            this.lblTituloC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloC.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTituloC.Location = new System.Drawing.Point(259, 265);
            this.lblTituloC.Name = "lblTituloC";
            this.lblTituloC.Size = new System.Drawing.Size(139, 26);
            this.lblTituloC.TabIndex = 1;
            this.lblTituloC.Text = "CONSULTA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 138);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTexto.Location = new System.Drawing.Point(86, 87);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(374, 444);
            this.txtTexto.TabIndex = 11;
            this.txtTexto.Text = "";
            // 
            // eMPREGOBindingNavigator
            // 
            this.eMPREGOBindingNavigator.AddNewItem = null;
            this.eMPREGOBindingNavigator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.eMPREGOBindingNavigator.CountItem = null;
            this.eMPREGOBindingNavigator.DeleteItem = null;
            this.eMPREGOBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.eMPREGOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisa,
            this.toolStripLabel1,
            this.remover,
            this.toolStripLabel2,
            this.gravar,
            this.lblSalvar});
            this.eMPREGOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eMPREGOBindingNavigator.MoveFirstItem = null;
            this.eMPREGOBindingNavigator.MoveLastItem = null;
            this.eMPREGOBindingNavigator.MoveNextItem = null;
            this.eMPREGOBindingNavigator.MovePreviousItem = null;
            this.eMPREGOBindingNavigator.Name = "eMPREGOBindingNavigator";
            this.eMPREGOBindingNavigator.PositionItem = null;
            this.eMPREGOBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.eMPREGOBindingNavigator.Size = new System.Drawing.Size(529, 25);
            this.eMPREGOBindingNavigator.TabIndex = 9;
            this.eMPREGOBindingNavigator.Text = "bindingNavigator1";
            // 
            // pesquisa
            // 
            this.pesquisa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pesquisa.Image = ((System.Drawing.Image)(resources.GetObject("pesquisa.Image")));
            this.pesquisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(23, 22);
            this.pesquisa.Text = "toolStripButton1";
            this.pesquisa.Click += new System.EventHandler(this.pesquisa_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel1.Text = "Pesquisar ";
            // 
            // remover
            // 
            this.remover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.remover.Image = ((System.Drawing.Image)(resources.GetObject("remover.Image")));
            this.remover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(23, 22);
            this.remover.Text = "toolStripButton1";
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel2.Text = "Remover";
            // 
            // gravar
            // 
            this.gravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gravar.Image = ((System.Drawing.Image)(resources.GetObject("gravar.Image")));
            this.gravar.Name = "gravar";
            this.gravar.Size = new System.Drawing.Size(23, 22);
            this.gravar.Text = "Salvar Dados";
            this.gravar.Click += new System.EventHandler(this.gravar_Click);
            // 
            // lblSalvar
            // 
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(41, 22);
            this.lblSalvar.Text = "Gravar";
            // 
            // voltarE
            // 
            this.voltarE.BackColor = System.Drawing.Color.Gray;
            this.voltarE.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.voltarE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnvoltar});
            this.voltarE.Location = new System.Drawing.Point(0, 0);
            this.voltarE.Name = "voltarE";
            this.voltarE.Size = new System.Drawing.Size(1064, 29);
            this.voltarE.TabIndex = 70;
            this.voltarE.Text = "menu";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(81, 25);
            this.btnvoltar.Text = "VOLTAR";
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 661);
            this.Controls.Add(this.voltarE);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBox2);
            this.MaximizeBox = false;
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPREGOBindingNavigator)).EndInit();
            this.eMPREGOBindingNavigator.ResumeLayout(false);
            this.eMPREGOBindingNavigator.PerformLayout();
            this.voltarE.ResumeLayout(false);
            this.voltarE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip voltarE;
        private System.Windows.Forms.ToolStripMenuItem btnvoltar;
        private System.Windows.Forms.BindingNavigator eMPREGOBindingNavigator;
        private System.Windows.Forms.ToolStripButton pesquisa;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton gravar;
        private System.Windows.Forms.ToolStripLabel lblSalvar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTituloC;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox txtTexto;
        private System.Windows.Forms.ToolStripButton remover;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}