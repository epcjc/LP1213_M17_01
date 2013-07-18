namespace Projeto_PAP
{
    partial class RealatorioRequisicaomaterialcs
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
            this.ConsultaRequisicaomaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet = new Projeto_PAP.Database1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ConsultaRequisicaomaterialTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.ConsultaRequisicaomaterialTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaRequisicaomaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaRequisicaomaterialBindingSource
            // 
            this.ConsultaRequisicaomaterialBindingSource.DataMember = "ConsultaRequisicaomaterial";
            this.ConsultaRequisicaomaterialBindingSource.DataSource = this.Database1DataSet;
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
            reportDataSource1.Value = this.ConsultaRequisicaomaterialBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_PAP.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(292, 272);
            this.reportViewer1.TabIndex = 0;
            // 
            // ConsultaRequisicaomaterialTableAdapter
            // 
            this.ConsultaRequisicaomaterialTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 250);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(292, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // RealatorioRequisicaomaterialcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 272);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RealatorioRequisicaomaterialcs";
            this.Text = "Requisicao Material";
            this.Load += new System.EventHandler(this.RealatorioRequisicaomaterialcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaRequisicaomaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ConsultaRequisicaomaterialBindingSource;
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.ConsultaRequisicaomaterialTableAdapter ConsultaRequisicaomaterialTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}