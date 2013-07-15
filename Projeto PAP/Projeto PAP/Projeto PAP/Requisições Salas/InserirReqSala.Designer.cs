namespace Projeto_PAP
{
    partial class InserirReqSala
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
            System.Windows.Forms.Label iD_SalaLabel;
            System.Windows.Forms.Label iD_TempoLabel;
            System.Windows.Forms.Label iD_ProfessorLabel;
            System.Windows.Forms.Label observacoesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirReqSala));
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.requisições_SalasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requisições_SalasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.Requisições_SalasTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.horasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.HorasTableAdapter();
            this.professoresTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.ProfessoresTableAdapter();
            this.salasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.SalasTableAdapter();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.horasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            iD_SalaLabel = new System.Windows.Forms.Label();
            iD_TempoLabel = new System.Windows.Forms.Label();
            iD_ProfessorLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisições_SalasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_SalaLabel
            // 
            iD_SalaLabel.AutoSize = true;
            iD_SalaLabel.Location = new System.Drawing.Point(10, 22);
            iD_SalaLabel.Name = "iD_SalaLabel";
            iD_SalaLabel.Size = new System.Drawing.Size(31, 13);
            iD_SalaLabel.TabIndex = 3;
            iD_SalaLabel.Text = "Sala:";
            // 
            // iD_TempoLabel
            // 
            iD_TempoLabel.AutoSize = true;
            iD_TempoLabel.Location = new System.Drawing.Point(10, 48);
            iD_TempoLabel.Name = "iD_TempoLabel";
            iD_TempoLabel.Size = new System.Drawing.Size(43, 13);
            iD_TempoLabel.TabIndex = 5;
            iD_TempoLabel.Text = "Tempo:";
            // 
            // iD_ProfessorLabel
            // 
            iD_ProfessorLabel.AutoSize = true;
            iD_ProfessorLabel.Location = new System.Drawing.Point(10, 74);
            iD_ProfessorLabel.Name = "iD_ProfessorLabel";
            iD_ProfessorLabel.Size = new System.Drawing.Size(54, 13);
            iD_ProfessorLabel.TabIndex = 7;
            iD_ProfessorLabel.Text = "Professor:";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Location = new System.Drawing.Point(10, 100);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(73, 13);
            observacoesLabel.TabIndex = 9;
            observacoesLabel.Text = "Observacoes:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requisições_SalasBindingSource
            // 
            this.requisições_SalasBindingSource.DataMember = "Requisições_Salas";
            this.requisições_SalasBindingSource.DataSource = this.database1DataSet;
            // 
            // requisições_SalasTableAdapter
            // 
            this.requisições_SalasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.CursoTableAdapter = null;
            this.tableAdapterManager.Horario_SalasTableAdapter = null;
            this.tableAdapterManager.HorasTableAdapter = this.horasTableAdapter;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = this.professoresTableAdapter;
            this.tableAdapterManager.Requisições_SalasTableAdapter = this.requisições_SalasTableAdapter;
            this.tableAdapterManager.RequisiçõesMaterialTableAdapter = null;
            this.tableAdapterManager.RequisitadoresTableAdapter = null;
            this.tableAdapterManager.SalasTableAdapter = this.salasTableAdapter;
            this.tableAdapterManager.SemanaTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // horasTableAdapter
            // 
            this.horasTableAdapter.ClearBeforeFill = true;
            // 
            // professoresTableAdapter
            // 
            this.professoresTableAdapter.ClearBeforeFill = true;
            // 
            // salasTableAdapter
            // 
            this.salasTableAdapter.ClearBeforeFill = true;
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requisições_SalasBindingSource, "Observacoes", true));
            this.observacoesTextBox.Location = new System.Drawing.Point(89, 97);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(146, 51);
            this.observacoesTextBox.TabIndex = 10;
            this.observacoesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.observacoesTextBox_Validating);
            this.observacoesTextBox.Validated += new System.EventHandler(this.observacoesTextBox_Validated);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.salasBindingSource;
            this.comboBox1.DisplayMember = "Sala";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "ID_Sala";
            // 
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "Salas";
            this.salasBindingSource.DataSource = this.database1DataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.horasBindingSource;
            this.comboBox2.DisplayMember = "Hora_Inicio";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(89, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.ValueMember = "ID_Tempo";
            // 
            // horasBindingSource
            // 
            this.horasBindingSource.DataMember = "Horas";
            this.horasBindingSource.DataSource = this.database1DataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.professoresBindingSource;
            this.comboBox3.DisplayMember = "Nome_Professor";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(89, 70);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(146, 21);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.ValueMember = "ID_Professor";
            // 
            // professoresBindingSource
            // 
            this.professoresBindingSource.DataMember = "Professores";
            this.professoresBindingSource.DataSource = this.database1DataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(456, 68);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(iD_SalaLabel);
            this.splitContainer1.Panel1.Controls.Add(this.observacoesTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox3);
            this.splitContainer1.Panel1.Controls.Add(observacoesLabel);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel1.Controls.Add(iD_ProfessorLabel);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(iD_TempoLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(456, 239);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.TabIndex = 17;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 46);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(456, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // InserirReqSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 239);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InserirReqSala";
            this.Text = "Inserir Requisições Salas";
            this.Load += new System.EventHandler(this.InserirReqSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisições_SalasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource requisições_SalasBindingSource;
        private Database1DataSetTableAdapters.Requisições_SalasTableAdapter requisições_SalasTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private Database1DataSetTableAdapters.SalasTableAdapter salasTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource salasBindingSource;
        private Database1DataSetTableAdapters.HorasTableAdapter horasTableAdapter;
        private System.Windows.Forms.BindingSource horasBindingSource;
        private Database1DataSetTableAdapters.ProfessoresTableAdapter professoresTableAdapter;
        private System.Windows.Forms.BindingSource professoresBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}