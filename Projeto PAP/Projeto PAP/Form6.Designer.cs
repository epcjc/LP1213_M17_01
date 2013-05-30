namespace Projeto_PAP
{
    partial class Form6
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
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.rEq_SalasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.REq_SalasTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.rEq_SalasDataGridView = new System.Windows.Forms.DataGridView();
            this.rEqSalasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEq_SalasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEqSalasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEq_SalasTableAdapter
            // 
            this.rEq_SalasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Horario_SalasTableAdapter = null;
            this.tableAdapterManager.HorasTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.Requisições_SalasTableAdapter = null;
            this.tableAdapterManager.RequisiçõesMaterialTableAdapter = null;
            this.tableAdapterManager.RequisitadoresTableAdapter = null;
            this.tableAdapterManager.SalasTableAdapter = null;
            this.tableAdapterManager.SemanaTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rEq_SalasDataGridView
            // 
            this.rEq_SalasDataGridView.AutoGenerateColumns = false;
            this.rEq_SalasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rEq_SalasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salaDataGridViewTextBoxColumn,
            this.horaInicioDataGridViewTextBoxColumn,
            this.horaFimDataGridViewTextBoxColumn,
            this.nomeProfessorDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn});
            this.rEq_SalasDataGridView.DataSource = this.rEqSalasBindingSource;
            this.rEq_SalasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rEq_SalasDataGridView.Location = new System.Drawing.Point(0, 0);
            this.rEq_SalasDataGridView.Name = "rEq_SalasDataGridView";
            this.rEq_SalasDataGridView.Size = new System.Drawing.Size(385, 320);
            this.rEq_SalasDataGridView.TabIndex = 1;
            this.rEq_SalasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rEq_SalasDataGridView_CellContentClick);
            // 
            // rEqSalasBindingSource
            // 
            this.rEqSalasBindingSource.DataMember = "REq.Salas";
            this.rEqSalasBindingSource.DataSource = this.database1DataSet;
            // 
            // salaDataGridViewTextBoxColumn
            // 
            this.salaDataGridViewTextBoxColumn.DataPropertyName = "Sala";
            this.salaDataGridViewTextBoxColumn.HeaderText = "Sala";
            this.salaDataGridViewTextBoxColumn.Name = "salaDataGridViewTextBoxColumn";
            // 
            // horaInicioDataGridViewTextBoxColumn
            // 
            this.horaInicioDataGridViewTextBoxColumn.DataPropertyName = "Hora_Inicio";
            this.horaInicioDataGridViewTextBoxColumn.HeaderText = "Hora_Inicio";
            this.horaInicioDataGridViewTextBoxColumn.Name = "horaInicioDataGridViewTextBoxColumn";
            // 
            // horaFimDataGridViewTextBoxColumn
            // 
            this.horaFimDataGridViewTextBoxColumn.DataPropertyName = "Hora_Fim";
            this.horaFimDataGridViewTextBoxColumn.HeaderText = "Hora_Fim";
            this.horaFimDataGridViewTextBoxColumn.Name = "horaFimDataGridViewTextBoxColumn";
            // 
            // nomeProfessorDataGridViewTextBoxColumn
            // 
            this.nomeProfessorDataGridViewTextBoxColumn.DataPropertyName = "Nome_Professor";
            this.nomeProfessorDataGridViewTextBoxColumn.HeaderText = "Nome_Professor";
            this.nomeProfessorDataGridViewTextBoxColumn.Name = "nomeProfessorDataGridViewTextBoxColumn";
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 320);
            this.Controls.Add(this.rEq_SalasDataGridView);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEq_SalasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEqSalasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.REq_SalasTableAdapter rEq_SalasTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView rEq_SalasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rEqSalasBindingSource;








    }
}