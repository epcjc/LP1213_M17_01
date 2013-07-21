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
    public partial class frmMudarAutorizados : Form
    {
        private Dictionary<string, int> _lista = new Dictionary<string, int>();

        public Dictionary<string, int> Lista
        {
            get { return _lista; }
        }


        public frmMudarAutorizados()
        {
            InitializeComponent();
        }

        

        private void frmMudarAutorizados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.database1DataSet.Professores);

            this.listBox1.SelectedItems.Clear();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            DataRowView drv;
            foreach (var item in listBox1.SelectedItems)
            {
                drv = (DataRowView) item;
                _lista.Add(drv["Nome_Professor"].ToString(), Convert.ToInt32(drv["ID_Professor"]));
            }
        }
    }
}
