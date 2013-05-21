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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }



        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database11DataSet.Requisiçoes_material' table. You can move, or remove it, as needed.
            this.requisiçoes_materialTableAdapter.Fill(this.database11DataSet.Requisiçoes_material);

        }

        private void requisiçoes_materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requisiçoes_materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database11DataSet);

        }

    }        
}
