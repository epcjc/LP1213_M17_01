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
    public partial class InserirReqSala : Form
    {
        public InserirReqSala()
        {
            InitializeComponent();
        }

        private void requisições_SalasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requisições_SalasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void InserirReqSala_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.database1DataSet.Professores);
            // TODO: This line of code loads data into the 'database1DataSet.Horas' table. You can move, or remove it, as needed.
            this.horasTableAdapter.Fill(this.database1DataSet.Horas);
            // TODO: This line of code loads data into the 'database1DataSet.Salas' table. You can move, or remove it, as needed.
            this.salasTableAdapter.Fill(this.database1DataSet.Salas);
            // TODO: This line of code loads data into the 'database1DataSet.Requisições_Salas' table. You can move, or remove it, as needed.
            this.requisições_SalasTableAdapter.Fill(this.database1DataSet.Requisições_Salas);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                this.requisições_SalasTableAdapter.Insert(Convert.ToInt16(this.comboBox1.SelectedValue), Convert.ToInt16(this.comboBox2.SelectedValue), Convert.ToInt16(this.comboBox3.SelectedValue), this.observacoesTextBox.Text);
                MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
