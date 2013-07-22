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
    public partial class PesqNomeReq : Form
    {
        public PesqNomeReq()
        {
            InitializeComponent();
        }

        //private void requisitadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.requisitadoresBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.database1DataSet);

        //}

        private void PesqNomeReq_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        //private void requisitadoresBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.requisitadoresBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.database1DataSet);

        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void requisitadoresBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.requisitadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void requisitadoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
