namespace Projeto_PAP
{
    partial class Apagar_Requesitantes
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
            System.Windows.Forms.Label nome_RequisitadorLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.requisitadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requisitadoresTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.RequisitadoresTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            nome_RequisitadorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitadoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nome_RequisitadorLabel
            // 
            nome_RequisitadorLabel.AutoSize = true;
            nome_RequisitadorLabel.Location = new System.Drawing.Point(12, 63);
            nome_RequisitadorLabel.Name = "nome_RequisitadorLabel";
            nome_RequisitadorLabel.Size = new System.Drawing.Size(100, 13);
            nome_RequisitadorLabel.TabIndex = 5;
            nome_RequisitadorLabel.Text = "Nome Requisitante:";
            nome_RequisitadorLabel.Click += new System.EventHandler(this.nome_RequisitadorLabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requisitadoresBindingSource
            // 
            this.requisitadoresBindingSource.DataMember = "Requisitadores";
            this.requisitadoresBindingSource.DataSource = this.database1DataSet;
            // 
            // requisitadoresTableAdapter
            // 
            this.requisitadoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Horario_SalasTableAdapter = null;
            this.tableAdapterManager.HorasTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.Requisições_SalasTableAdapter = null;
            this.tableAdapterManager.RequisiçõesMaterialTableAdapter = null;
            this.tableAdapterManager.RequisitadoresTableAdapter = this.requisitadoresTableAdapter;
            this.tableAdapterManager.SalasTableAdapter = null;
            this.tableAdapterManager.SemanaTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.requisitadoresBindingSource;
            this.comboBox1.DisplayMember = "Nome_Requisitador";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "ID_Requisitador";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Apagar Requisitante:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Apagar_Requesitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(nome_RequisitadorLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.HelpButton = true;
            this.helpProvider1.SetHelpString(this, "Insira o nome do requesitante a apagar, caso não seja isso que quer fazer clique " +
                    "em cancelar");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Apagar_Requesitantes";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Apagar_Requesitantes";
            this.Load += new System.EventHandler(this.Apagar_Requesitantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitadoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource requisitadoresBindingSource;
        private Database1DataSetTableAdapters.RequisitadoresTableAdapter requisitadoresTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}