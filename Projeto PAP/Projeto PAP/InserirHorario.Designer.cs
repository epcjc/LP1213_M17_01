﻿namespace Projeto_PAP
{
    partial class InserirHorario
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
            this.horario_SalasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horario_SalasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.Horario_SalasTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.horasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.HorasTableAdapter();
            this.salasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.SalasTableAdapter();
            this.semanaTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.SemanaTableAdapter();
            this.turmasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.TurmasTableAdapter();
            this.horasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semanaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turmasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horario_SalasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semanaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).BeginInit();
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
            // horasBindingSource
            // 
            this.horasBindingSource.DataMember = "Horas";
            this.horasBindingSource.DataSource = this.database1DataSet;
            // 
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "Salas";
            this.salasBindingSource.DataSource = this.database1DataSet;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Turma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sala";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.horasBindingSource;
            this.comboBox1.DisplayMember = "Hora_Inicio";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "ID_Tempo";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.semanaBindingSource;
            this.comboBox2.DisplayMember = "Dia_Semana";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(77, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "ID_Semana";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.turmasBindingSource;
            this.comboBox3.DisplayMember = "Turma";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(77, 105);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.ValueMember = "ID_Turma";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.salasBindingSource;
            this.comboBox4.DisplayMember = "Sala";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(77, 136);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 7;
            this.comboBox4.ValueMember = "ID_Sala";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InserirHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 228);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InserirHorario";
            this.Text = "InserirHorario";
            this.Load += new System.EventHandler(this.InserirHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horario_SalasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semanaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource horario_SalasBindingSource;
        private Database1DataSetTableAdapters.Horario_SalasTableAdapter horario_SalasTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.HorasTableAdapter horasTableAdapter;
        private System.Windows.Forms.BindingSource horasBindingSource;
        private Database1DataSetTableAdapters.SalasTableAdapter salasTableAdapter;
        private System.Windows.Forms.BindingSource salasBindingSource;
        private Database1DataSetTableAdapters.SemanaTableAdapter semanaTableAdapter;
        private System.Windows.Forms.BindingSource semanaBindingSource;
        private Database1DataSetTableAdapters.TurmasTableAdapter turmasTableAdapter;
        private System.Windows.Forms.BindingSource turmasBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}