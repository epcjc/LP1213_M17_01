namespace M17_01
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.semanaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database11DataSet = new M17_01.Database11DataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.horasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.semanaTableAdapter = new M17_01.Database11DataSetTableAdapters.SemanaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salas1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horasTableAdapter = new M17_01.Database11DataSetTableAdapters.HorasTableAdapter();
            this.salas1TableAdapter = new M17_01.Database11DataSetTableAdapters.Salas1TableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.semanaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salas1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dia Semana:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.semanaBindingSource;
            this.comboBox2.DisplayMember = "DiaSemana";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(94, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "ID_Semana";
            // 
            // semanaBindingSource
            // 
            this.semanaBindingSource.DataMember = "Semana";
            this.semanaBindingSource.DataSource = this.database11DataSet;
            // 
            // database11DataSet
            // 
            this.database11DataSet.DataSetName = "Database11DataSet";
            this.database11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tempo:";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.horasBindingSource;
            this.comboBox3.DisplayMember = "Hora_Inicio";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(94, 50);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ValueMember = "ID_Tempo";
            // 
            // horasBindingSource
            // 
            this.horasBindingSource.DataMember = "Horas";
            this.horasBindingSource.DataSource = this.database11DataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // semanaTableAdapter
            // 
            this.semanaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.salasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salas1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 277);
            this.dataGridView1.TabIndex = 7;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // salasDataGridViewTextBoxColumn
            // 
            this.salasDataGridViewTextBoxColumn.DataPropertyName = "Salas";
            this.salasDataGridViewTextBoxColumn.HeaderText = "Salas";
            this.salasDataGridViewTextBoxColumn.Name = "salasDataGridViewTextBoxColumn";
            // 
            // salas1BindingSource
            // 
            this.salas1BindingSource.DataMember = "Salas1";
            this.salas1BindingSource.DataSource = this.database11DataSet;
            // 
            // horasTableAdapter
            // 
            this.horasTableAdapter.ClearBeforeFill = true;
            // 
            // salas1TableAdapter
            // 
            this.salas1TableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 397);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.semanaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salas1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private Database11DataSet database11DataSet;
        private System.Windows.Forms.BindingSource semanaBindingSource;
        private Database11DataSetTableAdapters.SemanaTableAdapter semanaTableAdapter;
        private System.Windows.Forms.BindingSource horasBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database11DataSetTableAdapters.HorasTableAdapter horasTableAdapter;
        private System.Windows.Forms.BindingSource salas1BindingSource;
        private Database11DataSetTableAdapters.Salas1TableAdapter salas1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;

    }
}