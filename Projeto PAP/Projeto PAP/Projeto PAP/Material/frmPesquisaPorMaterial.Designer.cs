namespace Projeto_PAP
{
    partial class frmPesquisaPorMaterial
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.MaterialTableAdapter();
            this.historicoRequisicoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historicoRequisicoesTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.HistoricoRequisicoesTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.requisiçõesMaterialTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.RequisiçõesMaterialTableAdapter();
            this.fKRequisiçõesMaterialMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historicoRequisicoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoRequisicoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRequisiçõesMaterialMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoRequisicoesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.materialBindingSource;
            this.comboBox1.DisplayMember = "Designacao";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID_Material";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.database1DataSet;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // historicoRequisicoesBindingSource
            // 
            this.historicoRequisicoesBindingSource.DataMember = "HistoricoRequisicoes";
            this.historicoRequisicoesBindingSource.DataSource = this.database1DataSet;
            // 
            // historicoRequisicoesTableAdapter
            // 
            this.historicoRequisicoesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.CursoTableAdapter = null;
            this.tableAdapterManager.EstadosTableAdapter = null;
            this.tableAdapterManager.Horario_SalasTableAdapter = null;
            this.tableAdapterManager.HorasTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = this.materialTableAdapter;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.Requisições_SalasTableAdapter = null;
            this.tableAdapterManager.RequisiçõesMaterialTableAdapter = this.requisiçõesMaterialTableAdapter;
            this.tableAdapterManager.Requisitantes_materialTableAdapter = null;
            this.tableAdapterManager.SalasTableAdapter = null;
            this.tableAdapterManager.SemanaTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // requisiçõesMaterialTableAdapter
            // 
            this.requisiçõesMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // fKRequisiçõesMaterialMaterialBindingSource
            // 
            this.fKRequisiçõesMaterialMaterialBindingSource.DataMember = "FK_RequisiçõesMaterial_Material";
            this.fKRequisiçõesMaterialMaterialBindingSource.DataSource = this.materialBindingSource;
            // 
            // historicoRequisicoesDataGridView
            // 
            this.historicoRequisicoesDataGridView.AutoGenerateColumns = false;
            this.historicoRequisicoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historicoRequisicoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.historicoRequisicoesDataGridView.DataSource = this.historicoRequisicoesBindingSource;
            this.historicoRequisicoesDataGridView.Location = new System.Drawing.Point(12, 101);
            this.historicoRequisicoesDataGridView.Name = "historicoRequisicoesDataGridView";
            this.historicoRequisicoesDataGridView.Size = new System.Drawing.Size(734, 220);
            this.historicoRequisicoesDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ID_Requisicao";
            this.dataGridViewTextBoxColumn10.HeaderText = "ID_Requisicao";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Serial number";
            this.dataGridViewTextBoxColumn4.HeaderText = "Serial number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nome_Professor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nome_Professor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Contacto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Contacto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Data_Requisicao";
            this.dataGridViewTextBoxColumn7.HeaderText = "Data_Requisicao";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Fim_requisicao";
            this.dataGridViewTextBoxColumn11.HeaderText = "Fim_requisicao";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Observacoes_Antes_requisicao";
            this.dataGridViewTextBoxColumn8.HeaderText = "Observacoes_Antes_requisicao";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Observacoes_apos_requisicao";
            this.dataGridViewTextBoxColumn9.HeaderText = "Observacoes_apos_requisicao";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // frmPesquisaPorMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 383);
            this.Controls.Add(this.historicoRequisicoesDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmPesquisaPorMaterial";
            this.Text = "Histórico de Requisições";
            this.Load += new System.EventHandler(this.frmPesquisaPorMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoRequisicoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRequisiçõesMaterialMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoRequisicoesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private Database1DataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.BindingSource historicoRequisicoesBindingSource;
        private Database1DataSetTableAdapters.HistoricoRequisicoesTableAdapter historicoRequisicoesTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.RequisiçõesMaterialTableAdapter requisiçõesMaterialTableAdapter;
        private System.Windows.Forms.BindingSource fKRequisiçõesMaterialMaterialBindingSource;
        private System.Windows.Forms.DataGridView historicoRequisicoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}