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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.database11DataSet = new M17_01.Database11DataSet();
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salasTableAdapter = new M17_01.Database11DataSetTableAdapters.SalasTableAdapter();
            this.semanaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semanaTableAdapter = new M17_01.Database11DataSetTableAdapters.SemanaTableAdapter();
            this.database11DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horasTableAdapter = new M17_01.Database11DataSetTableAdapters.HorasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semanaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dia Semana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tempo:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.salasBindingSource;
            this.comboBox1.DisplayMember = "Salas";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "ID";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.semanaBindingSource;
            this.comboBox2.DisplayMember = "DiaSemana";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(95, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "ID_Semana";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.horasBindingSource;
            this.comboBox3.DisplayMember = "ID_Tempo";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(95, 70);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ValueMember = "ID_Tempo";
            // 
            // database11DataSet
            // 
            this.database11DataSet.DataSetName = "Database11DataSet";
            this.database11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "Salas";
            this.salasBindingSource.DataSource = this.database11DataSet;
            // 
            // salasTableAdapter
            // 
            this.salasTableAdapter.ClearBeforeFill = true;
            // 
            // semanaBindingSource
            // 
            this.semanaBindingSource.DataMember = "Semana";
            this.semanaBindingSource.DataSource = this.database11DataSet;
            // 
            // semanaTableAdapter
            // 
            this.semanaTableAdapter.ClearBeforeFill = true;
            // 
            // database11DataSetBindingSource
            // 
            this.database11DataSetBindingSource.DataSource = this.database11DataSet;
            this.database11DataSetBindingSource.Position = 0;
            // 
            // horasBindingSource
            // 
            this.horasBindingSource.DataMember = "Horas";
            this.horasBindingSource.DataSource = this.database11DataSet;
            // 
            // horasTableAdapter
            // 
            this.horasTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 261);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semanaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private Database11DataSet database11DataSet;
        private System.Windows.Forms.BindingSource salasBindingSource;
        private Database11DataSetTableAdapters.SalasTableAdapter salasTableAdapter;
        private System.Windows.Forms.BindingSource semanaBindingSource;
        private Database11DataSetTableAdapters.SemanaTableAdapter semanaTableAdapter;
        private System.Windows.Forms.BindingSource database11DataSetBindingSource;
        private System.Windows.Forms.BindingSource horasBindingSource;
        private Database11DataSetTableAdapters.HorasTableAdapter horasTableAdapter;

    }
}