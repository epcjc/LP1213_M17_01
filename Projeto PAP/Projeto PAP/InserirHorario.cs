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
    public partial class InserirHorario : Form
    {
        public InserirHorario()
        {
            InitializeComponent();
        }

        private void horario_SalasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.horario_SalasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void InserirHorario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.database1DataSet.Turmas);
            // TODO: This line of code loads data into the 'database1DataSet.Semana' table. You can move, or remove it, as needed.
            this.semanaTableAdapter.Fill(this.database1DataSet.Semana);
            // TODO: This line of code loads data into the 'database1DataSet.Salas' table. You can move, or remove it, as needed.
            this.salasTableAdapter.Fill(this.database1DataSet.Salas);
            // TODO: This line of code loads data into the 'database1DataSet.Horas' table. You can move, or remove it, as needed.
            this.horasTableAdapter.Fill(this.database1DataSet.Horas);
            // TODO: This line of code loads data into the 'database1DataSet.Horario_Salas' table. You can move, or remove it, as needed.
            this.horario_SalasTableAdapter.Fill(this.database1DataSet.Horario_Salas);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                this.horario_SalasTableAdapter.Insert(Convert.ToInt16(this.comboBox1.SelectedValue), Convert.ToInt16(this.comboBox2.SelectedValue), Convert.ToInt16(this.comboBox3.SelectedValue), Convert.ToInt16(this.comboBox4.SelectedValue));

                MessageBox.Show("Inserido com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
