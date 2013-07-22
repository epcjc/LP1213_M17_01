namespace Projeto_PAP
{
    partial class frmMaterial
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
            System.Windows.Forms.Label iD_MaterialLabel;
            System.Windows.Forms.Label designacaoLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label serial_numberLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label observacaoLabel;
            System.Windows.Forms.Label id_categoriaLabel;
            System.Windows.Forms.Label id_cursoLabel;
            System.Windows.Forms.Label cursoLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterial));
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.MaterialTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.cursoTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.CursoTableAdapter();
            this.materialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iD_MaterialTextBox = new System.Windows.Forms.TextBox();
            this.designacaoTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.serial_numberTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.id_categoriaTextBox = new System.Windows.Forms.TextBox();
            this.id_cursoTextBox = new System.Windows.Forms.TextBox();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTextBox = new System.Windows.Forms.TextBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.CategoriaTableAdapter();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            iD_MaterialLabel = new System.Windows.Forms.Label();
            designacaoLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            serial_numberLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            id_categoriaLabel = new System.Windows.Forms.Label();
            id_cursoLabel = new System.Windows.Forms.Label();
            cursoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingNavigator)).BeginInit();
            this.materialBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_MaterialLabel
            // 
            iD_MaterialLabel.AutoSize = true;
            iD_MaterialLabel.Location = new System.Drawing.Point(41, 53);
            iD_MaterialLabel.Name = "iD_MaterialLabel";
            iD_MaterialLabel.Size = new System.Drawing.Size(61, 13);
            iD_MaterialLabel.TabIndex = 1;
            iD_MaterialLabel.Text = "ID Material:";
            // 
            // designacaoLabel
            // 
            designacaoLabel.AutoSize = true;
            designacaoLabel.Location = new System.Drawing.Point(41, 79);
            designacaoLabel.Name = "designacaoLabel";
            designacaoLabel.Size = new System.Drawing.Size(67, 13);
            designacaoLabel.TabIndex = 3;
            designacaoLabel.Text = "Designacao:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(41, 105);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 5;
            marcaLabel.Text = "Marca:";
            // 
            // serial_numberLabel
            // 
            serial_numberLabel.AutoSize = true;
            serial_numberLabel.Location = new System.Drawing.Point(41, 131);
            serial_numberLabel.Name = "serial_numberLabel";
            serial_numberLabel.Size = new System.Drawing.Size(89, 13);
            serial_numberLabel.TabIndex = 7;
            serial_numberLabel.Text = "Número de Série:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(41, 157);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 9;
            estadoLabel.Text = "Estado:";
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(41, 183);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(68, 13);
            observacaoLabel.TabIndex = 11;
            observacaoLabel.Text = "Observacao:";
            // 
            // id_categoriaLabel
            // 
            id_categoriaLabel.AutoSize = true;
            id_categoriaLabel.Location = new System.Drawing.Point(428, 169);
            id_categoriaLabel.Name = "id_categoriaLabel";
            id_categoriaLabel.Size = new System.Drawing.Size(42, 13);
            id_categoriaLabel.TabIndex = 13;
            id_categoriaLabel.Text = "id Tipo:";
            // 
            // id_cursoLabel
            // 
            id_cursoLabel.AutoSize = true;
            id_cursoLabel.Location = new System.Drawing.Point(423, 82);
            id_cursoLabel.Name = "id_cursoLabel";
            id_cursoLabel.Size = new System.Drawing.Size(47, 13);
            id_cursoLabel.TabIndex = 15;
            id_cursoLabel.Text = "id curso:";
            // 
            // cursoLabel
            // 
            cursoLabel.AutoSize = true;
            cursoLabel.Location = new System.Drawing.Point(433, 108);
            cursoLabel.Name = "cursoLabel";
            cursoLabel.Size = new System.Drawing.Size(37, 13);
            cursoLabel.TabIndex = 17;
            cursoLabel.Text = "Curso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(439, 195);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 13);
            label1.TabIndex = 19;
            label1.Text = "Tipo:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.CursoTableAdapter = this.cursoTableAdapter;
            this.tableAdapterManager.Horario_SalasTableAdapter = null;
            this.tableAdapterManager.HorasTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = this.materialTableAdapter;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.Requisições_SalasTableAdapter = null;
            this.tableAdapterManager.RequisiçõesMaterialTableAdapter = null;
            
            this.tableAdapterManager.Requisitantes_materialTableAdapter = null;
            this.tableAdapterManager.SalasTableAdapter = null;
            this.tableAdapterManager.SemanaTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // materialBindingNavigator
            // 
            this.materialBindingNavigator.AddNewItem = null;
            this.materialBindingNavigator.BindingSource = this.materialBindingSource;
            this.materialBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.materialBindingNavigator.DeleteItem = null;
            this.materialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.materialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.materialBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.materialBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.materialBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.materialBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.materialBindingNavigator.Name = "materialBindingNavigator";
            this.materialBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.materialBindingNavigator.Size = new System.Drawing.Size(700, 25);
            this.materialBindingNavigator.TabIndex = 0;
            this.materialBindingNavigator.Text = "bindingNavigator1";
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
            // iD_MaterialTextBox
            // 
            this.iD_MaterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "ID_Material", true));
            this.iD_MaterialTextBox.Location = new System.Drawing.Point(141, 50);
            this.iD_MaterialTextBox.Name = "iD_MaterialTextBox";
            this.iD_MaterialTextBox.ReadOnly = true;
            this.iD_MaterialTextBox.Size = new System.Drawing.Size(52, 20);
            this.iD_MaterialTextBox.TabIndex = 2;
            // 
            // designacaoTextBox
            // 
            this.designacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Designacao", true));
            this.designacaoTextBox.Location = new System.Drawing.Point(141, 76);
            this.designacaoTextBox.Name = "designacaoTextBox";
            this.designacaoTextBox.Size = new System.Drawing.Size(167, 20);
            this.designacaoTextBox.TabIndex = 4;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(141, 102);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(167, 20);
            this.marcaTextBox.TabIndex = 6;
            // 
            // serial_numberTextBox
            // 
            this.serial_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Serial number", true));
            this.serial_numberTextBox.Location = new System.Drawing.Point(141, 128);
            this.serial_numberTextBox.Name = "serial_numberTextBox";
            this.serial_numberTextBox.Size = new System.Drawing.Size(167, 20);
            this.serial_numberTextBox.TabIndex = 8;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(141, 154);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(167, 20);
            this.estadoTextBox.TabIndex = 10;
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Observacao", true));
            this.observacaoTextBox.Location = new System.Drawing.Point(141, 180);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(167, 104);
            this.observacaoTextBox.TabIndex = 12;
            // 
            // id_categoriaTextBox
            // 
            this.id_categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "id_categoria", true));
            this.id_categoriaTextBox.Location = new System.Drawing.Point(476, 166);
            this.id_categoriaTextBox.Name = "id_categoriaTextBox";
            this.id_categoriaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_categoriaTextBox.TabIndex = 14;
            this.id_categoriaTextBox.TextChanged += new System.EventHandler(this.id_categoriaTextBox_TextChanged);
            // 
            // id_cursoTextBox
            // 
            this.id_cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "id_curso", true));
            this.id_cursoTextBox.Location = new System.Drawing.Point(476, 79);
            this.id_cursoTextBox.Name = "id_cursoTextBox";
            this.id_cursoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_cursoTextBox.TabIndex = 16;
            this.id_cursoTextBox.TextChanged += new System.EventHandler(this.id_cursoTextBox_TextChanged);
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.database1DataSet;
            // 
            // cursoTextBox
            // 
            this.cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Curso", true));
            this.cursoTextBox.Location = new System.Drawing.Point(476, 105);
            this.cursoTextBox.Name = "cursoTextBox";
            this.cursoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cursoTextBox.TabIndex = 18;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.database1DataSet;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "categoria", true));
            this.categoriaTextBox.Location = new System.Drawing.Point(476, 192);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoriaTextBox.TabIndex = 21;
            // 
            // frmMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 352);
            this.Controls.Add(this.categoriaTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(cursoLabel);
            this.Controls.Add(this.cursoTextBox);
            this.Controls.Add(iD_MaterialLabel);
            this.Controls.Add(this.iD_MaterialTextBox);
            this.Controls.Add(designacaoLabel);
            this.Controls.Add(this.designacaoTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(serial_numberLabel);
            this.Controls.Add(this.serial_numberTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(observacaoLabel);
            this.Controls.Add(this.observacaoTextBox);
            this.Controls.Add(id_categoriaLabel);
            this.Controls.Add(this.id_categoriaTextBox);
            this.Controls.Add(id_cursoLabel);
            this.Controls.Add(this.id_cursoTextBox);
            this.Controls.Add(this.materialBindingNavigator);
            this.Name = "frmMaterial";
            this.Text = "frmMaterial";
            this.Load += new System.EventHandler(this.frmMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingNavigator)).EndInit();
            this.materialBindingNavigator.ResumeLayout(false);
            this.materialBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private Database1DataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator materialBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox iD_MaterialTextBox;
        private System.Windows.Forms.TextBox designacaoTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox serial_numberTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.TextBox id_categoriaTextBox;
        private System.Windows.Forms.TextBox id_cursoTextBox;
        private Database1DataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.TextBox cursoTextBox;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Database1DataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.TextBox categoriaTextBox;
    }
}