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
            this.horasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.HorasTableAdapter();
            this.salasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.SalasTableAdapter();
            this.semanaTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.SemanaTableAdapter();
            this.turmasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.TurmasTableAdapter();
            this.iD_HorarioComboBox = new System.Windows.Forms.ComboBox();
            this.iD_TempoComboBox = new System.Windows.Forms.ComboBox();
            this.horasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_SemanaComboBox = new System.Windows.Forms.ComboBox();
            this.semanaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_TurmaComboBox = new System.Windows.Forms.ComboBox();
            this.turmasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_SalaComboBox = new System.Windows.Forms.ComboBox();
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            iD_HorarioLabel = new System.Windows.Forms.Label();
            iD_TempoLabel = new System.Windows.Forms.Label();
            iD_SemanaLabel = new System.Windows.Forms.Label();
            iD_TurmaLabel = new System.Windows.Forms.Label();
            iD_SalaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horario_SalasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semanaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_HorarioLabel
            // 
            iD_HorarioLabel.AutoSize = true;
            iD_HorarioLabel.Location = new System.Drawing.Point(7, 11);
            iD_HorarioLabel.Name = "iD_HorarioLabel";
            iD_HorarioLabel.Size = new System.Drawing.Size(59, 13);
            iD_HorarioLabel.TabIndex = 0;
            iD_HorarioLabel.Text = "Nº Horario:";
            // 
            // iD_TempoLabel
            // 
            iD_TempoLabel.AutoSize = true;
            iD_TempoLabel.Location = new System.Drawing.Point(7, 38);
            iD_TempoLabel.Name = "iD_TempoLabel";
            iD_TempoLabel.Size = new System.Drawing.Size(43, 13);
            iD_TempoLabel.TabIndex = 2;
            iD_TempoLabel.Text = "Tempo:";
            // 
            // iD_SemanaLabel
            // 
            iD_SemanaLabel.AutoSize = true;
            iD_SemanaLabel.Location = new System.Drawing.Point(7, 65);
            iD_SemanaLabel.Name = "iD_SemanaLabel";
            iD_SemanaLabel.Size = new System.Drawing.Size(49, 13);
            iD_SemanaLabel.TabIndex = 4;
            iD_SemanaLabel.Text = "Semana:";
            // 
            // iD_TurmaLabel
            // 
            iD_TurmaLabel.AutoSize = true;
            iD_TurmaLabel.Location = new System.Drawing.Point(7, 92);
            iD_TurmaLabel.Name = "iD_TurmaLabel";
            iD_TurmaLabel.Size = new System.Drawing.Size(40, 13);
            iD_TurmaLabel.TabIndex = 6;
            iD_TurmaLabel.Text = "Turma:";
            // 
            // iD_SalaLabel
            // 
            iD_SalaLabel.AutoSize = true;
            iD_SalaLabel.Location = new System.Drawing.Point(7, 119);
            iD_SalaLabel.Name = "iD_SalaLabel";
            iD_SalaLabel.Size = new System.Drawing.Size(31, 13);
            iD_SalaLabel.TabIndex = 8;
            iD_SalaLabel.Text = "Sala:";
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
            // iD_HorarioComboBox
            // 
            this.iD_HorarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horario_SalasBindingSource, "ID_Horario", true));
            this.iD_HorarioComboBox.DataSource = this.horario_SalasBindingSource;
            this.iD_HorarioComboBox.DisplayMember = "ID_Horario";
            this.iD_HorarioComboBox.FormattingEnabled = true;
            this.iD_HorarioComboBox.Location = new System.Drawing.Point(76, 8);
            this.iD_HorarioComboBox.Name = "iD_HorarioComboBox";
            this.iD_HorarioComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_HorarioComboBox.TabIndex = 1;
            this.iD_HorarioComboBox.ValueMember = "ID_Horario";
            // 
            // iD_TempoComboBox
            // 
            this.iD_TempoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horario_SalasBindingSource, "ID_Tempo", true));
            this.iD_TempoComboBox.DataSource = this.horasBindingSource;
            this.iD_TempoComboBox.DisplayMember = "Hora_Inicio";
            this.iD_TempoComboBox.FormattingEnabled = true;
            this.iD_TempoComboBox.Location = new System.Drawing.Point(76, 35);
            this.iD_TempoComboBox.Name = "iD_TempoComboBox";
            this.iD_TempoComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_TempoComboBox.TabIndex = 3;
            this.iD_TempoComboBox.ValueMember = "ID_Tempo";
            // 
            // horasBindingSource
            // 
            this.horasBindingSource.DataMember = "Horas";
            this.horasBindingSource.DataSource = this.database1DataSet;
            // 
            // iD_SemanaComboBox
            // 
            this.iD_SemanaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horario_SalasBindingSource, "ID_Semana", true));
            this.iD_SemanaComboBox.DataSource = this.semanaBindingSource;
            this.iD_SemanaComboBox.DisplayMember = "Dia_Semana";
            this.iD_SemanaComboBox.FormattingEnabled = true;
            this.iD_SemanaComboBox.Location = new System.Drawing.Point(76, 62);
            this.iD_SemanaComboBox.Name = "iD_SemanaComboBox";
            this.iD_SemanaComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_SemanaComboBox.TabIndex = 5;
            this.iD_SemanaComboBox.ValueMember = "ID_Semana";
            // 
            // semanaBindingSource
            // 
            this.semanaBindingSource.DataMember = "Semana";
            this.semanaBindingSource.DataSource = this.database1DataSet;
            // 
            // iD_TurmaComboBox
            // 
            this.iD_TurmaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horario_SalasBindingSource, "ID_Turma", true));
            this.iD_TurmaComboBox.DataSource = this.turmasBindingSource;
            this.iD_TurmaComboBox.DisplayMember = "Turma";
            this.iD_TurmaComboBox.FormattingEnabled = true;
            this.iD_TurmaComboBox.Location = new System.Drawing.Point(76, 89);
            this.iD_TurmaComboBox.Name = "iD_TurmaComboBox";
            this.iD_TurmaComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_TurmaComboBox.TabIndex = 7;
            this.iD_TurmaComboBox.ValueMember = "ID_Turma";
            // 
            // turmasBindingSource
            // 
            this.turmasBindingSource.DataMember = "Turmas";
            this.turmasBindingSource.DataSource = this.database1DataSet;
            // 
            // iD_SalaComboBox
            // 
            this.iD_SalaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horario_SalasBindingSource, "ID_Sala", true));
            this.iD_SalaComboBox.DataSource = this.salasBindingSource;
            this.iD_SalaComboBox.DisplayMember = "Sala";
            this.iD_SalaComboBox.FormattingEnabled = true;
            this.iD_SalaComboBox.Location = new System.Drawing.Point(76, 116);
            this.iD_SalaComboBox.Name = "iD_SalaComboBox";
            this.iD_SalaComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_SalaComboBox.TabIndex = 9;
            this.iD_SalaComboBox.ValueMember = "ID_Sala";
            // 
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "Salas";
            this.salasBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.splitContainer1.Panel1.Controls.Add(iD_HorarioLabel);
            this.splitContainer1.Panel1.Controls.Add(this.iD_SalaComboBox);
            this.splitContainer1.Panel1.Controls.Add(iD_SalaLabel);
            this.splitContainer1.Panel1.Controls.Add(this.iD_TurmaComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.iD_HorarioComboBox);
            this.splitContainer1.Panel1.Controls.Add(iD_TurmaLabel);
            this.splitContainer1.Panel1.Controls.Add(iD_TempoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.iD_SemanaComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.iD_TempoComboBox);
            this.splitContainer1.Panel1.Controls.Add(iD_SemanaLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(338, 203);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(338, 48);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 181);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(338, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // EliminarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 203);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "EliminarHorario";
            this.Text = "EliminarHorario";
            this.Load += new System.EventHandler(this.EliminarHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horario_SalasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semanaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}