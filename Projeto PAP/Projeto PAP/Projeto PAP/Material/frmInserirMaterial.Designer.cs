namespace Projeto_PAP
{
    partial class frmInserirMaterial
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
            System.Windows.Forms.Label designacaoLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label serial_numberLabel;
            System.Windows.Forms.Label observacaoLabel;
            System.Windows.Forms.Label cursoLabel1;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirMaterial));
            this.designacaoTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.serial_numberTextBox = new System.Windows.Forms.TextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.cursoComboBox = new System.Windows.Forms.ComboBox();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.materialTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.MaterialTableAdapter();
            this.cursoTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.CursoTableAdapter();
            this.categoriaTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.CategoriaTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professoresTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.ProfessoresTableAdapter();
            this.requisitantes_materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requisitantes_materialTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.Requisitantes_materialTableAdapter();
            designacaoLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            serial_numberLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            cursoLabel1 = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitantes_materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // designacaoLabel
            // 
            designacaoLabel.AutoSize = true;
            designacaoLabel.Location = new System.Drawing.Point(57, 29);
            designacaoLabel.Name = "designacaoLabel";
            designacaoLabel.Size = new System.Drawing.Size(67, 13);
            designacaoLabel.TabIndex = 3;
            designacaoLabel.Text = "Designacao:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(57, 55);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 5;
            marcaLabel.Text = "Marca:";
            // 
            // serial_numberLabel
            // 
            serial_numberLabel.AutoSize = true;
            serial_numberLabel.Location = new System.Drawing.Point(57, 81);
            serial_numberLabel.Name = "serial_numberLabel";
            serial_numberLabel.Size = new System.Drawing.Size(89, 13);
            serial_numberLabel.TabIndex = 7;
            serial_numberLabel.Text = "Número de Série:";
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(57, 133);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(73, 13);
            observacaoLabel.TabIndex = 11;
            observacaoLabel.Text = "Observações:";
            // 
            // cursoLabel1
            // 
            cursoLabel1.AutoSize = true;
            cursoLabel1.Location = new System.Drawing.Point(14, 32);
            cursoLabel1.Name = "cursoLabel1";
            cursoLabel1.Size = new System.Drawing.Size(37, 13);
            cursoLabel1.TabIndex = 23;
            cursoLabel1.Text = "Curso:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(14, 74);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(54, 13);
            categoriaLabel.TabIndex = 24;
            categoriaLabel.Text = "categoria:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(57, 270);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 13);
            label1.TabIndex = 32;
            label1.Text = "Professores Autorizados:";
            // 
            // designacaoTextBox
            // 
            this.designacaoTextBox.Location = new System.Drawing.Point(157, 26);
            this.designacaoTextBox.Name = "designacaoTextBox";
            this.designacaoTextBox.Size = new System.Drawing.Size(167, 20);
            this.designacaoTextBox.TabIndex = 4;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.Location = new System.Drawing.Point(157, 52);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(167, 20);
            this.marcaTextBox.TabIndex = 6;
            // 
            // serial_numberTextBox
            // 
            this.serial_numberTextBox.Location = new System.Drawing.Point(157, 78);
            this.serial_numberTextBox.Name = "serial_numberTextBox";
            this.serial_numberTextBox.Size = new System.Drawing.Size(167, 20);
            this.serial_numberTextBox.TabIndex = 8;
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.Location = new System.Drawing.Point(157, 130);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(167, 104);
            this.observacaoTextBox.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(530, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CursoTableAdapter = null;
            this.tableAdapterManager.EstadosTableAdapter = null;
            this.tableAdapterManager.Horario_SalasTableAdapter = null;
            this.tableAdapterManager.HorasTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.Requisições_SalasTableAdapter = null;
            this.tableAdapterManager.RequisiçõesMaterialTableAdapter = null;
            
            this.tableAdapterManager.Requisitantes_materialTableAdapter = null;
            this.tableAdapterManager.SalasTableAdapter = null;
            this.tableAdapterManager.SemanaTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cursoComboBox
            // 
            this.cursoComboBox.DataSource = this.cursoBindingSource;
            this.cursoComboBox.DisplayMember = "Curso";
            this.cursoComboBox.FormattingEnabled = true;
            this.cursoComboBox.Location = new System.Drawing.Point(108, 29);
            this.cursoComboBox.Name = "cursoComboBox";
            this.cursoComboBox.Size = new System.Drawing.Size(149, 21);
            this.cursoComboBox.TabIndex = 24;
            this.cursoComboBox.ValueMember = "Id_Curso";
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.database1DataSet;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataSource = this.categoriaBindingSource;
            this.categoriaComboBox.DisplayMember = "categoria";
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(108, 71);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(149, 21);
            this.categoriaComboBox.TabIndex = 25;
            this.categoriaComboBox.ValueMember = "id_categoria";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.database1DataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 26;
            this.button1.Text = "Imagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 27;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(635, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(550, 451);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "Inserir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(cursoLabel1);
            this.groupBox1.Controls.Add(this.cursoComboBox);
            this.groupBox1.Controls.Add(this.categoriaComboBox);
            this.groupBox1.Controls.Add(categoriaLabel);
            this.groupBox1.Location = new System.Drawing.Point(433, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 163);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação adicional";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(730, 22);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.professoresBindingSource;
            this.listBox1.DisplayMember = "Nome_Professor";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(157, 286);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(167, 147);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "ID_Professor";
            // 
            // professoresBindingSource
            // 
            this.professoresBindingSource.DataMember = "Professores";
            this.professoresBindingSource.DataSource = this.database1DataSet;
            // 
            // professoresTableAdapter
            // 
            this.professoresTableAdapter.ClearBeforeFill = true;
            // 
            // requisitantes_materialBindingSource
            // 
            this.requisitantes_materialBindingSource.DataMember = "Requisitantes_material";
            this.requisitantes_materialBindingSource.DataSource = this.database1DataSet;
            // 
            // requisitantes_materialTableAdapter
            // 
            this.requisitantes_materialTableAdapter.ClearBeforeFill = true;
            // 
            // frmInserirMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 516);
            this.Controls.Add(label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(designacaoLabel);
            this.Controls.Add(this.designacaoTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(serial_numberLabel);
            this.Controls.Add(this.serial_numberTextBox);
            this.Controls.Add(observacaoLabel);
            this.Controls.Add(this.observacaoTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInserirMaterial";
            this.Text = "Inserir Material";
            this.Load += new System.EventHandler(this.frmInserirMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitantes_materialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox designacaoTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox serial_numberTextBox;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cursoComboBox;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Database1DataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private Database1DataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Database1DataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource professoresBindingSource;
        private Database1DataSetTableAdapters.ProfessoresTableAdapter professoresTableAdapter;
        private System.Windows.Forms.BindingSource requisitantes_materialBindingSource;
        private Database1DataSetTableAdapters.Requisitantes_materialTableAdapter requisitantes_materialTableAdapter;
    }
}