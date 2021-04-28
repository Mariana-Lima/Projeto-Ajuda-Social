namespace Aplicação
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.voltar = new System.Windows.Forms.MenuStrip();
            this.vOLTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfoSobre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSobre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.voltar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.voltar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.voltar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vOLTARToolStripMenuItem});
            this.voltar.Location = new System.Drawing.Point(0, 0);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(784, 29);
            this.voltar.TabIndex = 0;
            this.voltar.Text = "menu";
            // 
            // vOLTARToolStripMenuItem
            // 
            this.vOLTARToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.vOLTARToolStripMenuItem.Name = "vOLTARToolStripMenuItem";
            this.vOLTARToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.vOLTARToolStripMenuItem.Text = "VOLTAR";
            this.vOLTARToolStripMenuItem.Click += new System.EventHandler(this.vOLTARToolStripMenuItem_Click);
            // 
            // lblInfoSobre
            // 
            this.lblInfoSobre.AutoSize = true;
            this.lblInfoSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfoSobre.Location = new System.Drawing.Point(32, 51);
            this.lblInfoSobre.Name = "lblInfoSobre";
            this.lblInfoSobre.Size = new System.Drawing.Size(726, 153);
            this.lblInfoSobre.TabIndex = 1;
            this.lblInfoSobre.Text = resources.GetString("lblInfoSobre.Text");
            this.lblInfoSobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfoSobre.Click += new System.EventHandler(this.lblInfoSobre_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 542);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(784, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Todos os Direitos Reservados 2020";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblSobre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSobre.Location = new System.Drawing.Point(73, 78);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(123, 31);
            this.lblSobre.TabIndex = 3;
            this.lblSobre.Text = "SOBRE:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblInfoSobre);
            this.groupBox1.Location = new System.Drawing.Point(0, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 256);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSobre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.voltar);
            this.MainMenuStrip = this.voltar;
            this.MaximizeBox = false;
            this.Name = "frmSobre";
            this.Text = "Sobre";
            this.voltar.ResumeLayout(false);
            this.voltar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip voltar;
        private System.Windows.Forms.ToolStripMenuItem vOLTARToolStripMenuItem;
        private System.Windows.Forms.Label lblInfoSobre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}