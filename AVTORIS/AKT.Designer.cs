namespace AVTORIS
{
    partial class AKT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AKT));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_AKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_AKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dOGOVORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ladeaDataSet1 = new global::AVTORIS.LadeaDataSet1();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dOGOVORTableAdapter = new global::AVTORIS.LadeaDataSet1TableAdapters.DOGOVORTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Id_AKT_JOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_J = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.jOBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ladeaDataSet2 = new global::AVTORIS.LadeaDataSet2();
            this.jOBTableAdapter = new global::AVTORIS.LadeaDataSet2TableAdapters.JOBTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.sOTRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ladeaDataSet3 = new global::AVTORIS.LadeaDataSet3();
            this.sOTRTableAdapter = new global::AVTORIS.LadeaDataSet3TableAdapters.SOTRTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Id_AKT_DET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dETALIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ladeaDataSet5 = new global::AVTORIS.LadeaDataSet5();
            this.label6 = new System.Windows.Forms.Label();
            this.dETALITableAdapter = new global::AVTORIS.LadeaDataSet5TableAdapters.DETALITableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOGOVORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladeaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladeaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOTRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladeaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETALIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladeaDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_AKT,
            this.DATE_AKT,
            this.id_DV});
            this.dataGridView1.Location = new System.Drawing.Point(2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_AKT
            // 
            this.id_AKT.HeaderText = "Номер акта";
            this.id_AKT.Name = "id_AKT";
            // 
            // DATE_AKT
            // 
            this.DATE_AKT.HeaderText = "Дата акта";
            this.DATE_AKT.Name = "DATE_AKT";
            this.DATE_AKT.Width = 150;
            // 
            // id_DV
            // 
            this.id_DV.HeaderText = "Номер договора";
            this.id_DV.Name = "id_DV";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(322, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Договор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Дата акта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "№ Акта";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Номер договора";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(212, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 33);
            this.button3.TabIndex = 15;
            this.button3.Text = "Удалить АКТ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(113, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Изменить АКТ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(12, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 33);
            this.button4.TabIndex = 13;
            this.button4.Text = "Добавить АКТ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DataSource = this.dOGOVORBindingSource;
            this.comboBox1.DisplayMember = "Id_DV";
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 374);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 31);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "Id_DV";
            // 
            // dOGOVORBindingSource
            // 
            this.dOGOVORBindingSource.DataMember = "DOGOVOR";
            this.dOGOVORBindingSource.DataSource = this.ladeaDataSet1;
            // 
            // ladeaDataSet1
            // 
            this.ladeaDataSet1.DataSetName = "LadeaDataSet1";
            this.ladeaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(243, 333);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dOGOVORTableAdapter
            // 
            this.dOGOVORTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_AKT_JOB,
            this.Id_J,
            this.PRICE,
            this.Id_S});
            this.dataGridView2.Location = new System.Drawing.Point(443, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(575, 159);
            this.dataGridView2.TabIndex = 20;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Id_AKT_JOB
            // 
            this.Id_AKT_JOB.HeaderText = "Номер  работы";
            this.Id_AKT_JOB.Name = "Id_AKT_JOB";
            // 
            // Id_J
            // 
            this.Id_J.HeaderText = "Наименование работы";
            this.Id_J.Name = "Id_J";
            this.Id_J.Width = 150;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "Стоимость (руб)";
            this.PRICE.Name = "PRICE";
            // 
            // Id_S
            // 
            this.Id_S.HeaderText = "ФИО сотрудника";
            this.Id_S.Name = "Id_S";
            this.Id_S.Width = 180;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(443, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 27);
            this.button5.TabIndex = 21;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(541, 176);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 27);
            this.button6.TabIndex = 22;
            this.button6.Text = "Изменить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(657, 175);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 28);
            this.button7.TabIndex = 23;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(918, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(815, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Номер акта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(440, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Наименование Работы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(831, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "ФИО сотрудника";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.jOBBindingSource;
            this.comboBox2.DisplayMember = "NAME";
            this.comboBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(621, 212);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(204, 31);
            this.comboBox2.TabIndex = 32;
            this.comboBox2.ValueMember = "Id_J";
            // 
            // jOBBindingSource
            // 
            this.jOBBindingSource.DataMember = "JOB";
            this.jOBBindingSource.DataSource = this.ladeaDataSet2;
            // 
            // ladeaDataSet2
            // 
            this.ladeaDataSet2.DataSetName = "LadeaDataSet2";
            this.ladeaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jOBTableAdapter
            // 
            this.jOBTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox3.DataSource = this.sOTRBindingSource;
            this.comboBox3.DisplayMember = "FIO";
            this.comboBox3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(974, 212);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(195, 23);
            this.comboBox3.TabIndex = 33;
            this.comboBox3.ValueMember = "Id_S";
            // 
            // sOTRBindingSource
            // 
            this.sOTRBindingSource.DataMember = "SOTR";
            this.sOTRBindingSource.DataSource = this.ladeaDataSet3;
            // 
            // ladeaDataSet3
            // 
            this.ladeaDataSet3.DataSetName = "LadeaDataSet3";
            this.ladeaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sOTRTableAdapter
            // 
            this.sOTRTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_AKT_DET,
            this.Id_DT,
            this.PRICE_D});
            this.dataGridView3.Location = new System.Drawing.Point(452, 254);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(566, 150);
            this.dataGridView3.TabIndex = 34;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // Id_AKT_DET
            // 
            this.Id_AKT_DET.HeaderText = "Номер детали";
            this.Id_AKT_DET.Name = "Id_AKT_DET";
            // 
            // Id_DT
            // 
            this.Id_DT.HeaderText = "Наименование детали";
            this.Id_DT.Name = "Id_DT";
            this.Id_DT.Width = 260;
            // 
            // PRICE_D
            // 
            this.PRICE_D.HeaderText = "Цена (руб.)";
            this.PRICE_D.Name = "PRICE_D";
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(442, 415);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 33);
            this.button8.TabIndex = 35;
            this.button8.Text = "Добавить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(552, 415);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 33);
            this.button9.TabIndex = 36;
            this.button9.Text = "Изменить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(657, 415);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 33);
            this.button10.TabIndex = 37;
            this.button10.Text = "Удалить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox4.DataSource = this.dETALIBindingSource;
            this.comboBox4.DisplayMember = "NAME";
            this.comboBox4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(625, 453);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(204, 31);
            this.comboBox4.TabIndex = 39;
            this.comboBox4.ValueMember = "Id_DT";
            // 
            // dETALIBindingSource
            // 
            this.dETALIBindingSource.DataMember = "DETALI";
            this.dETALIBindingSource.DataSource = this.ladeaDataSet5;
            // 
            // ladeaDataSet5
            // 
            this.ladeaDataSet5.DataSetName = "LadeaDataSet5";
            this.ladeaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(440, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "Наименование детали";
            // 
            // dETALITableAdapter
            // 
            this.dETALITableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(953, 428);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 38;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // AKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 514);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AKT";
            this.Text = "AKT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AKT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOGOVORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladeaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladeaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOTRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladeaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETALIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladeaDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_AKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_AKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_DV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private LadeaDataSet1 ladeaDataSet1;
        private System.Windows.Forms.BindingSource dOGOVORBindingSource;
        private LadeaDataSet1TableAdapters.DOGOVORTableAdapter dOGOVORTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private LadeaDataSet2 ladeaDataSet2;
        private System.Windows.Forms.BindingSource jOBBindingSource;
        private LadeaDataSet2TableAdapters.JOBTableAdapter jOBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AKT_JOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_J;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_S;
        private System.Windows.Forms.ComboBox comboBox3;
        private LadeaDataSet3 ladeaDataSet3;
        private System.Windows.Forms.BindingSource sOTRBindingSource;
        private LadeaDataSet3TableAdapters.SOTRTableAdapter sOTRTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AKT_DET;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_DT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE_D;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private LadeaDataSet5 ladeaDataSet5;
        private System.Windows.Forms.BindingSource dETALIBindingSource;
        private LadeaDataSet5TableAdapters.DETALITableAdapter dETALITableAdapter;
        private System.Windows.Forms.TextBox textBox3;
    }
}