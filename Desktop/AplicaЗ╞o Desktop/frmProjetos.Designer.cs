namespace Aplicação
{
    partial class frmProjetos
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
            System.Windows.Forms.Label nOME_DO_PROJETOLabel;
            System.Windows.Forms.Label dATA_DO_PROJETOLabel;
            System.Windows.Forms.Label hORARIO_DO_PROJETOLabel;
            System.Windows.Forms.Label iNFO_DO_PROJETOLabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label eMAILLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjetos));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.voltarP = new System.Windows.Forms.MenuStrip();
            this.vOLTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROJETOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD_DKSTDataSet1 = new Aplicação.BD_DKSTDataSet();
            this.pROJETOTableAdapter1 = new Aplicação.BD_DKSTDataSetTableAdapters.PROJETOTableAdapter();
            this.tableAdapterManager1 = new Aplicação.BD_DKSTDataSetTableAdapters.TableAdapterManager();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpUsers = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mEMBROSComboBox = new System.Windows.Forms.ComboBox();
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
            this.eMPREGOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.add = new System.Windows.Forms.ToolStripButton();
            this.lblAdicionar = new System.Windows.Forms.ToolStripLabel();
            this.remove = new System.Windows.Forms.ToolStripButton();
            this.lblRemover = new System.Windows.Forms.ToolStripLabel();
            this.verP = new System.Windows.Forms.ToolStripButton();
            this.lblVisualizar = new System.Windows.Forms.ToolStripLabel();
            this.eMPREGOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lblSalvar = new System.Windows.Forms.ToolStripLabel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.mskHora = new System.Windows.Forms.MaskedTextBox();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            nOME_DO_PROJETOLabel = new System.Windows.Forms.Label();
            dATA_DO_PROJETOLabel = new System.Windows.Forms.Label();
            hORARIO_DO_PROJETOLabel = new System.Windows.Forms.Label();
            iNFO_DO_PROJETOLabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            this.voltarP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DKSTDataSet1)).BeginInit();
            this.grpUsers.SuspendLayout();
            this.grpVaga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPREGOBindingNavigator)).BeginInit();
            this.eMPREGOBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nOME_DO_PROJETOLabel
            // 
            nOME_DO_PROJETOLabel.AutoSize = true;
            nOME_DO_PROJETOLabel.Location = new System.Drawing.Point(83, 109);
            nOME_DO_PROJETOLabel.Name = "nOME_DO_PROJETOLabel";
            nOME_DO_PROJETOLabel.Size = new System.Drawing.Size(114, 13);
            nOME_DO_PROJETOLabel.TabIndex = 54;
            nOME_DO_PROJETOLabel.Text = "NOME DO PROJETO:";
            // 
            // dATA_DO_PROJETOLabel
            // 
            dATA_DO_PROJETOLabel.AutoSize = true;
            dATA_DO_PROJETOLabel.Location = new System.Drawing.Point(86, 135);
            dATA_DO_PROJETOLabel.Name = "dATA_DO_PROJETOLabel";
            dATA_DO_PROJETOLabel.Size = new System.Drawing.Size(111, 13);
            dATA_DO_PROJETOLabel.TabIndex = 56;
            dATA_DO_PROJETOLabel.Text = "DATA DO PROJETO:";
            // 
            // hORARIO_DO_PROJETOLabel
            // 
            hORARIO_DO_PROJETOLabel.AutoSize = true;
            hORARIO_DO_PROJETOLabel.Location = new System.Drawing.Point(65, 161);
            hORARIO_DO_PROJETOLabel.Name = "hORARIO_DO_PROJETOLabel";
            hORARIO_DO_PROJETOLabel.Size = new System.Drawing.Size(132, 13);
            hORARIO_DO_PROJETOLabel.TabIndex = 58;
            hORARIO_DO_PROJETOLabel.Text = "HORARIO DO PROJETO:";
            // 
            // iNFO_DO_PROJETOLabel
            // 
            iNFO_DO_PROJETOLabel.AutoSize = true;
            iNFO_DO_PROJETOLabel.Location = new System.Drawing.Point(122, 189);
            iNFO_DO_PROJETOLabel.Name = "iNFO_DO_PROJETOLabel";
            iNFO_DO_PROJETOLabel.Size = new System.Drawing.Size(72, 13);
            iNFO_DO_PROJETOLabel.TabIndex = 60;
            iNFO_DO_PROJETOLabel.Text = "DESCRIÇÃO:";
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Location = new System.Drawing.Point(632, 106);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(66, 13);
            tELEFONELabel.TabIndex = 62;
            tELEFONELabel.Text = "TELEFONE:";
            tELEFONELabel.Click += new System.EventHandler(this.tELEFONELabel_Click);
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(656, 132);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(42, 13);
            eMAILLabel.TabIndex = 64;
            eMAILLabel.Text = "EMAIL:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.voltarP.TabIndex = 51;
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
            // pROJETOBindingSource1
            // 
            this.pROJETOBindingSource1.DataMember = "PROJETO";
            this.pROJETOBindingSource1.DataSource = this.bD_DKSTDataSet1;
            // 
            // bD_DKSTDataSet1
            // 
            this.bD_DKSTDataSet1.DataSetName = "BD_DKSTDataSet";
            this.bD_DKSTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJETOTableAdapter1
            // 
            this.pROJETOTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.CURSOTableAdapter = null;
            this.tableAdapterManager1.EMPREGOTableAdapter = null;
            this.tableAdapterManager1.OFICINATableAdapter = null;
            this.tableAdapterManager1.PROJETOTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Aplicação.BD_DKSTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(0, 644);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1064, 20);
            this.textBox2.TabIndex = 66;
            this.textBox2.Text = "Todos os Direitos Reservados 2020";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpUsers
            // 
            this.grpUsers.Controls.Add(this.label7);
            this.grpUsers.Controls.Add(this.label12);
            this.grpUsers.Controls.Add(this.mEMBROSComboBox);
            this.grpUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.grpUsers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpUsers.Location = new System.Drawing.Point(651, 308);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Size = new System.Drawing.Size(364, 233);
            this.grpUsers.TabIndex = 68;
            this.grpUsers.TabStop = false;
            this.grpUsers.Text = "MEMBRO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(333, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 80;
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
            // mEMBROSComboBox
            // 
            this.mEMBROSComboBox.DisplayMember = "NOME";
            this.mEMBROSComboBox.FormattingEnabled = true;
            this.mEMBROSComboBox.Location = new System.Drawing.Point(26, 118);
            this.mEMBROSComboBox.Name = "mEMBROSComboBox";
            this.mEMBROSComboBox.Size = new System.Drawing.Size(307, 32);
            this.mEMBROSComboBox.TabIndex = 7;
            this.mEMBROSComboBox.ValueMember = "Id_MEMBRO";
            this.mEMBROSComboBox.SelectedIndexChanged += new System.EventHandler(this.mEMBROSComboBox_SelectedIndexChanged);
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
            this.grpVaga.Enabled = false;
            this.grpVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.grpVaga.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpVaga.Location = new System.Drawing.Point(53, 308);
            this.grpVaga.Name = "grpVaga";
            this.grpVaga.Size = new System.Drawing.Size(566, 302);
            this.grpVaga.TabIndex = 67;
            this.grpVaga.TabStop = false;
            this.grpVaga.Text = "PROJETO";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(157, 135);
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
            this.label6.Location = new System.Drawing.Point(295, 239);
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
            this.label5.Location = new System.Drawing.Point(61, 239);
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
            this.label1.Location = new System.Drawing.Point(61, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "PROJETO:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(357, 239);
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
            this.lblTel.Location = new System.Drawing.Point(157, 241);
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
            this.lblGerar.Location = new System.Drawing.Point(140, 43);
            this.lblGerar.Name = "lblGerar";
            this.lblGerar.Size = new System.Drawing.Size(12, 15);
            this.lblGerar.TabIndex = 0;
            this.lblGerar.Text = "-";
            // 
            // eMPREGOBindingNavigator
            // 
            this.eMPREGOBindingNavigator.AddNewItem = null;
            this.eMPREGOBindingNavigator.BackColor = System.Drawing.SystemColors.Control;
            this.eMPREGOBindingNavigator.CountItem = null;
            this.eMPREGOBindingNavigator.DeleteItem = null;
            this.eMPREGOBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.eMPREGOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.lblAdicionar,
            this.remove,
            this.lblRemover,
            this.verP,
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
            this.eMPREGOBindingNavigator.TabIndex = 69;
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
            // lblAdicionar
            // 
            this.lblAdicionar.Name = "lblAdicionar";
            this.lblAdicionar.Size = new System.Drawing.Size(36, 22);
            this.lblAdicionar.Text = "Novo";
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
            // verP
            // 
            this.verP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.verP.Image = ((System.Drawing.Image)(resources.GetObject("verP.Image")));
            this.verP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.verP.Name = "verP";
            this.verP.Size = new System.Drawing.Size(23, 22);
            this.verP.Text = "toolStripButton1";
            this.verP.Click += new System.EventHandler(this.verP_Click);
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
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJETOBindingSource1, "NOME_DO_PROJETO", true));
            this.txtNome.Location = new System.Drawing.Point(228, 103);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(280, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // Data
            // 
            this.Data.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pROJETOBindingSource1, "DATA_DO_PROJETO", true));
            this.Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Data.Location = new System.Drawing.Point(228, 129);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(280, 20);
            this.Data.TabIndex = 2;
            this.Data.ValueChanged += new System.EventHandler(this.Data_ValueChanged);
            // 
            // mskHora
            // 
            this.mskHora.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJETOBindingSource1, "HORARIO_DO_PROJETO", true));
            this.mskHora.Location = new System.Drawing.Point(228, 154);
            this.mskHora.Mask = "##:## às ##:##";
            this.mskHora.Name = "mskHora";
            this.mskHora.Size = new System.Drawing.Size(280, 20);
            this.mskHora.TabIndex = 3;
            // 
            // txtInfo
            // 
            this.txtInfo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJETOBindingSource1, "INFO_DO_PROJETO", true));
            this.txtInfo.Location = new System.Drawing.Point(228, 189);
            this.txtInfo.MaxLength = 200;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(280, 83);
            this.txtInfo.TabIndex = 4;
            this.txtInfo.Text = "";
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // mskTel
            // 
            this.mskTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJETOBindingSource1, "TELEFONE", true));
            this.mskTel.Location = new System.Drawing.Point(723, 99);
            this.mskTel.Mask = "(##)####-####";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(280, 20);
            this.mskTel.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJETOBindingSource1, "EMAIL", true));
            this.txtEmail.Location = new System.Drawing.Point(723, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(203, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 17);
            this.label11.TabIndex = 79;
            this.label11.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(203, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 77;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(203, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 17);
            this.label8.TabIndex = 76;
            this.label8.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(225, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "Limete de 200 caracters";
            // 
            // frmProjetos
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 661);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.mskHora);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.eMPREGOBindingNavigator);
            this.Controls.Add(this.grpUsers);
            this.Controls.Add(this.grpVaga);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(nOME_DO_PROJETOLabel);
            this.Controls.Add(dATA_DO_PROJETOLabel);
            this.Controls.Add(hORARIO_DO_PROJETOLabel);
            this.Controls.Add(iNFO_DO_PROJETOLabel);
            this.Controls.Add(tELEFONELabel);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.voltarP);
            this.MainMenuStrip = this.voltarP;
            this.MaximizeBox = false;
            this.Name = "frmProjetos";
            this.Text = "Projetos";
            this.Load += new System.EventHandler(this.frmProjetos_Load_1);
            this.voltarP.ResumeLayout(false);
            this.voltarP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DKSTDataSet1)).EndInit();
            this.grpUsers.ResumeLayout(false);
            this.grpUsers.PerformLayout();
            this.grpVaga.ResumeLayout(false);
            this.grpVaga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPREGOBindingNavigator)).EndInit();
            this.eMPREGOBindingNavigator.ResumeLayout(false);
            this.eMPREGOBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip voltar;
        private System.Windows.Forms.ToolStripMenuItem btnvoltar;
        private BD_DKSTDataSet bD_DKSTDataSet;
        private System.Windows.Forms.BindingSource pROJETOBindingSource;
        private BD_DKSTDataSetTableAdapters.PROJETOTableAdapter pROJETOTableAdapter;
        private BD_DKSTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pROJETOBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pROJETOBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nOME_DO_PROJETOTextBox;
        private System.Windows.Forms.DateTimePicker dATA_DO_PROJETODateTimePicker;
        private System.Windows.Forms.TextBox hORARIO_DO_PROJETOTextBox;
        private System.Windows.Forms.TextBox iNFO_DO_PROJETOTextBox;
        private System.Windows.Forms.TextBox tELEFONETextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox qUANTIDADE_DE_VAGASTextBox;
        private System.Windows.Forms.CheckBox sITUACAO_DE_BAIXA_RENDACheckBox;
        private System.Windows.Forms.DataGridView pROJETODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox id_PROJETOTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip voltarP;
        private System.Windows.Forms.ToolStripMenuItem vOLTARToolStripMenuItem;
        private BD_DKSTDataSet bD_DKSTDataSet1;
        private System.Windows.Forms.BindingSource pROJETOBindingSource1;
        private BD_DKSTDataSetTableAdapters.PROJETOTableAdapter pROJETOTableAdapter1;
        private BD_DKSTDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox grpUsers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox mEMBROSComboBox;
        private System.Windows.Forms.GroupBox grpVaga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblGerar;
        private System.Windows.Forms.BindingNavigator eMPREGOBindingNavigator;
        private System.Windows.Forms.ToolStripButton add;
        private System.Windows.Forms.ToolStripLabel lblAdicionar;
        private System.Windows.Forms.ToolStripButton remove;
        private System.Windows.Forms.ToolStripLabel lblRemover;
        private System.Windows.Forms.ToolStripButton verP;
        private System.Windows.Forms.ToolStripLabel lblVisualizar;
        private System.Windows.Forms.ToolStripButton eMPREGOBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel lblSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.MaskedTextBox mskHora;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label10;
    }
}