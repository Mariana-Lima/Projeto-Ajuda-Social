namespace Aplicação
{
    partial class frmCursos
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
            System.Windows.Forms.Label tIPO_DO_CURSOLabel;
            System.Windows.Forms.Label dATA_DO_CURSOLabel;
            System.Windows.Forms.Label hORARIO_DO_CURSOLabel;
            System.Windows.Forms.Label iNFO_DO_CURSOLabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label nOME_DO_CURSOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCursos));
            this.voltarC = new System.Windows.Forms.MenuStrip();
            this.vOLTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bD_DKSTDataSet1 = new Aplicação.BD_DKSTDataSet();
            this.cURSOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cURSOTableAdapter = new Aplicação.BD_DKSTDataSetTableAdapters.CURSOTableAdapter();
            this.tableAdapterManager1 = new Aplicação.BD_DKSTDataSetTableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpUsers = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mEMBROSComboBox = new System.Windows.Forms.ComboBox();
            this.grpCurso = new System.Windows.Forms.GroupBox();
            this.lblInfoC = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmailC = new System.Windows.Forms.Label();
            this.lblTelC = new System.Windows.Forms.Label();
            this.lblHoraC = new System.Windows.Forms.Label();
            this.lblDataC = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.eMPREGOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.add = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.remove = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ver = new System.Windows.Forms.ToolStripButton();
            this.lblVisualizar = new System.Windows.Forms.ToolStripLabel();
            this.gravar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.mskHora = new System.Windows.Forms.MaskedTextBox();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.ckEad = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ckPresencial = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            tIPO_DO_CURSOLabel = new System.Windows.Forms.Label();
            dATA_DO_CURSOLabel = new System.Windows.Forms.Label();
            hORARIO_DO_CURSOLabel = new System.Windows.Forms.Label();
            iNFO_DO_CURSOLabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            nOME_DO_CURSOLabel = new System.Windows.Forms.Label();
            this.voltarC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DKSTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOBindingSource1)).BeginInit();
            this.grpUsers.SuspendLayout();
            this.grpCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPREGOBindingNavigator)).BeginInit();
            this.eMPREGOBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tIPO_DO_CURSOLabel
            // 
            tIPO_DO_CURSOLabel.AutoSize = true;
            tIPO_DO_CURSOLabel.Location = new System.Drawing.Point(83, 101);
            tIPO_DO_CURSOLabel.Name = "tIPO_DO_CURSOLabel";
            tIPO_DO_CURSOLabel.Size = new System.Drawing.Size(95, 13);
            tIPO_DO_CURSOLabel.TabIndex = 55;
            tIPO_DO_CURSOLabel.Text = "TIPO DO CURSO:";
            // 
            // dATA_DO_CURSOLabel
            // 
            dATA_DO_CURSOLabel.AutoSize = true;
            dATA_DO_CURSOLabel.Location = new System.Drawing.Point(78, 156);
            dATA_DO_CURSOLabel.Name = "dATA_DO_CURSOLabel";
            dATA_DO_CURSOLabel.Size = new System.Drawing.Size(99, 13);
            dATA_DO_CURSOLabel.TabIndex = 59;
            dATA_DO_CURSOLabel.Text = "DATA DO CURSO:";
            dATA_DO_CURSOLabel.Click += new System.EventHandler(this.dATA_DO_CURSOLabel_Click);
            // 
            // hORARIO_DO_CURSOLabel
            // 
            hORARIO_DO_CURSOLabel.AutoSize = true;
            hORARIO_DO_CURSOLabel.Location = new System.Drawing.Point(57, 179);
            hORARIO_DO_CURSOLabel.Name = "hORARIO_DO_CURSOLabel";
            hORARIO_DO_CURSOLabel.Size = new System.Drawing.Size(120, 13);
            hORARIO_DO_CURSOLabel.TabIndex = 61;
            hORARIO_DO_CURSOLabel.Text = "HORARIO DO CURSO:";
            // 
            // iNFO_DO_CURSOLabel
            // 
            iNFO_DO_CURSOLabel.AutoSize = true;
            iNFO_DO_CURSOLabel.Location = new System.Drawing.Point(106, 204);
            iNFO_DO_CURSOLabel.Name = "iNFO_DO_CURSOLabel";
            iNFO_DO_CURSOLabel.Size = new System.Drawing.Size(72, 13);
            iNFO_DO_CURSOLabel.TabIndex = 63;
            iNFO_DO_CURSOLabel.Text = "DESCRIÇÃO:";
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Location = new System.Drawing.Point(622, 107);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(66, 13);
            tELEFONELabel.TabIndex = 65;
            tELEFONELabel.Text = "TELEFONE:";
            tELEFONELabel.Click += new System.EventHandler(this.tELEFONELabel_Click_1);
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(646, 133);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(42, 13);
            eMAILLabel.TabIndex = 67;
            eMAILLabel.Text = "EMAIL:";
            // 
            // nOME_DO_CURSOLabel
            // 
            nOME_DO_CURSOLabel.AutoSize = true;
            nOME_DO_CURSOLabel.Location = new System.Drawing.Point(78, 129);
            nOME_DO_CURSOLabel.Name = "nOME_DO_CURSOLabel";
            nOME_DO_CURSOLabel.Size = new System.Drawing.Size(102, 13);
            nOME_DO_CURSOLabel.TabIndex = 72;
            nOME_DO_CURSOLabel.Text = "NOME DO CURSO:";
            // 
            // voltarC
            // 
            this.voltarC.BackColor = System.Drawing.Color.Gray;
            this.voltarC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.voltarC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vOLTARToolStripMenuItem});
            this.voltarC.Location = new System.Drawing.Point(0, 0);
            this.voltarC.Name = "voltarC";
            this.voltarC.Size = new System.Drawing.Size(1084, 29);
            this.voltarC.TabIndex = 52;
            this.voltarC.Text = "menu";
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
            this.bD_DKSTDataSet1.DataSetName = "BD_DKSTDataSet";
            this.bD_DKSTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cURSOBindingSource1
            // 
            this.cURSOBindingSource1.DataMember = "CURSO";
            this.cURSOBindingSource1.DataSource = this.bD_DKSTDataSet1;
            // 
            // cURSOTableAdapter
            // 
            this.cURSOTableAdapter.ClearBeforeFill = true;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 643);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(1084, 20);
            this.textBox1.TabIndex = 69;
            this.textBox1.Text = "Todos os Direitos Reservados 2020";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpUsers
            // 
            this.grpUsers.Controls.Add(this.label13);
            this.grpUsers.Controls.Add(this.label12);
            this.grpUsers.Controls.Add(this.mEMBROSComboBox);
            this.grpUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.grpUsers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpUsers.Location = new System.Drawing.Point(650, 317);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Size = new System.Drawing.Size(364, 233);
            this.grpUsers.TabIndex = 71;
            this.grpUsers.TabStop = false;
            this.grpUsers.Text = "MEMBRO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(333, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 17);
            this.label13.TabIndex = 85;
            this.label13.Text = "*";
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
            this.mEMBROSComboBox.TabIndex = 9;
            this.mEMBROSComboBox.ValueMember = "Id_MEMBRO";
            // 
            // grpCurso
            // 
            this.grpCurso.Controls.Add(this.lblInfoC);
            this.grpCurso.Controls.Add(this.lblModalidade);
            this.grpCurso.Controls.Add(this.label7);
            this.grpCurso.Controls.Add(this.label6);
            this.grpCurso.Controls.Add(this.label5);
            this.grpCurso.Controls.Add(this.label4);
            this.grpCurso.Controls.Add(this.label3);
            this.grpCurso.Controls.Add(this.label2);
            this.grpCurso.Controls.Add(this.label1);
            this.grpCurso.Controls.Add(this.lblEmailC);
            this.grpCurso.Controls.Add(this.lblTelC);
            this.grpCurso.Controls.Add(this.lblHoraC);
            this.grpCurso.Controls.Add(this.lblDataC);
            this.grpCurso.Controls.Add(this.lblCurso);
            this.grpCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.grpCurso.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpCurso.Location = new System.Drawing.Point(52, 317);
            this.grpCurso.Name = "grpCurso";
            this.grpCurso.Size = new System.Drawing.Size(566, 302);
            this.grpCurso.TabIndex = 70;
            this.grpCurso.TabStop = false;
            this.grpCurso.Text = "CURSO";
            this.grpCurso.Enter += new System.EventHandler(this.grpCurso_Enter);
            // 
            // lblInfoC
            // 
            this.lblInfoC.AutoSize = true;
            this.lblInfoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoC.ForeColor = System.Drawing.Color.White;
            this.lblInfoC.Location = new System.Drawing.Point(155, 177);
            this.lblInfoC.Name = "lblInfoC";
            this.lblInfoC.Size = new System.Drawing.Size(12, 15);
            this.lblInfoC.TabIndex = 15;
            this.lblInfoC.Text = "-";
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblModalidade.ForeColor = System.Drawing.Color.White;
            this.lblModalidade.Location = new System.Drawing.Point(170, 44);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(12, 15);
            this.lblModalidade.TabIndex = 14;
            this.lblModalidade.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(57, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "MODALIDADE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(291, 260);
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
            this.label5.Location = new System.Drawing.Point(57, 260);
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
            this.label4.Location = new System.Drawing.Point(59, 177);
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
            this.label3.Location = new System.Drawing.Point(270, 134);
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
            this.label2.Location = new System.Drawing.Point(65, 132);
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
            this.label1.Location = new System.Drawing.Point(57, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "CURSO:";
            // 
            // lblEmailC
            // 
            this.lblEmailC.AutoSize = true;
            this.lblEmailC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmailC.ForeColor = System.Drawing.Color.White;
            this.lblEmailC.Location = new System.Drawing.Point(351, 258);
            this.lblEmailC.Name = "lblEmailC";
            this.lblEmailC.Size = new System.Drawing.Size(14, 17);
            this.lblEmailC.TabIndex = 5;
            this.lblEmailC.Text = "-";
            // 
            // lblTelC
            // 
            this.lblTelC.AutoSize = true;
            this.lblTelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelC.ForeColor = System.Drawing.Color.White;
            this.lblTelC.Location = new System.Drawing.Point(153, 262);
            this.lblTelC.Name = "lblTelC";
            this.lblTelC.Size = new System.Drawing.Size(12, 15);
            this.lblTelC.TabIndex = 4;
            this.lblTelC.Text = "-";
            // 
            // lblHoraC
            // 
            this.lblHoraC.AutoSize = true;
            this.lblHoraC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblHoraC.ForeColor = System.Drawing.Color.White;
            this.lblHoraC.Location = new System.Drawing.Point(353, 134);
            this.lblHoraC.Name = "lblHoraC";
            this.lblHoraC.Size = new System.Drawing.Size(12, 15);
            this.lblHoraC.TabIndex = 2;
            this.lblHoraC.Text = "-";
            // 
            // lblDataC
            // 
            this.lblDataC.AutoSize = true;
            this.lblDataC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDataC.ForeColor = System.Drawing.Color.White;
            this.lblDataC.Location = new System.Drawing.Point(127, 132);
            this.lblDataC.Name = "lblDataC";
            this.lblDataC.Size = new System.Drawing.Size(12, 15);
            this.lblDataC.TabIndex = 1;
            this.lblDataC.Text = "-";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCurso.ForeColor = System.Drawing.Color.White;
            this.lblCurso.Location = new System.Drawing.Point(127, 85);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(12, 15);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "-";
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
            this.toolStripLabel3,
            this.remove,
            this.toolStripLabel2,
            this.ver,
            this.lblVisualizar,
            this.gravar,
            this.toolStripLabel1});
            this.eMPREGOBindingNavigator.Location = new System.Drawing.Point(0, 29);
            this.eMPREGOBindingNavigator.MoveFirstItem = null;
            this.eMPREGOBindingNavigator.MoveLastItem = null;
            this.eMPREGOBindingNavigator.MoveNextItem = null;
            this.eMPREGOBindingNavigator.MovePreviousItem = null;
            this.eMPREGOBindingNavigator.Name = "eMPREGOBindingNavigator";
            this.eMPREGOBindingNavigator.PositionItem = null;
            this.eMPREGOBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.eMPREGOBindingNavigator.Size = new System.Drawing.Size(1084, 25);
            this.eMPREGOBindingNavigator.TabIndex = 72;
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
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel3.Text = "Novo";
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel2.Text = "Remover";
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
            // gravar
            // 
            this.gravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gravar.Image = ((System.Drawing.Image)(resources.GetObject("gravar.Image")));
            this.gravar.Name = "gravar";
            this.gravar.Size = new System.Drawing.Size(23, 22);
            this.gravar.Text = "Salvar Dados";
            this.gravar.Click += new System.EventHandler(this.gravar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel1.Text = "Gravar";
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Location = new System.Drawing.Point(231, 122);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(294, 20);
            this.txtNomeCurso.TabIndex = 3;
            // 
            // mskHora
            // 
            this.mskHora.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cURSOBindingSource1, "HORARIO_DO_CURSO", true));
            this.mskHora.Location = new System.Drawing.Point(231, 181);
            this.mskHora.Mask = "##:## às ##:##";
            this.mskHora.Name = "mskHora";
            this.mskHora.Size = new System.Drawing.Size(292, 20);
            this.mskHora.TabIndex = 5;
            // 
            // txtInfo
            // 
            this.txtInfo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cURSOBindingSource1, "INFO_DO_CURSO", true));
            this.txtInfo.Location = new System.Drawing.Point(229, 215);
            this.txtInfo.MaxLength = 200;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(294, 75);
            this.txtInfo.TabIndex = 6;
            this.txtInfo.Text = "";
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // mskTel
            // 
            this.mskTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cURSOBindingSource1, "TELEFONE", true));
            this.mskTel.Location = new System.Drawing.Point(694, 101);
            this.mskTel.Mask = "(##)####-####";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(294, 20);
            this.mskTel.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cURSOBindingSource1, "EMAIL", true));
            this.txtEmail.Location = new System.Drawing.Point(694, 127);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // Data
            // 
            this.Data.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cURSOBindingSource1, "DATA_DO_CURSO", true));
            this.Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Data.Location = new System.Drawing.Point(229, 150);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(294, 20);
            this.Data.TabIndex = 4;
            this.Data.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ckEad
            // 
            this.ckEad.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cURSOBindingSource1, "TIPO_DO_CURSO", true));
            this.ckEad.Location = new System.Drawing.Point(365, 92);
            this.ckEad.Name = "ckEad";
            this.ckEad.Size = new System.Drawing.Size(160, 24);
            this.ckEad.TabIndex = 2;
            this.ckEad.Text = "EAD";
            this.ckEad.UseVisualStyleBackColor = true;
            this.ckEad.CheckedChanged += new System.EventHandler(this.ckEad_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(184, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 17);
            this.label11.TabIndex = 83;
            this.label11.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(184, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 81;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(184, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "*";
            // 
            // ckPresencial
            // 
            this.ckPresencial.AutoSize = true;
            this.ckPresencial.Location = new System.Drawing.Point(231, 97);
            this.ckPresencial.Name = "ckPresencial";
            this.ckPresencial.Size = new System.Drawing.Size(93, 17);
            this.ckPresencial.TabIndex = 1;
            this.ckPresencial.Text = "PRESENCIAL";
            this.ckPresencial.UseVisualStyleBackColor = true;
            this.ckPresencial.CheckedChanged += new System.EventHandler(this.ckPresencial_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(184, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 17);
            this.label14.TabIndex = 86;
            this.label14.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(226, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "Limete de 200 caracters";
            // 
            // frmCursos
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ckPresencial);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.mskHora);
            this.Controls.Add(this.txtNomeCurso);
            this.Controls.Add(nOME_DO_CURSOLabel);
            this.Controls.Add(this.eMPREGOBindingNavigator);
            this.Controls.Add(this.grpUsers);
            this.Controls.Add(this.grpCurso);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(tIPO_DO_CURSOLabel);
            this.Controls.Add(this.ckEad);
            this.Controls.Add(dATA_DO_CURSOLabel);
            this.Controls.Add(hORARIO_DO_CURSOLabel);
            this.Controls.Add(iNFO_DO_CURSOLabel);
            this.Controls.Add(tELEFONELabel);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.voltarC);
            this.MaximizeBox = false;
            this.Name = "frmCursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.frmCursos_Load);
            this.voltarC.ResumeLayout(false);
            this.voltarC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DKSTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOBindingSource1)).EndInit();
            this.grpUsers.ResumeLayout(false);
            this.grpUsers.PerformLayout();
            this.grpCurso.ResumeLayout(false);
            this.grpCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPREGOBindingNavigator)).EndInit();
            this.eMPREGOBindingNavigator.ResumeLayout(false);
            this.eMPREGOBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip voltar;
        private System.Windows.Forms.ToolStripMenuItem btnvoltar;
        private BD_DKSTDataSet bD_DKSTDataSet;
        private System.Windows.Forms.BindingSource cURSOBindingSource;
        private BD_DKSTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dATA_DO_CURSODateTimePicker;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox qUANTIDADE_DE_VAGASTextBox;
        private System.Windows.Forms.CheckBox sITUACAO_DE_BAIXA_RENDACheckBox;
        private System.Windows.Forms.DataGridView cURSODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton cURSOBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator cURSOBindingNavigator;
        private System.Windows.Forms.MaskedTextBox tELEFONEMaskedTextBox;
        private System.Windows.Forms.RichTextBox iNFO_DO_CURSORichTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripLabel lblAdicionar;
        private System.Windows.Forms.ToolStripLabel lblRemover;
        private System.Windows.Forms.ToolStripLabel lblSalvar;
        private System.Windows.Forms.MaskedTextBox hORARIO_DO_CURSOMaskedTextBox;
        private System.Windows.Forms.CheckBox tIPO_DO_CURSOCheckBox;
        private System.Windows.Forms.TextBox nOME_DO_CURSOTextBox;
        private System.Windows.Forms.MenuStrip voltarC;
        private System.Windows.Forms.ToolStripMenuItem vOLTARToolStripMenuItem;
        private BD_DKSTDataSet bD_DKSTDataSet1;
        private System.Windows.Forms.BindingSource cURSOBindingSource1;
        private BD_DKSTDataSetTableAdapters.CURSOTableAdapter cURSOTableAdapter;
        private BD_DKSTDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpUsers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox mEMBROSComboBox;
        private System.Windows.Forms.GroupBox grpCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmailC;
        private System.Windows.Forms.Label lblTelC;
        private System.Windows.Forms.Label lblHoraC;
        private System.Windows.Forms.Label lblDataC;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.BindingNavigator eMPREGOBindingNavigator;
        private System.Windows.Forms.ToolStripButton add;
        private System.Windows.Forms.ToolStripButton remove;
        private System.Windows.Forms.ToolStripLabel lblVisualizar;
        private System.Windows.Forms.ToolStripButton gravar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton ver;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.MaskedTextBox mskHora;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.CheckBox ckEad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox ckPresencial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblInfoC;
        private System.Windows.Forms.Label label10;
    }
}