using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_PAP
{
    public partial class RealatorioRequisicaomaterialcs : Form
    {
        public RealatorioRequisicaomaterialcs()
        {
            InitializeComponent();
        }

        private void RealatorioRequisicaomaterialcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.ConsultaRequisicaomaterial' table. You can move, or remove it, as needed.
            this.ConsultaRequisicaomaterialTableAdapter.Fill(this.Database1DataSet.ConsultaRequisicaomaterial);

            this.reportViewer1.RefreshReport();
        }
    }
}
