namespace Projeto_PAP
{
    partial class TiposMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiposMaterial));
            System.Windows.Forms.Label id_categoriaLabel;
            System.Windows.Forms.Label categoriaLabel;
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.CategoriaTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.categoriaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.categoriaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_categoriaTextBox = new System.Windows.Forms.TextBox();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            id_categoriaLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingNavigator)).BeginInit();
            this.categoriaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager.CursoTableAdapter = null;
            this.tableAdapterManager.Horario_SalasTableAdapter = null;
            this.tableAdapterManager.HorasTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.Requisições_SalasTableAdapter = null;
            this.tableAdapterManager.RequisiçõesMaterialTableAdapter = null;
            this.tableAdapterManager.RequisitadoresTableAdapter = null;
            this.tableAdapterManager.Requisitantes_materialTableAdapter = null;
            this.tableAdapterManager.SalasTableAdapter = null;
            this.tableAdapterManager.SemanaTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriaBindingNavigator
            // 
            this.categoriaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoriaBindingNavigator.BindingSource = this.categoriaBindingSource;
            this.categoriaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categoriaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categoriaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.categoriaBindingNavigatorSaveItem});
            this.categoriaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoriaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categoriaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categoriaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoriaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoriaBindingNavigator.Name = "categoriaBindingNavigator";
            this.categoriaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoriaBindingNavigator.Size = new System.Drawing.Size(398, 25);
            this.categoriaBindingNavigator.TabIndex = 0;
            this.categoriaBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 13);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // categoriaBindingNavigatorSaveItem
            // 
            this.categoriaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoriaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriaBindingNavigatorSaveItem.Image")));
            this.categoriaBindingNavigatorSaveItem.Name = "categoriaBindingNavigatorSaveItem";
            this.categoriaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.categoriaBindingNavigatorSaveItem.Text = "Save Data";
            this.categoriaBindingNavigatorSaveItem.Click += new System.EventHandler(this.categoriaBindingNavigatorSaveItem_Click_2);
            // 
            // id_categoriaLabel
            // 
            id_categoriaLabel.AutoSize = true;
            id_categoriaLabel.Location = new System.Drawing.Point(22, 71);
            id_categoriaLabel.Name = "id_categoriaLabel";
            id_categoriaLabel.Size = new System.Drawing.Size(69, 13);
            id_categoriaLabel.TabIndex = 1;
            id_categoriaLabel.Text = "Nº categoria:";
            // 
            // id_categoriaTextBox
            // 
            this.id_categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "id_categoria", true));
            this.id_categoriaTextBox.Location = new System.Drawing.Point(113, 68);
            this.id_categoriaTextBox.Name = "id_categoriaTextBox";
            this.id_categoriaTextBox.ReadOnly = true;
            this.id_categoriaTextBox.Size = new System.Drawing.Size(40, 20);
            this.id_categoriaTextBox.TabIndex = 2;
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(22, 97);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(54, 13);
            categoriaLabel.TabIndex = 3;
            categoriaLabel.Text = "categoria:";
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "categoria", true));
            this.categoriaTextBox.Location = new System.Drawing.Point(113, 94);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(140, 20);
            this.categoriaTextBox.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 167);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(398, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TiposMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 189);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(id_categoriaLabel);
            this.Controls.Add(this.id_categoriaTextBox);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaTextBox);
            this.Controls.Add(this.categoriaBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TiposMaterial";
            this.Text = "TiposMaterial";
            this.Load += new System.EventHandler(this.TiposMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingNavigator)).EndInit();
            this.categoriaBindingNavigator.ResumeLayout(false);
            this.categoriaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Database1DataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categoriaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton categoriaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_categoriaTextBox;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;


    }
}