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
            // TODO: This line of code loads data into the 'database1DataSet.DataMaterial' table. You can move, or remove it, as needed.
            //this.dataMaterialTableAdapter.Fill(this.database1DataSet.DataMaterial);
            // TODO: This line of code loads data into the 'database1DataSet.DataMaterial' table. You can move, or remove it, as needed.
            //this.dataMaterialTableAdapter.Fill(this.database1DataSet.DataMaterial);
            // TODO: This line of code loads data into the 'database1DataSet.DataMaterial' table. You can move, or remove it, as needed.
           // this.dataMaterialTableAdapter.Fill(this.database1DataSet.DataMaterial);
            // TODO: This line of code loads data into the 'database1DataSet.Curso' table. You can move, or remove it, as needed.
           // this.cursoTableAdapter.Fill(this.database1DataSet.Curso);
            // TODO: This line of code loads data into the 'database1DataSet.Categoria' table. You can move, or remove it, as needed.
            //this.categoriaTableAdapter.Fill(this.database1DataSet.Categoria);
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

                if (designacaoTextBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Tem de inserir o nome do material");
                }
                else
                {
                  

                 // this.materialTableAdapter.Insert(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, Convert.ToInt16(this.comboBox1.SelectedValue), Convert.ToInt16(this.comboBox2.SelectedValue));
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (designacaoTextBox.Text == "")
            {
                errorProvider1.SetError(designacaoTextBox, "Necessario inserir");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            //if (textBox2.Text == "")
            //{
            //   errorProvider1.SetError(textBox2, "Necessario inserir");
            //}
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            //if (textBox3.Text == "")
            //{
            //    errorProvider1.SetError(textBox3, "Necessario inserir");
            //}
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void materialBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

       
        
    }
}
