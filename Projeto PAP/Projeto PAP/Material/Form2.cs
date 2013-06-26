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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.database1DataSet.Material);

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
                    MessageBox.Show("Tem de inserir o nome do material");
                }
                else
                {

                    this.materialTableAdapter.Insert(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text);
                    this.Close();
                }


                
                
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
        
    }
}
