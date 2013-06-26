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
    public partial class Form1 : Form
    {
        
        public void atualizarDataGrid()
        {
            this.materialTableAdapter.Fill(this.database1DataSet.Material);
            this.materialDataGridView.Refresh();
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.database1DataSet.Material);
           

        }

        private void materialBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            atualizarDataGrid();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PesqMaterial frm = new PesqMaterial();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EliminarMaterial frm = new EliminarMaterial();
            frm.ShowDialog();
        }

       

        

      

      
    }
}
