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
    public partial class PesqMaterial : Form
    {
        public PesqMaterial()
        {
            InitializeComponent();
        }

        
        private void PesqMaterial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Material' table. You can move, or remove it, as needed.
           // this.materialTableAdapter.Fill(this.database1DataSet.Material);
            // TODO: This line of code loads data into the 'database1DataSet.DataTable1' table. You can move, or remove it, as needed.
          //  this.dataTable1TableAdapter.Fill(this.database1DataSet.DataTable1);
            // TODO: This line of code loads data into the 'database1DataSet.ConsultasMaterial' table. You can move, or remove it, as needed.
           this.consultasMaterialTableAdapter.Fill(this.database1DataSet.ConsultasMaterial);
            // TODO: This line of code loads data into the 'database1DataSet.ConsultasMaterial' table. You can move, or remove it, as needed.
            this.consultasMaterialTableAdapter.Fill(this.database1DataSet.ConsultasMaterial);
            // TODO: This line of code loads data into the 'database1DataSet.Material' table. You can move, or remove it, as needed.
            //this.materialTableAdapter.Fill(this.database1DataSet.Material);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.consultasMaterialTableAdapter.FillByPesqCurso(this.database1DataSet.ConsultasMaterial, this.textBox1.Text);
          
        }

        private void consultasMaterialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasMaterialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }

        private void consultasMaterialBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
