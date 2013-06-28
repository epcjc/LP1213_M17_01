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
    public partial class Apagar_Requesitantes : Form
    {
        public Apagar_Requesitantes()
        {
            InitializeComponent();
        }
        private void requisitadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requisitadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Apagar_Requesitantes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Requisitadores' table. You can move, or remove it, as needed.
            this.requisitadoresTableAdapter.Fill(this.database1DataSet.Requisitadores);

        }
        private void button2_Click(object sender, EventArgs e)
        {
           // ((Form4)this.Parent).requisitadoresDataGridView.Update();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                this.requisitadoresTableAdapter.DeleteQuery(Convert.ToInt16(this.comboBox1.SelectedValue));
                this.Close();
            }
            catch (Exception )
            {
                MessageBox.Show("Professor com requisição");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nome_RequisitadorLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
