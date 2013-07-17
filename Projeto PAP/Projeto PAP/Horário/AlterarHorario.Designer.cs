namespace Projeto_PAP
{
    partial class AlterarHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarHorario));
            System.Windows.Forms.Label iD_TempoLabel;
            System.Windows.Forms.Label iD_SemanaLabel;
            System.Windows.Forms.Label iD_TurmaLabel;
            System.Windows.Forms.Label iD_SalaLabel;
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.horario_SalasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horario_SalasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.Horario_SalasTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.horasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.HorasTableAdapter();
            this.salasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.SalasTableAdapter();
            this.semanaTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.SemanaTableAdapter();
            this.turmasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.TurmasTableAdapter();
            this.horario_SalasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.horario_SalasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.horasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semanaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turmasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_TempoComboBox = new System.Windows.Forms.ComboBox();
            this.iD_SemanaComboBox = new System.Windows.Forms.ComboBox();
            this.iD_TurmaComboBox = new System.Windows.Forms.ComboBox();
            this.iD_SalaComboBox = new System.Windows.Forms.ComboBox();
            iD_TempoLabel = new System.Windows.Forms.Label();
            iD_SemanaLabel = new System.Windows.Forms.Label();
            iD_TurmaLabel = new System.Windows.Forms.Label();
            iD_SalaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horario_SalasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horario_SalasBindingNavigator)).BeginInit();
            this.horario_SalasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semanaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // horario_SalasBindingSource
            // 
            this.horario_SalasBindingSource.DataMember = "Horario_Salas";
            this.horario_SalasBindingSource.DataSource = this.database1DataSet;
            // 
            // horario_SalasTableAdapter
            // 
            this.horario_SalasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Horario_SalasTableAdapter = this.horario_SalasTableAdapter;
            this.tableAdapterManager.HorasTableAdapter = this.horasTableAdapter;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.Requisições_SalasTableAdapter = null;
            this.tableAdapterManager.RequisiçõesMaterialTableAdapter = null;
            this.tableAdapterManager.RequisitadoresTableAdapter = null;
            this.tableAdapterManager.SalasTableAdapter = this.salasTableAdapter;
            this.tableAdapterManager.SemanaTableAdapter = this.semanaTableAdapter;
            this.tableAdapterManager.TurmasTableAdapter = this.turmasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // horasTableAdapter
            // 
            this.horasTableAdapter.ClearBeforeFill = true;
            // 
            // salasTableAdapter
            // 
            this.salasTableAdapter.ClearBeforeFill = true;
            // 
            // semanaTableAdapter
            // 
            this.semanaTableAdapter.ClearBeforeFill = true;
            // 
            // turmasTableAdapter
            // 
            this.turmasTableAdapter.ClearBeforeFill = true;
            // 
            // horario_SalasBindingNavigator
            // 
            this.horario_SalasBindingNavigator.AddNewItem = null;
            this.horario_SalasBindingNavigator.BindingSource = this.horario_SalasBindingSource;
            this.horario_SalasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.horario_SalasBindingNavigator.DeleteItem = null;
            this.horario_SalasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.horario_SalasBindingNavigatorSaveItem});
            this.horario_SalasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.horario_SalasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.horario_SalasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.horario_SalasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.horario_SalasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.horario_SalasBindingNavigator.Name = "horario_SalasBindingNavigator";
            this.horario_SalasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.horario_SalasBindingNavigator.Size = new System.Drawing.Size(292, 25);
            this.horario_SalasBindingNavigator.TabIndex = 0;
            this.horario_SalasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // horario_SalasBindingNavigatorSaveItem
            // 
            this.horario_SalasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.horario_SalasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("horario_SalasBindingNavigatorSaveItem.Image")));
            this.horario_SalasBindingNavigatorSaveItem.Name = "horario_SalasBindingNavigatorSaveItem";
            this.horario_SalasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.horario_SalasBindingNavigatorSaveItem.Text = "Save Data";
            this.horario_SalasBindingNavigatorSaveItem.Click += new System.EventHandler(this.horario_SalasBindingNavigatorSaveItem_Click);
            // 
            // horasBindingSource
            // 
            this.horasBindingSource.DataMember = "Horas";
            this.horasBindingSource.DataSource = this.database1DataSet;
            // 
            // semanaBindingSource
            // 
            this.semanaBindingSource.DataMember = "Semana";
            this.semanaBindingSource.DataSource = this.database1DataSet;
            // 
            // turmasBindingSource
            // 
            this.turmasBindingSource.DataMember = "Turmas";
            this.turmasBindingSource.DataSource = this.database1DataSet;
            // 
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "Salas";
            this.salasBindingSource.DataSource = this.database1DataSet;
            // 
            // iD_TempoLabel
            // 
            iD_TempoLabel.AutoSize = true;
            iD_TempoLabel.Location = new System.Drawing.Point(11, 68);
            iD_TempoLabel.Name = "iD_TempoLabel";
            iD_TempoLabel.Size = new System.Drawing.Size(57, 13);
            iD_TempoLabel.TabIndex = 3;
            iD_TempoLabel.Text = "ID Tempo:";
            iD_TempoLabel.Click += new System.EventHandler(this.iD_TempoLabel_Click);
            // 
            // iD_TempoComboBox
            // 
            this.iD_TempoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horario_SalasBindingSource, "ID_Tempo", true));
            this.iD_TempoComboBox.FormattingEnabled = true;
            this.iD_TempoComboBox.Location = new System.Drawing.Point(80, 65);
            this.iD_TempoComboBox.Name = "iD_TempoComboBox";
            this.iD_TempoComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_TempoComboBox.TabIndex = 4;
            // 
            // iD_SemanaLabel
            // 
            iD_SemanaLabel.AutoSize = true;
            iD_SemanaLabel.Location = new System.Drawing.Point(11, 95);
            iD_SemanaLabel.Name = "iD_SemanaLabel";
            iD_SemanaLabel.Size = new System.Drawing.Size(63, 13);
            iD_SemanaLabel.TabIndex = 5;
            iD_SemanaLabel.Text = "ID Semana:";
            // 
            // iD_SemanaComboBox
            // 
            this.iD_SemanaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horario_SalasBindingSource, "ID_Semana", true));
            this.iD_SemanaComboBox.FormattingEnabled = true;
            this.iD_SemanaComboBox.Location = new System.Drawing.Point(80, 92);
            this.iD_SemanaComboBox.Name = "iD_SemanaComboBox";
            this.iD_SemanaComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_SemanaComboBox.TabIndex = 6;
            // 
            // iD_TurmaLabel
            // 
            iD_TurmaLabel.AutoSize = true;
            iD_TurmaLabel.Location = new System.Drawing.Point(11, 122);
            iD_TurmaLabel.Name = "iD_TurmaLabel";
            iD_TurmaLabel.Size = new System.Drawing.Size(54, 13);
            iD_TurmaLabel.TabIndex = 7;
            iD_TurmaLabel.Text = "ID Turma:";
            // 
            // iD_TurmaComboBox
            // 
            this.iD_TurmaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horario_SalasBindingSource, "ID_Turma", true));
            this.iD_TurmaComboBox.FormattingEnabled = true;
            this.iD_TurmaComboBox.Location = new System.Drawing.Point(80, 119);
            this.iD_TurmaComboBox.Name = "iD_TurmaComboBox";
            this.iD_TurmaComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_TurmaComboBox.TabIndex = 8;
            // 
            // iD_SalaLabel
            // 
            iD_SalaLabel.AutoSize = true;
            iD_SalaLabel.Location = new System.Drawing.Point(11, 149);
            iD_SalaLabel.Name = "iD_SalaLabel";
            iD_SalaLabel.Size = new System.Drawing.Size(45, 13);
            iD_SalaLabel.TabIndex = 9;
            iD_SalaLabel.Text = "ID Sala:";
            // 
            // iD_SalaComboBox
            // 
            this.iD_SalaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horario_SalasBindingSource, "ID_Sala", true));
            this.iD_SalaComboBox.FormattingEnabled = true;
            this.iD_SalaComboBox.Location = new System.Drawing.Point(80, 146);
            this.iD_SalaComboBox.Name = "iD_SalaComboBox";
            this.iD_SalaComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_SalaComboBox.TabIndex = 10;
            // 
            // AlterarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 213);
            this.Controls.Add(iD_TempoLabel);
            this.Controls.Add(this.iD_TempoComboBox);
            this.Controls.Add(iD_SemanaLabel);
            this.Controls.Add(this.iD_SemanaComboBox);
            this.Controls.Add(iD_TurmaLabel);
            this.Controls.Add(this.iD_TurmaComboBox);
            this.Controls.Add(iD_SalaLabel);
            this.Controls.Add(this.iD_SalaComboBox);
            this.Controls.Add(this.horario_SalasBindingNavigator);
            this.Name = "AlterarHorario";
            this.Text = "AlterarHorario";
            this.Load += new System.EventHandler(this.AlterarHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horario_SalasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horario_SalasBindingNavigator)).EndInit();
            this.horario_SalasBindingNavigator.ResumeLayout(false);
            this.horario_SalasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semanaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource horario_SalasBindingSource;
        private Database1DataSetTableAdapters.Horario_SalasTableAdapter horario_SalasTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator horario_SalasBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton horario_SalasBindingNavigatorSaveItem;
        private Database1DataSetTableAdapters.HorasTableAdapter horasTableAdapter;
        private System.Windows.Forms.BindingSource horasBindingSource;
        private Database1DataSetTableAdapters.SemanaTableAdapter semanaTableAdapter;
        private System.Windows.Forms.BindingSource semanaBindingSource;
        private Database1DataSetTableAdapters.TurmasTableAdapter turmasTableAdapter;
        private System.Windows.Forms.BindingSource turmasBindingSource;
        private Database1DataSetTableAdapters.SalasTableAdapter salasTableAdapter;
        private System.Windows.Forms.BindingSource salasBindingSource;
        private System.Windows.Forms.ComboBox iD_TempoComboBox;
        private System.Windows.Forms.ComboBox iD_SemanaComboBox;
        private System.Windows.Forms.ComboBox iD_TurmaComboBox;
        private System.Windows.Forms.ComboBox iD_SalaComboBox;
    }
}