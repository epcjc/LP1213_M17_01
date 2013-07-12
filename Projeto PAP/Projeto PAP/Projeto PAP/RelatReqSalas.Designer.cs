namespace Projeto_PAP
{
    partial class RelatReqSalas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatReqSalas));
            this.SalasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet = new Projeto_PAP.Database1DataSet();
            this.rEqSalasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SalasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.SalasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SalasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEqSalasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SalasBindingSource
            // 
            this.SalasBindingSource.DataMember = "Salas";
            this.SalasBindingSource.DataSource = this.Database1DataSet;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEqSalasBindingSource
            // 
            this.rEqSalasBindingSource.DataMember = "REq.Salas";
            this.rEqSalasBindingSource.DataSource = this.Database1DataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SalasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_PAP.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(439, 272);
            this.reportViewer1.TabIndex = 0;
            // 
            // SalasTableAdapter
            // 
            this.SalasTableAdapter.ClearBeforeFill = true;
            // 
            // RelatReqSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 272);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatReqSalas";
            this.Text = "RelatReqSalas";
            this.Load += new System.EventHandler(this.RelatReqSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEqSalasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet Database1DataSet;
        private System.Windows.Forms.BindingSource rEqSalasBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalasBindingSource;
        private Database1DataSetTableAdapters.SalasTableAdapter SalasTableAdapter;
    }
}