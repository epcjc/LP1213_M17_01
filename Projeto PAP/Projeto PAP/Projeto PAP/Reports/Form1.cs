using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Projeto_PAP.Reports
{
    public partial class Form1 : Form
    {
        public string designacao;
        public string data;
        public string nome;
        public string notas;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReportParameter p1 = new ReportParameter("DesignacaoMaterial", designacao);
            ReportParameter p2 = new ReportParameter("Notas", notas);
            ReportParameter p3 = new ReportParameter("Professor", nome);
            ReportParameter p4 = new ReportParameter("Data", data);


            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1, p2, p3, p4 });
            

            this.reportViewer1.RefreshReport();
        }
    }
}
