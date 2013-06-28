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
    public partial class EliminarSala : Form
    {
        public EliminarSala()
        {
            InitializeComponent();
        }

        

        private void salasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void EliminarReqSala_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Salas' table. You can move, or remove it, as needed.
            this.salasTableAdapter.Fill(this.database1DataSet.Salas);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                this.salasTableAdapter.DeleteSala(Convert.ToInt16(this.salaComboBox.SelectedValue));
                MessageBox.Show("Eliminado com Sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Sala ocupada");
            }
        }
    }
}
