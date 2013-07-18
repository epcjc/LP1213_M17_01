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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.database1DataSet.Categoria);
            // TODO: This line of code loads data into the 'database1DataSet.DataMaterial' table. You can move, or remove it, as needed.
           // this.dataMaterialTableAdapter.Fill(this.database1DataSet.DataMaterial);



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

  


    }
}
