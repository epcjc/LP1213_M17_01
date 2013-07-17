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
    public partial class Relatórios : Form
    {
        public Relatórios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RelatMaterial frm = new RelatMaterial();
            frm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RelatHorario frm = new RelatHorario();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RelatReqSalas frm = new RelatReqSalas();
            frm.ShowDialog();
           
        }
    }
}
