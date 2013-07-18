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
    public partial class PesquisarMaterial : Form
    {
        public PesquisarMaterial()
        {
            InitializeComponent();
        }

        private void PesquisarMaterial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ConsultasMaterial' table. You can move, or remove it, as needed.
            this.consultasMaterialTableAdapter.Fill(this.database1DataSet.ConsultasMaterial);

        }

        private void consultasMaterialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasMaterialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.consultasMaterialTableAdapter.FillByPesqCurso(this.database1DataSet.ConsultasMaterial, this.textBox1.Text);
        }
    }
}
