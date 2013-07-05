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
    public partial class Form9 : Form
    {

        public void atualizarDataGrid()
        {
            this.horarioTableAdapter.Fill(this.database1DataSet.Horario);
            this.horarioDataGridView.Refresh();

        }

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Horario' table. You can move, or remove it, as needed.
            this.horarioTableAdapter.Fill(this.database1DataSet.Horario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InserirHorario frm = new InserirHorario();
            frm.ShowDialog();
            atualizarDataGrid();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EliminarHorario frm = new EliminarHorario();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PesqHorario frm = new PesqHorario();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AlterarHorario frm = new AlterarHorario();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void horarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
