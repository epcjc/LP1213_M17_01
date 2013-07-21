namespace Projeto_PAP
{
    partial class frmFichaMaterial
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label designacaoLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label serial_numberLabel;
            System.Windows.Forms.Label observacaoLabel;
            System.Windows.Forms.Label cursoLabel;
            System.Windows.Forms.Label categoriaLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFichaMaterial));
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.cursoTextBox = new System.Windows.Forms.TextBox();
            this.consultasMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.materialTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.MaterialTableAdapter();
            this.cursoTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.CursoTableAdapter();
            this.categoriaTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.CategoriaTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.professoresAutorizadosMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professoresTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.ProfessoresTableAdapter();
            this.requisitantes_materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requisitantes_materialTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.Requisitantes_materialTableAdapter();
            this.consultasMaterialTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.ConsultasMaterialTableAdapter();
            this.designacaoTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.serial_numberTextBox = new System.Windows.Forms.TextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.imagemPictureBox = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.professoresAutorizadosMaterialTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.ProfessoresAutorizadosMaterialTableAdapter();
            label1 = new System.Windows.Forms.Label();
            designacaoLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            serial_numberLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            cursoLabel = new System.Windows.Forms.Label();
            categoriaLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresAutorizadosMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitantes_materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPictureBox)).BeginInit();
            this.SuspendLayout();
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
            // designacaoLabel
            // 
            designacaoLabel.AutoSize = true;
            designacaoLabel.Location = new System.Drawing.Point(62, 26);
            designacaoLabel.Name = "designacaoLabel";
            designacaoLabel.Size = new System.Drawing.Size(67, 13);
            designacaoLabel.TabIndex = 34;
            designacaoLabel.Text = "Designacao:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(62, 52);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 36;
            marcaLabel.Text = "Marca:";
            // 
            // serial_numberLabel
            // 
            serial_numberLabel.AutoSize = true;
            serial_numberLabel.Location = new System.Drawing.Point(62, 78);
            serial_numberLabel.Name = "serial_numberLabel";
            serial_numberLabel.Size = new System.Drawing.Size(74, 13);
            serial_numberLabel.TabIndex = 38;
            serial_numberLabel.Text = "Número Série:";
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(62, 130);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(73, 13);
            observacaoLabel.TabIndex = 42;
            observacaoLabel.Text = "Observações:";
            // 
            // cursoLabel
            // 
            cursoLabel.AutoSize = true;
            cursoLabel.Location = new System.Drawing.Point(31, 31);
            cursoLabel.Name = "cursoLabel";
            cursoLabel.Size = new System.Drawing.Size(37, 13);
            cursoLabel.TabIndex = 44;
            cursoLabel.Text = "Curso:";
            // 
            // categoriaLabel1
            // 
            categoriaLabel1.AutoSize = true;
            categoriaLabel1.Location = new System.Drawing.Point(31, 100);
            categoriaLabel1.Name = "categoriaLabel1";
            categoriaLabel1.Size = new System.Drawing.Size(31, 13);
            categoriaLabel1.TabIndex = 46;
            categoriaLabel1.Text = "Tipo:";
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
            this.tableAdapterManager.RequisitadoresTableAdapter = null;
            this.tableAdapterManager.Requisitantes_materialTableAdapter = null;
            this.tableAdapterManager.SalasTableAdapter = null;
            this.tableAdapterManager.SemanaTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.database1DataSet;
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
            this.button1.Visible = false;
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
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(635, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(550, 451);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 29;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.cursoTextBox);
            this.groupBox1.Controls.Add(this.categoriaTextBox);
            this.groupBox1.Controls.Add(categoriaLabel1);
            this.groupBox1.Controls.Add(cursoLabel);
            this.groupBox1.Location = new System.Drawing.Point(433, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 163);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação adicional";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(196, 123);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 49;
            this.button8.Text = "Alterar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(196, 54);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 48;
            this.button7.Text = "Alterar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // cursoTextBox
            // 
            this.cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasMaterialBindingSource, "Curso", true));
            this.cursoTextBox.Location = new System.Drawing.Point(111, 28);
            this.cursoTextBox.Name = "cursoTextBox";
            this.cursoTextBox.Size = new System.Drawing.Size(160, 20);
            this.cursoTextBox.TabIndex = 45;
            // 
            // consultasMaterialBindingSource
            // 
            this.consultasMaterialBindingSource.DataMember = "ConsultasMaterial";
            this.consultasMaterialBindingSource.DataSource = this.database1DataSet;
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasMaterialBindingSource, "categoria", true));
            this.categoriaTextBox.Location = new System.Drawing.Point(111, 97);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(160, 20);
            this.categoriaTextBox.TabIndex = 47;
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
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(142, 286);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(167, 147);
            this.listBox1.TabIndex = 0;
            // 
            // professoresAutorizadosMaterialBindingSource
            // 
            this.professoresAutorizadosMaterialBindingSource.DataMember = "ProfessoresAutorizadosMaterial";
            this.professoresAutorizadosMaterialBindingSource.DataSource = this.database1DataSet;
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
            // consultasMaterialTableAdapter
            // 
            this.consultasMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // designacaoTextBox
            // 
            this.designacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasMaterialBindingSource, "Designacao", true));
            this.designacaoTextBox.Location = new System.Drawing.Point(142, 23);
            this.designacaoTextBox.Name = "designacaoTextBox";
            this.designacaoTextBox.Size = new System.Drawing.Size(167, 20);
            this.designacaoTextBox.TabIndex = 35;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasMaterialBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(142, 49);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(167, 20);
            this.marcaTextBox.TabIndex = 37;
            // 
            // serial_numberTextBox
            // 
            this.serial_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasMaterialBindingSource, "Serial number", true));
            this.serial_numberTextBox.Location = new System.Drawing.Point(142, 75);
            this.serial_numberTextBox.Name = "serial_numberTextBox";
            this.serial_numberTextBox.Size = new System.Drawing.Size(167, 20);
            this.serial_numberTextBox.TabIndex = 39;
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasMaterialBindingSource, "Observacao", true));
            this.observacaoTextBox.Location = new System.Drawing.Point(142, 127);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(167, 122);
            this.observacaoTextBox.TabIndex = 43;
            // 
            // imagemPictureBox
            // 
            this.imagemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.consultasMaterialBindingSource, "imagem", true));
            this.imagemPictureBox.Location = new System.Drawing.Point(530, 23);
            this.imagemPictureBox.Name = "imagemPictureBox";
            this.imagemPictureBox.Size = new System.Drawing.Size(160, 160);
            this.imagemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemPictureBox.TabIndex = 48;
            this.imagemPictureBox.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(234, 439);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 50;
            this.button6.Text = "Alterar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // professoresAutorizadosMaterialTableAdapter
            // 
            this.professoresAutorizadosMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // frmFichaMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 516);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.imagemPictureBox);
            this.Controls.Add(designacaoLabel);
            this.Controls.Add(this.designacaoTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(serial_numberLabel);
            this.Controls.Add(this.serial_numberTextBox);
            this.Controls.Add(observacaoLabel);
            this.Controls.Add(this.observacaoTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFichaMaterial";
            this.Text = "Material";
            this.Load += new System.EventHandler(this.frmInserirMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresAutorizadosMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitantes_materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.BindingSource consultasMaterialBindingSource;
        private Database1DataSetTableAdapters.ConsultasMaterialTableAdapter consultasMaterialTableAdapter;
        private System.Windows.Forms.TextBox designacaoTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox serial_numberTextBox;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.TextBox cursoTextBox;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.PictureBox imagemPictureBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource professoresAutorizadosMaterialBindingSource;
        private Database1DataSetTableAdapters.ProfessoresAutorizadosMaterialTableAdapter professoresAutorizadosMaterialTableAdapter;
    }
}