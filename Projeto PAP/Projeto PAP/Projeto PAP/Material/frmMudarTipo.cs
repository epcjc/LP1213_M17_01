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
    public partial class frmMudarTipo : Form
    {

        public int Id_tipo { get; set; }
        public string Tipo { get; set; }


        public frmMudarTipo()
        {
            InitializeComponent();
        }

        private void frmMudarTipo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.database1DataSet.Categoria);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Id_tipo = Convert.ToInt32(this.listBox1.SelectedValue);

            DataRowView drv = (DataRowView)this.listBox1.SelectedItem;

            Tipo = drv["categoria"].ToString();

            this.Close();
        }
    }
}
