namespace Aplicação
{
    partial class frmMembros
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
            this.voltarE = new System.Windows.Forms.MenuStrip();
            this.btnvoltar = new System.Windows.Forms.ToolStripMenuItem();
            this.bD_DKSTDataSet1 = new Aplicação.BD_DKSTDataSet1();
            this.mEMBROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEMBROSTableAdapter = new Aplicação.BD_DKSTDataSet1TableAdapters.MEMBROSTableAdapter();
            this.tableAdapterManager = new Aplicação.BD_DKSTDataSet1TableAdapters.TableAdapterManager();
            this.mEMBROSDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nOMEToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.nOMEToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.nomeToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.renda_familiar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoas_casa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.voltarE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DKSTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBROSDataGridView)).BeginInit();
            this.nomeToolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.voltarE.TabIndex = 8;
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
            // bD_DKSTDataSet1
            // 
            this.bD_DKSTDataSet1.DataSetName = "BD_DKSTDataSet1";
            this.bD_DKSTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEMBROSBindingSource
            // 
            this.mEMBROSBindingSource.DataMember = "MEMBROS";
            this.mEMBROSBindingSource.DataSource = this.bD_DKSTDataSet1;
            // 
            // mEMBROSTableAdapter
            // 
            this.mEMBROSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MEMBROSTableAdapter = this.mEMBROSTableAdapter;
            this.tableAdapterManager.UpdateOrder = Aplicação.BD_DKSTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VOLUNTARIADOSTableAdapter = null;
            // 
            // mEMBROSDataGridView
            // 
            this.mEMBROSDataGridView.AutoGenerateColumns = false;
            this.mEMBROSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.mEMBROSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mEMBROSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.cep,
            this.renda_familiar,
            this.pessoas_casa});
            this.mEMBROSDataGridView.DataSource = this.mEMBROSBindingSource;
            this.mEMBROSDataGridView.Location = new System.Drawing.Point(40, 105);
            this.mEMBROSDataGridView.Name = "mEMBROSDataGridView";
            this.mEMBROSDataGridView.Size = new System.Drawing.Size(981, 494);
            this.mEMBROSDataGridView.TabIndex = 9;
            this.mEMBROSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mEMBROSDataGridView_CellContentClick);
            // 
            // nomeToolStrip1
            // 
            this.nomeToolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.nomeToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.nomeToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOMEToolStripLabel1,
            this.nOMEToolStripTextBox1,
            this.nomeToolStripButton1});
            this.nomeToolStrip1.Location = new System.Drawing.Point(0, 29);
            this.nomeToolStrip1.Name = "nomeToolStrip1";
            this.nomeToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.nomeToolStrip1.Size = new System.Drawing.Size(1064, 25);
            this.nomeToolStrip1.TabIndex = 11;
            this.nomeToolStrip1.Text = "nomeToolStrip1";
            // 
            // nOMEToolStripLabel1
            // 
            this.nOMEToolStripLabel1.Name = "nOMEToolStripLabel1";
            this.nOMEToolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.nOMEToolStripLabel1.Text = "NOME:";
            // 
            // nOMEToolStripTextBox1
            // 
            this.nOMEToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nOMEToolStripTextBox1.Name = "nOMEToolStripTextBox1";
            this.nOMEToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // nomeToolStripButton1
            // 
            this.nomeToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nomeToolStripButton1.Name = "nomeToolStripButton1";
            this.nomeToolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.nomeToolStripButton1.Text = "Buscar";
            this.nomeToolStripButton1.Click += new System.EventHandler(this.nomeToolStripButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 642);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(1064, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Todos os Direitos Reservados 2020";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // renda_familiar
            // 
            this.renda_familiar.DataPropertyName = "renda_familiar";
            this.renda_familiar.HeaderText = "RENDA_FAMILIAR";
            this.renda_familiar.Name = "renda_familiar";
            this.renda_familiar.Width = 125;
            // 
            // pessoas_casa
            // 
            this.pessoas_casa.DataPropertyName = "pessoas_casa";
            this.pessoas_casa.HeaderText = "PESSOAS_CASA";
            this.pessoas_casa.Name = "pessoas_casa";
            this.pessoas_casa.Width = 116;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(204, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 25);
            this.button2.TabIndex = 73;
            this.button2.Text = "Limpar Buscas";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nomeToolStrip1);
            this.Controls.Add(this.mEMBROSDataGridView);
            this.Controls.Add(this.voltarE);
            this.MaximizeBox = false;
            this.Name = "frmMembros";
            this.Text = "Membros";
            this.Load += new System.EventHandler(this.frmMembros_Load);
            this.voltarE.ResumeLayout(false);
            this.voltarE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DKSTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBROSDataGridView)).EndInit();
            this.nomeToolStrip1.ResumeLayout(false);
            this.nomeToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip voltarE;
        private System.Windows.Forms.ToolStripMenuItem btnvoltar;
        private BD_DKSTDataSet1 bD_DKSTDataSet1;
        private System.Windows.Forms.BindingSource mEMBROSBindingSource;
        private BD_DKSTDataSet1TableAdapters.MEMBROSTableAdapter mEMBROSTableAdapter;
        private BD_DKSTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridView mEMBROSDataGridView;
        private System.Windows.Forms.ToolStrip nomeToolStrip1;
        private System.Windows.Forms.ToolStripLabel nOMEToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox nOMEToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton nomeToolStripButton1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn renda_familiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoas_casa;
        private System.Windows.Forms.Button button2;
        //private System.Windows.Forms.DataGridView dtView;
    }
}