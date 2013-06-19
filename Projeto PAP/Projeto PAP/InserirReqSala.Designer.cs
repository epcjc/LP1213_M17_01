﻿namespace Projeto_PAP
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
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.requisições_SalasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requisições_SalasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.Requisições_SalasTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.SalasTableAdapter();
            this.horasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.HorasTableAdapter();
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professoresTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.ProfessoresTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            iD_SalaLabel = new System.Windows.Forms.Label();
            iD_TempoLabel = new System.Windows.Forms.Label();
            iD_ProfessorLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisições_SalasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // iD_SalaLabel
            // 
            iD_SalaLabel.AutoSize = true;
            iD_SalaLabel.Location = new System.Drawing.Point(12, 30);
            iD_SalaLabel.Name = "iD_SalaLabel";
            iD_SalaLabel.Size = new System.Drawing.Size(31, 13);
            iD_SalaLabel.TabIndex = 3;
            iD_SalaLabel.Text = "Sala:";
            // 
            // iD_TempoLabel
            // 
            iD_TempoLabel.AutoSize = true;
            iD_TempoLabel.Location = new System.Drawing.Point(12, 56);
            iD_TempoLabel.Name = "iD_TempoLabel";
            iD_TempoLabel.Size = new System.Drawing.Size(43, 13);
            iD_TempoLabel.TabIndex = 5;
            iD_TempoLabel.Text = "Tempo:";
            // 
            // iD_ProfessorLabel
            // 
            iD_ProfessorLabel.AutoSize = true;
            iD_ProfessorLabel.Location = new System.Drawing.Point(12, 82);
            iD_ProfessorLabel.Name = "iD_ProfessorLabel";
            iD_ProfessorLabel.Size = new System.Drawing.Size(54, 13);
            iD_ProfessorLabel.TabIndex = 7;
            iD_ProfessorLabel.Text = "Professor:";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Location = new System.Drawing.Point(12, 108);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(73, 13);
            observacoesLabel.TabIndex = 9;
            observacoesLabel.Text = "Observacoes:";
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requisições_SalasBindingSource, "Observacoes", true));
            this.observacoesTextBox.Location = new System.Drawing.Point(91, 105);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(146, 51);
            this.observacoesTextBox.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.salasBindingSource;
            this.comboBox1.DisplayMember = "Sala";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "ID_Sala";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.horasBindingSource;
            this.comboBox2.DisplayMember = "Hora_Inicio";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(91, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.ValueMember = "ID_Tempo";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.professoresBindingSource;
            this.comboBox3.DisplayMember = "Nome_Professor";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(91, 78);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(146, 21);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.ValueMember = "ID_Professor";
            // 
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "Salas";
            this.salasBindingSource.DataSource = this.database1DataSet;
            // 
            // salasTableAdapter
            // 
            this.salasTableAdapter.ClearBeforeFill = true;
            // 
            // horasBindingSource
            // 
            this.horasBindingSource.DataMember = "Horas";
            this.horasBindingSource.DataSource = this.database1DataSet;
            // 
            // horasTableAdapter
            // 
            this.horasTableAdapter.ClearBeforeFill = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InserirReqSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 245);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(iD_SalaLabel);
            this.Controls.Add(iD_TempoLabel);
            this.Controls.Add(iD_ProfessorLabel);
            this.Controls.Add(observacoesLabel);
            this.Controls.Add(this.observacoesTextBox);
            this.Name = "InserirReqSala";
            this.Text = "InserirReqSala";
            this.Load += new System.EventHandler(this.InserirReqSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisições_SalasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}