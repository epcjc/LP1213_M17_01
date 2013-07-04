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
    public partial class Form8 : Form
    {
        public void atualizarDataGrid()
        {
            this.salasTableAdapter.Fill(this.database1DataSet.Salas);

            this.salasDataGridView.Refresh();

        }

        public Form8()
        {
            InitializeComponent();
        }

        private void salasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.database1DataSet.Turmas);
            // TODO: This line of code loads data into the 'database1DataSet.Salas' table. You can move, or remove it, as needed.
            this.salasTableAdapter.Fill(this.database1DataSet.Salas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.ShowDialog();
            atualizarDataGrid();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EliminarSala frm = new EliminarSala();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Eliminar_Turma frm = new Eliminar_Turma();
            frm.ShowDialog(); atualizarDataGrid();
            atualizarDataGrid();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PesqTurma frm = new PesqTurma();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PesqSala frm = new PesqSala();
            frm.ShowDialog();
            atualizarDataGrid();
        }
    }
}
