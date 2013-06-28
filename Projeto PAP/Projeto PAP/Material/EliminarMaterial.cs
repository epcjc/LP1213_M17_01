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
    public partial class EliminarMaterial : Form
    {
        public EliminarMaterial()
        {
            InitializeComponent();
        }

        private void materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void EliminarMaterial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.database1DataSet.Material);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.materialTableAdapter.DeleteMaterial(Convert.ToInt16(this.comboBox1.SelectedValue));
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Material ocupado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
