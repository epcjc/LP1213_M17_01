namespace Projeto_PAP
{
    partial class EliminarHorario
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
            System.Windows.Forms.Label iD_HorarioLabel;
            System.Windows.Forms.Label iD_TempoLabel;
            System.Windows.Forms.Label iD_SemanaLabel;
            System.Windows.Forms.Label iD_TurmaLabel;
            System.Windows.Forms.Label iD_SalaLabel;
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.horario_SalasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horario_SalasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.Horario_SalasTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.iD_HorarioComboBox = new System.Windows.Forms.ComboBox();
            this.iD_TempoComboBox = new System.Windows.Forms.ComboBox();
            this.iD_SemanaComboBox = new System.Windows.Forms.ComboBox();
            this.iD_TurmaComboBox = new System.Windows.Forms.ComboBox();
            this.iD_SalaComboBox = new System.Windows.Forms.ComboBox();
            this.horasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.HorasTableAdapter();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semanaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semanaTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.SemanaTableAdapter();
            this.turmasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turmasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.TurmasTableAdapter();
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.SalasTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            iD_HorarioLabel = new System.Windows.Forms.Label();
            iD_TempoLabel = new System.Windows.Forms.Label();
            iD_SemanaLabel = new System.Windows.Forms.Label();
            iD_TurmaLabel = new System.Windows.Forms.Label();
            iD_SalaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horario_SalasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
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
            // iD_HorarioLabel
            // 
            iD_HorarioLabel.AutoSize = true;
            iD_HorarioLabel.Location = new System.Drawing.Point(11, 15);
            iD_HorarioLabel.Name = "iD_HorarioLabel";
            iD_HorarioLabel.Size = new System.Drawing.Size(59, 13);
            iD_HorarioLabel.TabIndex = 0;
            iD_HorarioLabel.Text = "Nº Horario:";
            // 
            // iD_HorarioComboBox
            // 
            this.iD_HorarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horario_SalasBindingSource, "ID_Horario", true));
            this.iD_HorarioComboBox.DataSource = this.horario_SalasBindingSource;
            this.iD_HorarioComboBox.DisplayMember = "ID_Horario";
            this.iD_HorarioComboBox.FormattingEnabled = true;
            this.iD_HorarioComboBox.Location = new System.Drawing.Point(80, 12);
            this.iD_HorarioComboBox.Name = "iD_HorarioComboBox";
            this.iD_HorarioComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_HorarioComboBox.TabIndex = 1;
            this.iD_HorarioComboBox.ValueMember = "ID_Horario";
            // 
            // iD_TempoLabel
            // 
            iD_TempoLabel.AutoSize = true;
            iD_TempoLabel.Location = new System.Drawing.Point(11, 42);
            iD_TempoLabel.Name = "iD_TempoLabel";
            iD_TempoLabel.Size = new System.Drawing.Size(43, 13);
            iD_TempoLabel.TabIndex = 2;
            iD_TempoLabel.Text = "Tempo:";
            // 
            // iD_TempoComboBox
            // 
            this.iD_TempoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horario_SalasBindingSource, "ID_Tempo", true));
            this.iD_TempoComboBox.DataSource = this.horasBindingSource;
            this.iD_TempoComboBox.DisplayMember = "Hora_Inicio";
            this.iD_TempoComboBox.FormattingEnabled = true;
            this.iD_TempoComboBox.Location = new System.Drawing.Point(80, 39);
            this.iD_TempoComboBox.Name = "iD_TempoComboBox";
            this.iD_TempoComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_TempoComboBox.TabIndex = 3;
            this.iD_TempoComboBox.ValueMember = "ID_Tempo";
            // 
            // iD_SemanaLabel
            // 
            iD_SemanaLabel.AutoSize = true;
            iD_SemanaLabel.Location = new System.Drawing.Point(11, 69);
            iD_SemanaLabel.Name = "iD_SemanaLabel";
            iD_SemanaLabel.Size = new System.Drawing.Size(49, 13);
            iD_SemanaLabel.TabIndex = 4;
            iD_SemanaLabel.Text = "Semana:";
            // 
            // iD_SemanaComboBox
            // 
            this.iD_SemanaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horario_SalasBindingSource, "ID_Semana", true));
            this.iD_SemanaComboBox.DataSource = this.semanaBindingSource;
            this.iD_SemanaComboBox.DisplayMember = "Dia_Semana";
            this.iD_SemanaComboBox.FormattingEnabled = true;
            this.iD_SemanaComboBox.Location = new System.Drawing.Point(80, 66);
            this.iD_SemanaComboBox.Name = "iD_SemanaComboBox";
            this.iD_SemanaComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_SemanaComboBox.TabIndex = 5;
            this.iD_SemanaComboBox.ValueMember = "ID_Semana";
            // 
            // iD_TurmaLabel
            // 
            iD_TurmaLabel.AutoSize = true;
            iD_TurmaLabel.Location = new System.Drawing.Point(11, 96);
            iD_TurmaLabel.Name = "iD_TurmaLabel";
            iD_TurmaLabel.Size = new System.Drawing.Size(40, 13);
            iD_TurmaLabel.TabIndex = 6;
            iD_TurmaLabel.Text = "Turma:";
            // 
            // iD_TurmaComboBox
            // 
            this.iD_TurmaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horario_SalasBindingSource, "ID_Turma", true));
            this.iD_TurmaComboBox.DataSource = this.turmasBindingSource;
            this.iD_TurmaComboBox.DisplayMember = "Turma";
            this.iD_TurmaComboBox.FormattingEnabled = true;
            this.iD_TurmaComboBox.Location = new System.Drawing.Point(80, 93);
            this.iD_TurmaComboBox.Name = "iD_TurmaComboBox";
            this.iD_TurmaComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_TurmaComboBox.TabIndex = 7;
            this.iD_TurmaComboBox.ValueMember = "ID_Turma";
            // 
            // iD_SalaLabel
            // 
            iD_SalaLabel.AutoSize = true;
            iD_SalaLabel.Location = new System.Drawing.Point(11, 123);
            iD_SalaLabel.Name = "iD_SalaLabel";
            iD_SalaLabel.Size = new System.Drawing.Size(31, 13);
            iD_SalaLabel.TabIndex = 8;
            iD_SalaLabel.Text = "Sala:";
            // 
            // iD_SalaComboBox
            // 
            this.iD_SalaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horario_SalasBindingSource, "ID_Sala", true));
            this.iD_SalaComboBox.DataSource = this.salasBindingSource;
            this.iD_SalaComboBox.DisplayMember = "Sala";
            this.iD_SalaComboBox.FormattingEnabled = true;
            this.iD_SalaComboBox.Location = new System.Drawing.Point(80, 120);
            this.iD_SalaComboBox.Name = "iD_SalaComboBox";
            this.iD_SalaComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_SalaComboBox.TabIndex = 9;
            this.iD_SalaComboBox.ValueMember = "ID_Sala";
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
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // semanaBindingSource
            // 
            this.semanaBindingSource.DataMember = "Semana";
            this.semanaBindingSource.DataSource = this.database1DataSet;
            // 
            // semanaTableAdapter
            // 
            this.semanaTableAdapter.ClearBeforeFill = true;
            // 
            // turmasBindingSource
            // 
            this.turmasBindingSource.DataMember = "Turmas";
            this.turmasBindingSource.DataSource = this.database1DataSet;
            // 
            // turmasTableAdapter
            // 
            this.turmasTableAdapter.ClearBeforeFill = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EliminarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 395);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_HorarioLabel);
            this.Controls.Add(this.iD_HorarioComboBox);
            this.Controls.Add(iD_TempoLabel);
            this.Controls.Add(this.iD_TempoComboBox);
            this.Controls.Add(iD_SemanaLabel);
            this.Controls.Add(this.iD_SemanaComboBox);
            this.Controls.Add(iD_TurmaLabel);
            this.Controls.Add(this.iD_TurmaComboBox);
            this.Controls.Add(iD_SalaLabel);
            this.Controls.Add(this.iD_SalaComboBox);
            this.Name = "EliminarHorario";
            this.Text = "EliminarHorario";
            this.Load += new System.EventHandler(this.EliminarHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horario_SalasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
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
        private Database1DataSetTableAdapters.HorasTableAdapter horasTableAdapter;
        private System.Windows.Forms.ComboBox iD_HorarioComboBox;
        private System.Windows.Forms.ComboBox iD_TempoComboBox;
        private System.Windows.Forms.ComboBox iD_SemanaComboBox;
        private System.Windows.Forms.ComboBox iD_TurmaComboBox;
        private System.Windows.Forms.ComboBox iD_SalaComboBox;
        private System.Windows.Forms.BindingSource horasBindingSource;
        private Database1DataSetTableAdapters.SemanaTableAdapter semanaTableAdapter;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.BindingSource semanaBindingSource;
        private Database1DataSetTableAdapters.TurmasTableAdapter turmasTableAdapter;
        private System.Windows.Forms.BindingSource turmasBindingSource;
        private Database1DataSetTableAdapters.SalasTableAdapter salasTableAdapter;
        private System.Windows.Forms.BindingSource salasBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}