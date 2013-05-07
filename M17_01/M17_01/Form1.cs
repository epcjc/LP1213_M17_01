using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace M17_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database11DataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.database11DataSet.Material);
            // TODO: This line of code loads data into the 'database11DataSet.Salas' table. You can move, or remove it, as needed.
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

       
    }
}
