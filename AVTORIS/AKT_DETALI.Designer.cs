namespace AVTORIS
{
    partial class AKT_DETALI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_AKT_DET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_AKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ladeaDataSet4 = new AVTORIS.LadeaDataSet4();
            this.dETALIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dETALITableAdapter = new AVTORIS.LadeaDataSet4TableAdapters.DETALITableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladeaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETALIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_AKT_DET,
            this.id_AKT,
            this.id_DT});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id_AKT_DET
            // 
            this.Id_AKT_DET.HeaderText = "Номер акта детали";
            this.Id_AKT_DET.Name = "Id_AKT_DET";
            // 
            // id_AKT
            // 
            this.id_AKT.HeaderText = "Номер акта";
            this.id_AKT.Name = "id_AKT";
            // 
            // id_DT
            // 
            this.id_DT.HeaderText = "Номер детали ";
            this.id_DT.Name = "id_DT";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dETALIBindingSource;
            this.comboBox1.DisplayMember = "Id_DT";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Id_DT";
            // 
            // ladeaDataSet4
            // 
            this.ladeaDataSet4.DataSetName = "LadeaDataSet4";
            this.ladeaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dETALIBindingSource
            // 
            this.dETALIBindingSource.DataMember = "DETALI";
            this.dETALIBindingSource.DataSource = this.ladeaDataSet4;
            // 
            // dETALITableAdapter
            // 
            this.dETALITableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер детали";
            // 
            // AKT_DETALI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AKT_DETALI";
            this.Text = "AKT_DETALI";
            this.Load += new System.EventHandler(this.AKT_DETALI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladeaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETALIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AKT_DET;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_AKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_DT;
        private System.Windows.Forms.ComboBox comboBox1;
        private LadeaDataSet4 ladeaDataSet4;
        private System.Windows.Forms.BindingSource dETALIBindingSource;
        private LadeaDataSet4TableAdapters.DETALITableAdapter dETALITableAdapter;
        private System.Windows.Forms.Label label1;
    }
}