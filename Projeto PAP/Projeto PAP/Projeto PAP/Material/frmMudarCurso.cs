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
    public partial class frmMudarCurso : Form
    {
        public int Id_curso { get; set; }
        public string Curso { get; set; }

        public frmMudarCurso()
        {
            InitializeComponent();
        }

        private void frmMudarCurso_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.Fill(this.database1DataSet.Curso);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Id_curso = Convert.ToInt32(this.listBox1.SelectedValue);

            DataRowView drv = (DataRowView) this.listBox1.SelectedItem;

            Curso = drv["Curso"].ToString();

            this.Close();
        }
    }
}
