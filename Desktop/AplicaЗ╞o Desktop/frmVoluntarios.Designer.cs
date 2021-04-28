namespace Aplicação
{
    partial class frmVoluntarios
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.voltarP = new System.Windows.Forms.MenuStrip();
            this.vOLTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bD_DKSTDataSet1 = new Aplicação.BD_DKSTDataSet1();
            this.vOLUNTARIADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vOLUNTARIADOSTableAdapter = new Aplicação.BD_DKSTDataSet1TableAdapters.VOLUNTARIADOSTableAdapter();
            this.tableAdapterManager = new Aplicação.BD_DKSTDataSet1TableAdapters.TableAdapterManager();
            this.vOLUNTARIADOSDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeToolStrip = new System.Windows.Forms.ToolStrip();
            this.nOMEToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nOMEToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.lblBuscar = new System.Windows.Forms.ToolStripButton();
            this.razãoToolStrip = new System.Windows.Forms.ToolStrip();
            this.rAZAO_SOCIALToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.rAZAO_SOCIALToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.lblRazao = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escolaridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltarP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DKSTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOLUNTARIADOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOLUNTARIADOSDataGridView)).BeginInit();
            this.nomeToolStrip.SuspendLayout();
            this.razãoToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(2, 642);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1064, 20);
            this.textBox2.TabIndex = 67;
            this.textBox2.Text = "Todos os Direitos Reservados 2020";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // voltarP
            // 
            this.voltarP.BackColor = System.Drawing.Color.Gray;
            this.voltarP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.voltarP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vOLTARToolStripMenuItem});
            this.voltarP.Location = new System.Drawing.Point(0, 0);
            this.voltarP.Name = "voltarP";
            this.voltarP.Size = new System.Drawing.Size(1064, 29);
            this.voltarP.TabIndex = 68;
            this.voltarP.Text = "menu";
            // 
            // vOLTARToolStripMenuItem
            // 
            this.vOLTARToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.vOLTARToolStripMenuItem.Name = "vOLTARToolStripMenuItem";
            this.vOLTARToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.vOLTARToolStripMenuItem.Text = "VOLTAR";
            this.vOLTARToolStripMenuItem.Click += new System.EventHandler(this.vOLTARToolStripMenuItem_Click);
            // 
            // bD_DKSTDataSet1
            // 
            this.bD_DKSTDataSet1.DataSetName = "BD_DKSTDataSet1";
            this.bD_DKSTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vOLUNTARIADOSBindingSource
            // 
            this.vOLUNTARIADOSBindingSource.DataMember = "VOLUNTARIADOS";
            this.vOLUNTARIADOSBindingSource.DataSource = this.bD_DKSTDataSet1;
            // 
            // vOLUNTARIADOSTableAdapter
            // 
            this.vOLUNTARIADOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MEMBROSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aplicação.BD_DKSTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VOLUNTARIADOSTableAdapter = this.vOLUNTARIADOSTableAdapter;
            // 
            // vOLUNTARIADOSDataGridView
            // 
            this.vOLUNTARIADOSDataGridView.AllowUserToOrderColumns = true;
            this.vOLUNTARIADOSDataGridView.AutoGenerateColumns = false;
            this.vOLUNTARIADOSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.vOLUNTARIADOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vOLUNTARIADOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.rg,
            this.cpf,
            this.nascimento,
            this.escolaridade,
            this.genero,
            this.email,
            this.telefone,
            this.celular,
            this.endereco,
            this.numero,
            this.complemento,
            this.cep});
            this.vOLUNTARIADOSDataGridView.DataSource = this.vOLUNTARIADOSBindingSource;
            this.vOLUNTARIADOSDataGridView.Location = new System.Drawing.Point(41, 107);
            this.vOLUNTARIADOSDataGridView.Name = "vOLUNTARIADOSDataGridView";
            this.vOLUNTARIADOSDataGridView.Size = new System.Drawing.Size(982, 492);
            this.vOLUNTARIADOSDataGridView.TabIndex = 69;
            this.vOLUNTARIADOSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vOLUNTARIADOSDataGridView_CellContentClick);
            // 
            // nomeToolStrip
            // 
            this.nomeToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.nomeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOMEToolStripLabel,
            this.nOMEToolStripTextBox,
            this.lblBuscar});
            this.nomeToolStrip.Location = new System.Drawing.Point(0, 29);
            this.nomeToolStrip.Name = "nomeToolStrip";
            this.nomeToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.nomeToolStrip.Size = new System.Drawing.Size(1064, 25);
            this.nomeToolStrip.TabIndex = 70;
            this.nomeToolStrip.Text = "nomeToolStrip";
            this.nomeToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.nomeToolStrip_ItemClicked);
            // 
            // nOMEToolStripLabel
            // 
            this.nOMEToolStripLabel.Name = "nOMEToolStripLabel";
            this.nOMEToolStripLabel.Size = new System.Drawing.Size(45, 22);
            this.nOMEToolStripLabel.Text = "NOME:";
            // 
            // nOMEToolStripTextBox
            // 
            this.nOMEToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nOMEToolStripTextBox.Name = "nOMEToolStripTextBox";
            this.nOMEToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // lblBuscar
            // 
            this.lblBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(46, 22);
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.Click += new System.EventHandler(this.nomeToolStripButton_Click);
            // 
            // razãoToolStrip
            // 
            this.razãoToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.razãoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rAZAO_SOCIALToolStripLabel,
            this.rAZAO_SOCIALToolStripTextBox,
            this.lblRazao});
            this.razãoToolStrip.Location = new System.Drawing.Point(220, 29);
            this.razãoToolStrip.Name = "razãoToolStrip";
            this.razãoToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.razãoToolStrip.Size = new System.Drawing.Size(191, 25);
            this.razãoToolStrip.TabIndex = 71;
            this.razãoToolStrip.Text = "razãoToolStrip";
            // 
            // rAZAO_SOCIALToolStripLabel
            // 
            this.rAZAO_SOCIALToolStripLabel.BackColor = System.Drawing.SystemColors.Control;
            this.rAZAO_SOCIALToolStripLabel.Name = "rAZAO_SOCIALToolStripLabel";
            this.rAZAO_SOCIALToolStripLabel.Size = new System.Drawing.Size(31, 22);
            this.rAZAO_SOCIALToolStripLabel.Text = "CPF:";
            this.rAZAO_SOCIALToolStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rAZAO_SOCIALToolStripTextBox
            // 
            this.rAZAO_SOCIALToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rAZAO_SOCIALToolStripTextBox.Name = "rAZAO_SOCIALToolStripTextBox";
            this.rAZAO_SOCIALToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.rAZAO_SOCIALToolStripTextBox.Click += new System.EventHandler(this.rAZAO_SOCIALToolStripTextBox_Click);
            // 
            // lblRazao
            // 
            this.lblRazao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(46, 22);
            this.lblRazao.Text = "Buscar";
            this.lblRazao.Click += new System.EventHandler(this.razãoToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(414, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 25);
            this.button1.TabIndex = 72;
            this.button1.Text = "Limpar Buscas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 43;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "NOME";
            this.nome.Name = "nome";
            this.nome.Width = 64;
            // 
            // rg
            // 
            this.rg.DataPropertyName = "rg";
            this.rg.HeaderText = "RG";
            this.rg.Name = "rg";
            this.rg.Width = 48;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.Width = 52;
            // 
            // nascimento
            // 
            this.nascimento.DataPropertyName = "nascimento";
            this.nascimento.HeaderText = "NASCIMENTO";
            this.nascimento.Name = "nascimento";
            this.nascimento.Width = 103;
            // 
            // escolaridade
            // 
            this.escolaridade.DataPropertyName = "escolaridade";
            this.escolaridade.HeaderText = "ESCOLARIDADE";
            this.escolaridade.Name = "escolaridade";
            this.escolaridade.Width = 115;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "GENERO";
            this.genero.Name = "genero";
            this.genero.Width = 78;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "EMAIL";
            this.email.Name = "email";
            this.email.Width = 64;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "TELEFONE";
            this.telefone.Name = "telefone";
            this.telefone.Width = 88;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "CELULAR";
            this.celular.Name = "celular";
            this.celular.Width = 81;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "ENDERECO";
            this.endereco.Name = "endereco";
            this.endereco.Width = 92;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "NUMERO";
            this.numero.Name = "numero";
            this.numero.Width = 80;
            // 
            // complemento
            // 
            this.complemento.DataPropertyName = "complemento";
            this.complemento.HeaderText = "COMPLEMENTO";
            this.complemento.Name = "complemento";
            this.complemento.Width = 115;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "cep";
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            this.cep.Width = 53;
            // 
            // frmVoluntarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.razãoToolStrip);
            this.Controls.Add(this.nomeToolStrip);
            this.Controls.Add(this.vOLUNTARIADOSDataGridView);
            this.Controls.Add(this.voltarP);
            this.Controls.Add(this.textBox2);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeBox = false;
            this.Name = "frmVoluntarios";
            this.Text = "Voluntarios";
            this.Load += new System.EventHandler(this.frmVoluntarios_Load);
            this.voltarP.ResumeLayout(false);
            this.voltarP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DKSTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOLUNTARIADOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOLUNTARIADOSDataGridView)).EndInit();
            this.nomeToolStrip.ResumeLayout(false);
            this.nomeToolStrip.PerformLayout();
            this.razãoToolStrip.ResumeLayout(false);
            this.razãoToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip voltarP;
        private System.Windows.Forms.ToolStripMenuItem vOLTARToolStripMenuItem;
        private BD_DKSTDataSet1 bD_DKSTDataSet1;
        private System.Windows.Forms.BindingSource vOLUNTARIADOSBindingSource;
        private BD_DKSTDataSet1TableAdapters.VOLUNTARIADOSTableAdapter vOLUNTARIADOSTableAdapter;
        private BD_DKSTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vOLUNTARIADOSDataGridView;
        private System.Windows.Forms.ToolStrip nomeToolStrip;
        private System.Windows.Forms.ToolStripLabel nOMEToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nOMEToolStripTextBox;
        private System.Windows.Forms.ToolStripButton lblBuscar;
        private System.Windows.Forms.ToolStrip razãoToolStrip;
        private System.Windows.Forms.ToolStripLabel rAZAO_SOCIALToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox rAZAO_SOCIALToolStripTextBox;
        private System.Windows.Forms.ToolStripButton lblRazao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn escolaridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
    }
}