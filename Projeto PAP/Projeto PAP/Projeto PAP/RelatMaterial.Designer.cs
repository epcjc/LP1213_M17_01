﻿namespace Projeto_PAP
{
    partial class RelatMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatMaterial));
            this.MaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet = new Projeto_PAP.Database1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MaterialTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.MaterialTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MaterialBindingSource
            // 
            this.MaterialBindingSource.DataMember = "Material";
            this.MaterialBindingSource.DataSource = this.Database1DataSet;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MaterialBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_PAP.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(560, 324);
            this.reportViewer1.TabIndex = 0;
            // 
            // MaterialTableAdapter
            // 
            this.MaterialTableAdapter.ClearBeforeFill = true;
            // 
            // RelatMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 324);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatMaterial";
            this.Text = "RelatMaterial";
            this.Load += new System.EventHandler(this.RelatMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MaterialBindingSource;
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.MaterialTableAdapter MaterialTableAdapter;
    }
}