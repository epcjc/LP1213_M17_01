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
    public partial class RelatMaterial : Form
    {
        public RelatMaterial()
        {
            InitializeComponent();
        }

        private void RelatMaterial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Material' table. You can move, or remove it, as needed.
            this.MaterialTableAdapter.Fill(this.Database1DataSet.Material);

            this.reportViewer1.RefreshReport();
        }
    }
}
