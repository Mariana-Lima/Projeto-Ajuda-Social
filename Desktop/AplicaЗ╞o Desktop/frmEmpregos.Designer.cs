namespace Aplicação
{
    partial class frmEmpregos
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
            System.Windows.Forms.Label nOME_DA_VAGALabel;
            System.Windows.Forms.Label dATA_DA_VAGALabel;
            System.Windows.Forms.Label hORARIO_DA_VAGALabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label lblDescricao;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpregos));
            this.voltarE = new System.Windows.Forms.MenuStrip();
            this.btnvoltar = new System.Windows.Forms.ToolStripMenuItem();
            this.bD_DKSTDataSet = new Aplicação.BD_DKSTDataSet();
            this.eMPREGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Aplicação.BD_DKSTDataSetTableAdapters.TableAdapterManager();
            this.eMPREGOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.add = new System.Windows.Forms.ToolStripButton();
            this.lblNovo = new System.Windows.Forms.ToolStripLabel();
            this.remove = new System.Windows.Forms.ToolStripButton();
            this.lblRemover = new System.Windows.Forms.ToolStripLabel();
            this.ver = new System.Windows.Forms.ToolStripButton();
            this.lblVisualizar = new System.Windows.Forms.ToolStripLabel();
            this.eMPREGOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lblSalvar = new System.Windows.Forms.ToolStripLabel();
            this.nOME_DA_VAGATextBox = new System.Windows.Forms.TextBox();
            this.dATA_DA_VAGADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hORARIO_DA_VAGAMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.iNFO_DA_VAGARichTextBox = new System.Windows.Forms.RichTextBox();
            this.tELEFONEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.cURSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpVaga = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblGerar = new System.Windows.Forms.Label();
            this.grpUsers = new System.Windows.Forms.GroupBox();
            this.mEMBROSComboBox = new System.Windows.Forms.ComboBox();
            this.mEMBROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_DKSTDataSet1 = new Aplicação.BD_DKSTDataSet1();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mEMBROSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mEMBROSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new Aplicação.BD_DKSTDataSet1TableAdapters.TableAdapterManager();
            this.eMPREGOTableAdapter = new Aplicação.BD_DKSTDataSetTableAdapters.EMPREGOTableAdapter();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            nOME_DA_VAGALabel = new System.Windows.Forms.Label();
            dATA_DA_VAGALabel = new System.Windows.Forms.Label();
            hORARIO_DA_VAGALabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            lblDescricao = new System.Windows.Forms.Label();
            this.voltarE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DKSTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPREGOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPREGOBindingNavigator)).BeginInit();
            this.eMPREGOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOBindingSource)).BeginInit();
            this.grpVaga.SuspendLayout();
            this.grpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DKSTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBROSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBROSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nOME_DA_VAGALabel
            // 
            nOME_DA_VAGALabel.AutoSize = true;
            nOME_DA_VAGALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            nOME_DA_VAGALabel.Location = new System.Drawing.Point(63, 122);
            nOME_DA_VAGALabel.Name = "nOME_DA_VAGALabel";
            nOME_DA_VAGALabel.Size = new System.Drawing.Size(99, 15);
            nOME_DA_VAGALabel.TabIndex = 10;
            nOME_DA_VAGALabel.Text = "NOME DA VAGA:";
            // 
            // dATA_DA_VAGALabel
            // 
            dATA_DA_VAGALabel.AutoSize = true;
            dATA_DA_VAGALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dATA_DA_VAGALabel.Location = new System.Drawing.Point(66, 148);
            dATA_DA_VAGALabel.Name = "dATA_DA_VAGALabel";
            dATA_DA_VAGALabel.Size = new System.Drawing.Size(92, 15);
            dATA_DA_VAGALabel.TabIndex = 12;
            dATA_DA_VAGALabel.Text = "DATA DA VAGA:";
            // 
            // hORARIO_DA_VAGALabel
            // 
            hORARIO_DA_VAGALabel.AutoSize = true;
            hORARIO_DA_VAGALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            hORARIO_DA_VAGALabel.Location = new System.Drawing.Point(45, 171);
            hORARIO_DA_VAGALabel.Name = "hORARIO_DA_VAGALabel";
            hORARIO_DA_VAGALabel.Size = new System.Drawing.Size(117, 15);
            hORARIO_DA_VAGALabel.TabIndex = 14;
            hORARIO_DA_VAGALabel.Text = "HORARIO DA VAGA:";
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            tELEFONELabel.Location = new System.Drawing.Point(595, 123);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(73, 15);
            tELEFONELabel.TabIndex = 18;
            tELEFONELabel.Text = "TELEFONE:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            eMAILLabel.Location = new System.Drawing.Point(618, 147);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(46, 15);
            eMAILLabel.TabIndex = 20;
            eMAILLabel.Text = "EMAIL:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            lblDescricao.Location = new System.Drawing.Point(83, 194);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new System.Drawing.Size(79, 15);
            lblDescricao.TabIndex = 33;
            lblDescricao.Text = "DESCRIÇÃO:";
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
            this.voltarE.TabIndex = 6;
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
            // bD_DKSTDataSet
            // 
            this.bD_DKSTDataSet.DataSetName = "BD_DKSTDataSet";
            this.bD_DKSTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPREGOBindingSource
            // 
            this.eMPREGOBindingSource.DataMember = "EMPREGO";
            this.eMPREGOBindingSource.DataSource = this.bD_DKSTDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CURSOTableAdapter = null;
            this.tableAdapterManager.EMPREGOTableAdapter = null;
            this.tableAdapterManager.OFICINATableAdapter = null;
            this.tableAdapterManager.PROJETOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aplicação.BD_DKSTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eMPREGOBindingNavigator
            // 
            this.eMPREGOBindingNavigator.AddNewItem = null;
            this.eMPREGOBindingNavigator.BackColor = System.Drawing.SystemColors.Control;
            this.eMPREGOBindingNavigator.BindingSource = this.eMPREGOBindingSource;
            this.eMPREGOBindingNavigator.CountItem = null;
            this.eMPREGOBindingNavigator.DeleteItem = null;
            this.eMPREGOBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.eMPREGOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.lblNovo,
            this.remove,
            this.lblRemover,
            this.ver,
            this.lblVisualizar,
            this.eMPREGOBindingNavigatorSaveItem,
            this.lblSalvar});
            this.eMPREGOBindingNavigator.Location = new System.Drawing.Point(0, 29);
            this.eMPREGOBindingNavigator.MoveFirstItem = null;
            this.eMPREGOBindingNavigator.MoveLastItem = null;
            this.eMPREGOBindingNavigator.MoveNextItem = null;
            this.eMPREGOBindingNavigator.MovePreviousItem = null;
            this.eMPREGOBindingNavigator.Name = "eMPREGOBindingNavigator";
            this.eMPREGOBindingNavigator.PositionItem = null;
            this.eMPREGOBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.eMPREGOBindingNavigator.Size = new System.Drawing.Size(1064, 25);
            this.eMPREGOBindingNavigator.TabIndex = 8;
            this.eMPREGOBindingNavigator.Text = "bindingNavigator1";
            // 
            // add
            // 
            this.add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(23, 22);
            this.add.Text = "toolStripButton2";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // lblNovo
            // 
            this.lblNovo.Name = "lblNovo";
            this.lblNovo.Size = new System.Drawing.Size(36, 22);
            this.lblNovo.Text = "Novo";
            // 
            // remove
            // 
            this.remove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.remove.Image = ((System.Drawing.Image)(resources.GetObject("remove.Image")));
            this.remove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(23, 22);
            this.remove.Text = "toolStripButton2";
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // lblRemover
            // 
            this.lblRemover.Name = "lblRemover";
            this.lblRemover.Size = new System.Drawing.Size(54, 22);
            this.lblRemover.Text = "Remover";
            // 
            // ver
            // 
            this.ver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ver.Image = ((System.Drawing.Image)(resources.GetObject("ver.Image")));
            this.ver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(23, 22);
            this.ver.Text = "toolStripButton1";
            this.ver.Click += new System.EventHandler(this.ver_Click);
            // 
            // lblVisualizar
            // 
            this.lblVisualizar.Name = "lblVisualizar";
            this.lblVisualizar.Size = new System.Drawing.Size(56, 22);
            this.lblVisualizar.Text = "Visualizar";
            // 
            // eMPREGOBindingNavigatorSaveItem
            // 
            this.eMPREGOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eMPREGOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eMPREGOBindingNavigatorSaveItem.Image")));
            this.eMPREGOBindingNavigatorSaveItem.Name = "eMPREGOBindingNavigatorSaveItem";
            this.eMPREGOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eMPREGOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.eMPREGOBindingNavigatorSaveItem.Click += new System.EventHandler(this.eMPREGOBindingNavigatorSaveItem_Click);
            // 
            // lblSalvar
            // 
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(41, 22);
            this.lblSalvar.Text = "Gravar";
            // 
            // nOME_DA_VAGATextBox
            // 
            this.nOME_DA_VAGATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPREGOBindingSource, "NOME_DA_VAGA", true));
            this.nOME_DA_VAGATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nOME_DA_VAGATextBox.Location = new System.Drawing.Point(209, 115);
            this.nOME_DA_VAGATextBox.Name = "nOME_DA_VAGATextBox";
            this.nOME_DA_VAGATextBox.Size = new System.Drawing.Size(307, 21);
            this.nOME_DA_VAGATextBox.TabIndex = 1;
            // 
            // dATA_DA_VAGADateTimePicker
            // 
            this.dATA_DA_VAGADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eMPREGOBindingSource, "DATA_DA_VAGA", true));
            this.dATA_DA_VAGADateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dATA_DA_VAGADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dATA_DA_VAGADateTimePicker.Location = new System.Drawing.Point(208, 142);
            this.dATA_DA_VAGADateTimePicker.Name = "dATA_DA_VAGADateTimePicker";
            this.dATA_DA_VAGADateTimePicker.Size = new System.Drawing.Size(307, 21);
            this.dATA_DA_VAGADateTimePicker.TabIndex = 2;
            // 
            // hORARIO_DA_VAGAMaskedTextBox
            // 
            this.hORARIO_DA_VAGAMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPREGOBindingSource, "HORARIO_DA_VAGA", true));
            this.hORARIO_DA_VAGAMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.hORARIO_DA_VAGAMaskedTextBox.Location = new System.Drawing.Point(208, 168);
            this.hORARIO_DA_VAGAMaskedTextBox.Mask = "##:## às ##:##";
            this.hORARIO_DA_VAGAMaskedTextBox.Name = "hORARIO_DA_VAGAMaskedTextBox";
            this.hORARIO_DA_VAGAMaskedTextBox.Size = new System.Drawing.Size(307, 21);
            this.hORARIO_DA_VAGAMaskedTextBox.TabIndex = 3;
            // 
            // iNFO_DA_VAGARichTextBox
            // 
            this.iNFO_DA_VAGARichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPREGOBindingSource, "INFO_DA_VAGA", true));
            this.iNFO_DA_VAGARichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.iNFO_DA_VAGARichTextBox.Location = new System.Drawing.Point(208, 194);
            this.iNFO_DA_VAGARichTextBox.MaxLength = 200;
            this.iNFO_DA_VAGARichTextBox.Name = "iNFO_DA_VAGARichTextBox";
            this.iNFO_DA_VAGARichTextBox.Size = new System.Drawing.Size(307, 86);
            this.iNFO_DA_VAGARichTextBox.TabIndex = 4;
            this.iNFO_DA_VAGARichTextBox.Text = "";
            this.iNFO_DA_VAGARichTextBox.TextChanged += new System.EventHandler(this.iNFO_DA_VAGARichTextBox_TextChanged);
            // 
            // tELEFONEMaskedTextBox
            // 
            this.tELEFONEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPREGOBindingSource, "TELEFONE", true));
            this.tELEFONEMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tELEFONEMaskedTextBox.Location = new System.Drawing.Point(699, 116);
            this.tELEFONEMaskedTextBox.Mask = "(##)####-####";
            this.tELEFONEMaskedTextBox.Name = "tELEFONEMaskedTextBox";
            this.tELEFONEMaskedTextBox.Size = new System.Drawing.Size(311, 21);
            this.tELEFONEMaskedTextBox.TabIndex = 5;
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPREGOBindingSource, "EMAIL", true));
            this.eMAILTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eMAILTextBox.Location = new System.Drawing.Point(699, 142);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(311, 21);
            this.eMAILTextBox.TabIndex = 6;
            // 
            // cURSOBindingSource
            // 
            this.cURSOBindingSource.DataMember = "CURSO";
            this.cURSOBindingSource.DataSource = this.bD_DKSTDataSet;
            // 
            // grpVaga
            // 
            this.grpVaga.Controls.Add(this.lblInfo);
            this.grpVaga.Controls.Add(this.label6);
            this.grpVaga.Controls.Add(this.label5);
            this.grpVaga.Controls.Add(this.label4);
            this.grpVaga.Controls.Add(this.label3);
            this.grpVaga.Controls.Add(this.label2);
            this.grpVaga.Controls.Add(this.label1);
            this.grpVaga.Controls.Add(this.lblEmail);
            this.grpVaga.Controls.Add(this.lblTel);
            this.grpVaga.Controls.Add(this.lblHora);
            this.grpVaga.Controls.Add(this.lblData);
            this.grpVaga.Controls.Add(this.lblGerar);
            this.grpVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.grpVaga.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpVaga.Location = new System.Drawing.Point(48, 313);
            this.grpVaga.Name = "grpVaga";
            this.grpVaga.Size = new System.Drawing.Size(566, 302);
            this.grpVaga.TabIndex = 27;
            this.grpVaga.TabStop = false;
            this.grpVaga.Text = "VAGA";
            this.grpVaga.Enter += new System.EventHandler(this.grpVaga_Enter);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(158, 135);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(12, 15);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(295, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "EMAIL: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(61, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "TELEFONE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(63, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "DESCRIÇÃO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(274, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "HORÁRIO: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(69, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "DATA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "VAGA:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(357, 236);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(14, 17);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "-";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(157, 238);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(12, 15);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "-";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(357, 90);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(12, 15);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "-";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(131, 90);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(12, 15);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "-";
            // 
            // lblGerar
            // 
            this.lblGerar.AutoSize = true;
            this.lblGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblGerar.ForeColor = System.Drawing.Color.White;
            this.lblGerar.Location = new System.Drawing.Point(131, 43);
            this.lblGerar.Name = "lblGerar";
            this.lblGerar.Size = new System.Drawing.Size(12, 15);
            this.lblGerar.TabIndex = 0;
            this.lblGerar.Text = "-";
            // 
            // grpUsers
            // 
            this.grpUsers.Controls.Add(this.mEMBROSComboBox);
            this.grpUsers.Controls.Add(this.label7);
            this.grpUsers.Controls.Add(this.label12);
            this.grpUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.grpUsers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpUsers.Location = new System.Drawing.Point(646, 313);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Size = new System.Drawing.Size(364, 233);
            this.grpUsers.TabIndex = 28;
            this.grpUsers.TabStop = false;
            this.grpUsers.Text = "MEMBRO";
            // 
            // mEMBROSComboBox
            // 
            this.mEMBROSComboBox.DataSource = this.mEMBROSBindingSource;
            this.mEMBROSComboBox.DisplayMember = "NOME";
            this.mEMBROSComboBox.FormattingEnabled = true;
            this.mEMBROSComboBox.Location = new System.Drawing.Point(26, 126);
            this.mEMBROSComboBox.Name = "mEMBROSComboBox";
            this.mEMBROSComboBox.Size = new System.Drawing.Size(307, 32);
            this.mEMBROSComboBox.TabIndex = 7;
            this.mEMBROSComboBox.ValueMember = "Id_MEMBRO";
            // 
            // mEMBROSBindingSource
            // 
            this.mEMBROSBindingSource.DataMember = "MEMBROS";
            this.mEMBROSBindingSource.DataSource = this.bD_DKSTDataSet1;
            // 
            // bD_DKSTDataSet1
            // 
            this.bD_DKSTDataSet1.DataSetName = "BD_DKSTDataSet1";
            this.bD_DKSTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(333, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 81;
            this.label7.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(23, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "CPF Do Candidato:";
            // 
            // mEMBROSBindingSource2
            // 
            this.mEMBROSBindingSource2.DataMember = "MEMBROS";
            this.mEMBROSBindingSource2.DataSource = this.bD_DKSTDataSet1;
            // 
            // mEMBROSBindingSource1
            // 
            this.mEMBROSBindingSource1.DataMember = "MEMBROS";
            this.mEMBROSBindingSource1.DataSource = this.bD_DKSTDataSet1;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.MEMBROSTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Aplicação.BD_DKSTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VOLUNTARIADOSTableAdapter = null;
            // 
            // eMPREGOTableAdapter
            // 
            this.eMPREGOTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(160, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(160, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(160, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "*";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 643);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(1064, 20);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "Todos os Direitos Reservados 2020";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(206, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "Limete de 200 caracters";
            // 
            // frmEmpregos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 661);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(lblDescricao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grpUsers);
            this.Controls.Add(this.grpVaga);
            this.Controls.Add(nOME_DA_VAGALabel);
            this.Controls.Add(this.nOME_DA_VAGATextBox);
            this.Controls.Add(dATA_DA_VAGALabel);
            this.Controls.Add(this.dATA_DA_VAGADateTimePicker);
            this.Controls.Add(hORARIO_DA_VAGALabel);
            this.Controls.Add(this.hORARIO_DA_VAGAMaskedTextBox);
            this.Controls.Add(this.iNFO_DA_VAGARichTextBox);
            this.Controls.Add(tELEFONELabel);
            this.Controls.Add(this.tELEFONEMaskedTextBox);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.eMAILTextBox);
            this.Controls.Add(this.eMPREGOBindingNavigator);
            this.Controls.Add(this.voltarE);
            this.MaximizeBox = false;
            this.Name = "frmEmpregos";
            this.Text = "Empregos";
            this.Load += new System.EventHandler(this.frmEmprego_Load);
            this.voltarE.ResumeLayout(false);
            this.voltarE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DKSTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPREGOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPREGOBindingNavigator)).EndInit();
            this.eMPREGOBindingNavigator.ResumeLayout(false);
            this.eMPREGOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOBindingSource)).EndInit();
            this.grpVaga.ResumeLayout(false);
            this.grpVaga.PerformLayout();
            this.grpUsers.ResumeLayout(false);
            this.grpUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DKSTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBROSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBROSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip voltarE;
        private System.Windows.Forms.ToolStripMenuItem btnvoltar;
        private BD_DKSTDataSet bD_DKSTDataSet;
        private System.Windows.Forms.BindingSource eMPREGOBindingSource;
        private BD_DKSTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eMPREGOBindingNavigator;
        private System.Windows.Forms.ToolStripButton eMPREGOBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nOME_DA_VAGATextBox;
        private System.Windows.Forms.DateTimePicker dATA_DA_VAGADateTimePicker;
        private System.Windows.Forms.MaskedTextBox hORARIO_DA_VAGAMaskedTextBox;
        private System.Windows.Forms.RichTextBox iNFO_DA_VAGARichTextBox;
        private System.Windows.Forms.MaskedTextBox tELEFONEMaskedTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.ToolStripLabel lblRemover;
        private System.Windows.Forms.ToolStripLabel lblSalvar;
        private System.Windows.Forms.BindingSource cURSOBindingSource;
        private System.Windows.Forms.GroupBox grpVaga;
        private System.Windows.Forms.GroupBox grpUsers;
        private BD_DKSTDataSet1 bD_DKSTDataSet1;
        private System.Windows.Forms.BindingSource mEMBROSBindingSource;
        private BD_DKSTDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource mEMBROSBindingSource1;
        private BD_DKSTDataSetTableAdapters.EMPREGOTableAdapter eMPREGOTableAdapter;
        private System.Windows.Forms.Label lblGerar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource mEMBROSBindingSource2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripLabel lblVisualizar;
        private System.Windows.Forms.ToolStripButton add;
        private System.Windows.Forms.ToolStripButton remove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton ver;
        private System.Windows.Forms.ToolStripLabel lblNovo;
        private System.Windows.Forms.ComboBox mEMBROSComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label10;
    }
}