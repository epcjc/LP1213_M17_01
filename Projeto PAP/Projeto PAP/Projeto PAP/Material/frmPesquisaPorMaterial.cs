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
    public partial class frmPesquisaPorMaterial : Form
    {
        public frmPesquisaPorMaterial()
        {
            InitializeComponent();
        }

        private void frmPesquisaPorMaterial_Load(object sender, EventArgs e)
        {
           
            
            // TODO: This line of code loads data into the 'database1DataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.database1DataSet.Material);
            // TODO: This line of code loads data into the 'database1DataSet.HistoricoRequisicoes' table. You can move, or remove it, as needed.
            this.historicoRequisicoesTableAdapter.FillByIdMaterial(this.database1DataSet.HistoricoRequisicoes, Convert.ToInt32(this.comboBox1.SelectedValue));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.historicoRequisicoesTableAdapter.FillByIdMaterial(this.database1DataSet.HistoricoRequisicoes, Convert.ToInt32(this.comboBox1.SelectedValue));
        }
    }
}
