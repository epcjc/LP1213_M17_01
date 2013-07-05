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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void requisitadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requisitadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Requisitadores' table. You can move, or remove it, as needed.
            this.requisitadoresTableAdapter.Fill(this.database1DataSet.Requisitadores);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Inserir nome");

                }
                else
                {
                    this.requisitadoresTableAdapter.Insert(this.textBox1.Text, this.textBox2.Text);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
