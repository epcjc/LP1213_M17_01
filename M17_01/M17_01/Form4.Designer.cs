namespace M17_01
{
    partial class Form4
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
            this.database11DataSet = new M17_01.Database11DataSet();
            this.rEqMaterial1BindingSource = new System.Windows.Forms.BindingSource(this.components);
           // this.rEq_Material1TableAdapter = new M17_01.Database11DataSetTableAdapters.REq_Material1TableAdapter();
            this.nomematerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerequisitadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatorequisitadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datarequisiçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iniciorequisiçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fimrequisiçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarequisitadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaEntregueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaçõesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEqMaterial1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomematerialDataGridViewTextBoxColumn,
            this.nomerequisitadorDataGridViewTextBoxColumn,
            this.contatorequisitadorDataGridViewTextBoxColumn,
            this.datarequisiçãoDataGridViewTextBoxColumn,
            this.iniciorequisiçãoDataGridViewTextBoxColumn,
            this.fimrequisiçãoDataGridViewTextBoxColumn,
            this.horarequisitadoDataGridViewTextBoxColumn,
            this.horaEntregueDataGridViewTextBoxColumn,
            this.observaçõesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEqMaterial1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // database11DataSet
            // 
            this.database11DataSet.DataSetName = "Database11DataSet";
            this.database11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEqMaterial1BindingSource
            // 
            this.rEqMaterial1BindingSource.DataMember = "REq_Material1";
            this.rEqMaterial1BindingSource.DataSource = this.database11DataSet;
            // 
            // rEq_Material1TableAdapter
            // 
           // this.rEq_Material1TableAdapter.ClearBeforeFill = true;
            // 
            // nomematerialDataGridViewTextBoxColumn
            // 
            this.nomematerialDataGridViewTextBoxColumn.DataPropertyName = "Nome_material";
            this.nomematerialDataGridViewTextBoxColumn.HeaderText = "Nome_material";
            this.nomematerialDataGridViewTextBoxColumn.Name = "nomematerialDataGridViewTextBoxColumn";
            // 
            // nomerequisitadorDataGridViewTextBoxColumn
            // 
            this.nomerequisitadorDataGridViewTextBoxColumn.DataPropertyName = "Nome_requisitador";
            this.nomerequisitadorDataGridViewTextBoxColumn.HeaderText = "Nome_requisitador";
            this.nomerequisitadorDataGridViewTextBoxColumn.Name = "nomerequisitadorDataGridViewTextBoxColumn";
            // 
            // contatorequisitadorDataGridViewTextBoxColumn
            // 
            this.contatorequisitadorDataGridViewTextBoxColumn.DataPropertyName = "Contato_requisitador";
            this.contatorequisitadorDataGridViewTextBoxColumn.HeaderText = "Contato_requisitador";
            this.contatorequisitadorDataGridViewTextBoxColumn.Name = "contatorequisitadorDataGridViewTextBoxColumn";
            // 
            // datarequisiçãoDataGridViewTextBoxColumn
            // 
            this.datarequisiçãoDataGridViewTextBoxColumn.DataPropertyName = "Data_requisição";
            this.datarequisiçãoDataGridViewTextBoxColumn.HeaderText = "Data_requisição";
            this.datarequisiçãoDataGridViewTextBoxColumn.Name = "datarequisiçãoDataGridViewTextBoxColumn";
            // 
            // iniciorequisiçãoDataGridViewTextBoxColumn
            // 
            this.iniciorequisiçãoDataGridViewTextBoxColumn.DataPropertyName = "Inicio_requisição";
            this.iniciorequisiçãoDataGridViewTextBoxColumn.HeaderText = "Inicio_requisição";
            this.iniciorequisiçãoDataGridViewTextBoxColumn.Name = "iniciorequisiçãoDataGridViewTextBoxColumn";
            // 
            // fimrequisiçãoDataGridViewTextBoxColumn
            // 
            this.fimrequisiçãoDataGridViewTextBoxColumn.DataPropertyName = "Fim_requisição";
            this.fimrequisiçãoDataGridViewTextBoxColumn.HeaderText = "Fim_requisição";
            this.fimrequisiçãoDataGridViewTextBoxColumn.Name = "fimrequisiçãoDataGridViewTextBoxColumn";
            // 
            // horarequisitadoDataGridViewTextBoxColumn
            // 
            this.horarequisitadoDataGridViewTextBoxColumn.DataPropertyName = "Hora_requisitado";
            this.horarequisitadoDataGridViewTextBoxColumn.HeaderText = "Hora_requisitado";
            this.horarequisitadoDataGridViewTextBoxColumn.Name = "horarequisitadoDataGridViewTextBoxColumn";
            // 
            // horaEntregueDataGridViewTextBoxColumn
            // 
            this.horaEntregueDataGridViewTextBoxColumn.DataPropertyName = "Hora_Entregue";
            this.horaEntregueDataGridViewTextBoxColumn.HeaderText = "Hora_Entregue";
            this.horaEntregueDataGridViewTextBoxColumn.Name = "horaEntregueDataGridViewTextBoxColumn";
            // 
            // observaçõesDataGridViewTextBoxColumn
            // 
            this.observaçõesDataGridViewTextBoxColumn.DataPropertyName = "Observações";
            this.observaçõesDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.observaçõesDataGridViewTextBoxColumn.Name = "observaçõesDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.rEqMaterial1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database11DataSet database11DataSet;
        private System.Windows.Forms.BindingSource rEqMaterial1BindingSource;
       // private Database11DataSetTableAdapters.REq_Material1TableAdapter rEq_Material1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomematerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerequisitadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatorequisitadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datarequisiçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iniciorequisiçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fimrequisiçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarequisitadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaEntregueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaçõesDataGridViewTextBoxColumn;



    }
}