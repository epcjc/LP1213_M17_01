﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_PAP
{
    public partial class Professores : Form
    {
        public void atualizarDataGrid()
        {
            this.professoresTableAdapter.Fill(this.database1DataSet.Professores);

            this.professoresDataGridView.Refresh();

        }


        public Professores()
        {
            InitializeComponent();
        }

        private void professoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Professores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.database1DataSet.Professores);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InserirProf frm = new InserirProf();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApagarProf frm = new ApagarProf();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PesqProfessores frm = new PesqProfessores();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
