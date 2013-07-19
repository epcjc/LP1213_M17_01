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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
          
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            Relatórios frm = new Relatórios();
            frm.ShowDialog();
        }

        
        private void FrmPrincipal_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            TiposMaterial frm = new TiposMaterial();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

       
       
    }
}
