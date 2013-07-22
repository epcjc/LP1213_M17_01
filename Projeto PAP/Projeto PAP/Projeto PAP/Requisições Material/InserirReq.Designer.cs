namespace Projeto_PAP
{
    partial class InserirReq
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
            System.Windows.Forms.Label observacoes_Antes_requisicaoLabel;
            System.Windows.Forms.Label observacoes_apos_requisicaoLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirReq));
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.materialTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.MaterialTableAdapter();
            
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.requisitadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.requisiçõesMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requisiçõesMaterialTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.RequisiçõesMaterialTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.observacoes_apos_requisicaoTextBox = new System.Windows.Forms.TextBox();
            this.observacoes_Antes_requisicaoTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            observacoes_Antes_requisicaoLabel = new System.Windows.Forms.Label();
            observacoes_apos_requisicaoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisiçõesMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // observacoes_Antes_requisicaoLabel
            // 
            observacoes_Antes_requisicaoLabel.AutoSize = true;
            observacoes_Antes_requisicaoLabel.Location = new System.Drawing.Point(20, 201);
            observacoes_Antes_requisicaoLabel.Name = "observacoes_Antes_requisicaoLabel";
            observacoes_Antes_requisicaoLabel.Size = new System.Drawing.Size(74, 13);
            observacoes_Antes_requisicaoLabel.TabIndex = 36;
            observacoes_Antes_requisicaoLabel.Text = "Obs. Pré Req.";
            // 
            // observacoes_apos_requisicaoLabel
            // 
            observacoes_apos_requisicaoLabel.AutoSize = true;
            observacoes_apos_requisicaoLabel.Location = new System.Drawing.Point(20, 256);
            observacoes_apos_requisicaoLabel.Name = "observacoes_apos_requisicaoLabel";
            observacoes_apos_requisicaoLabel.Size = new System.Drawing.Size(82, 13);
            observacoes_apos_requisicaoLabel.TabIndex = 37;
            observacoes_apos_requisicaoLabel.Text = "Obs. Apos Req.";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(20, 305);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 38;
            estadoLabel.Text = "Estado:";
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
            this.tableAdapterManager.CursoTableAdapter = null;
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
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 20;
            this.toolTip1.SetToolTip(this.textBox2, "introduza a data de hoje");
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 20);
            this.textBox3.TabIndex = 21;
            this.toolTip1.SetToolTip(this.textBox3, "Introduza a data de inicio da requisição");
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(124, 20);
            this.textBox4.TabIndex = 22;
            this.toolTip1.SetToolTip(this.textBox4, "introduza a data de fim da requisição");
            this.textBox4.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(125, 145);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(124, 20);
            this.textBox6.TabIndex = 24;
            this.toolTip1.SetToolTip(this.textBox6, "Introduza a hora de inicio");
            this.textBox6.Validating += new System.ComponentModel.CancelEventHandler(this.textBox6_Validating);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(125, 171);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(124, 20);
            this.textBox7.TabIndex = 25;
            this.toolTip1.SetToolTip(this.textBox7, "introduza a hora de fim");
            this.textBox7.Validating += new System.ComponentModel.CancelEventHandler(this.textBox7_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Hora Inicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Hora Fim";
            // 
            // requisitadoresBindingSource
            // 
            this.requisitadoresBindingSource.DataMember = "Requisitadores";
            this.requisitadoresBindingSource.DataSource = this.database1DataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.requisitadoresBindingSource;
            this.comboBox1.DisplayMember = "Nome_Requisitador";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.ValueMember = "ID_Requisitador";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.database1DataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.materialBindingSource;
            this.comboBox2.DisplayMember = "Nome_Material";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(125, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(124, 21);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.ValueMember = "ID_Material";
            // 
            // requisiçõesMaterialBindingSource
            // 
            this.requisiçõesMaterialBindingSource.DataMember = "RequisiçõesMaterial";
            this.requisiçõesMaterialBindingSource.DataSource = this.database1DataSet;
            // 
            // requisiçõesMaterialTableAdapter
            // 
            this.requisiçõesMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(574, 77);
            this.flowLayoutPanel1.TabIndex = 37;
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
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(estadoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.estadoTextBox);
            this.splitContainer1.Panel1.Controls.Add(observacoes_apos_requisicaoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.observacoes_apos_requisicaoTextBox);
            this.splitContainer1.Panel1.Controls.Add(observacoes_Antes_requisicaoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.observacoes_Antes_requisicaoTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox3);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox4);
            this.splitContainer1.Panel1.Controls.Add(this.textBox6);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.textBox7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(574, 389);
            this.splitContainer1.SplitterDistance = 308;
            this.splitContainer1.TabIndex = 38;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requisiçõesMaterialBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(125, 302);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(124, 20);
            this.estadoTextBox.TabIndex = 39;
            // 
            // observacoes_apos_requisicaoTextBox
            // 
            this.observacoes_apos_requisicaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requisiçõesMaterialBindingSource, "Observacoes_apos_requisicao", true));
            this.observacoes_apos_requisicaoTextBox.Location = new System.Drawing.Point(125, 253);
            this.observacoes_apos_requisicaoTextBox.Multiline = true;
            this.observacoes_apos_requisicaoTextBox.Name = "observacoes_apos_requisicaoTextBox";
            this.observacoes_apos_requisicaoTextBox.Size = new System.Drawing.Size(124, 42);
            this.observacoes_apos_requisicaoTextBox.TabIndex = 38;
            this.observacoes_apos_requisicaoTextBox.TextChanged += new System.EventHandler(this.observacoes_apos_requisicaoTextBox_TextChanged);
            // 
            // observacoes_Antes_requisicaoTextBox
            // 
            this.observacoes_Antes_requisicaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requisiçõesMaterialBindingSource, "Observacoes_Antes_requisicao", true));
            this.observacoes_Antes_requisicaoTextBox.Location = new System.Drawing.Point(125, 198);
            this.observacoes_Antes_requisicaoTextBox.Multiline = true;
            this.observacoes_Antes_requisicaoTextBox.Name = "observacoes_Antes_requisicaoTextBox";
            this.observacoes_Antes_requisicaoTextBox.Size = new System.Drawing.Size(124, 49);
            this.observacoes_Antes_requisicaoTextBox.TabIndex = 37;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(574, 22);
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // InserirReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 389);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InserirReq";
            this.Text = "Inserir Requisições Material";
            this.Load += new System.EventHandler(this.InserirReq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisiçõesMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
       // private System.Windows.Forms.BindingSource dataTable1BindingSource;
      //  private Database1DataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource requisitadoresBindingSource;
        private Database1DataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource requisiçõesMaterialBindingSource;
        private Database1DataSetTableAdapters.RequisiçõesMaterialTableAdapter requisiçõesMaterialTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox observacoes_apos_requisicaoTextBox;
        private System.Windows.Forms.TextBox observacoes_Antes_requisicaoTextBox;
    }
}