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
    public partial class InserirReq : Form
    {
        public InserirReq()
        {
            InitializeComponent();
        }

        private void InserirReq_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.RequisiçõesMaterial' table. You can move, or remove it, as needed.
            this.requisiçõesMaterialTableAdapter.Fill(this.database1DataSet.RequisiçõesMaterial);
            // TODO: This line of code loads data into the 'database1DataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.database1DataSet.Material);
            // TODO: This line of code loads data into the 'database1DataSet.Requisitadores' table. You can move, or remove it, as needed.
            this.requisitadoresTableAdapter.Fill(this.database1DataSet.Requisitadores);
            // TODO: This line of code loads data into the 'database1DataSet.DataTable1' table. You can move, or remove it, as needed.
            //this.dataTable1TableAdapter.FillRequi_Material(this.database1DataSet.DataTable1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                this.requisiçõesMaterialTableAdapter.Insert(Convert.ToInt32(this.comboBox1.SelectedValue), this.textBox2.Text, this.textBox3.Text, this.textBox4.Text, Convert.ToInt32(this.comboBox2.SelectedValue), this.textBox6.Text, this.textBox7.Text, this.observacoes_Antes_requisicaoTextBox.Text, this.observacoes_apos_requisicaoTextBox.Text, this.estadoTextBox.Text);

                MessageBox.Show("Inserido com Sucesso");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro!");
            }

        }

        
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Necessario inserir");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == "")
            {
                errorProvider2.SetError(textBox3, "Necessario inserir");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text == "")
            {
                errorProvider2.SetError(textBox4, "Necessario inserir");
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (textBox6.Text == "")
            {
                errorProvider2.SetError(textBox6, "Necessario inserir");
            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            if (textBox7.Text == "")
            {
                errorProvider1.SetError(textBox7, "Necessario inserir");
            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            if (observacoes_Antes_requisicaoTextBox.Text == "")
            {
                errorProvider1.SetError(observacoes_Antes_requisicaoTextBox, "Necessario inserir");
            }
        }

        private void observacoes_apos_requisicaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
