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
    public partial class Form6 : Form
    {
        public void atualizarDataGrid()
        {
            this.consultaRequisicaosalaTableAdapter.Fill(this.database1DataSet.ConsultaRequisicaosala);

            this.consultaRequisicaosalaDataGridView.Refresh();

        }

        public Form6()
        {
            InitializeComponent();
        }

        private void requisições_SalasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Salas' table. You can move, or remove it, as needed.
            this.salasTableAdapter.Fill(this.database1DataSet.Salas);
           
            // TODO: This line of code loads data into the 'database1DataSet.ConsultaRequisicaosala' table. You can move, or remove it, as needed.
            this.consultaRequisicaosalaTableAdapter.Fill(this.database1DataSet.ConsultaRequisicaosala);
            // TODO: This line of code loads data into the 'database1DataSet.ConsultaRequisicaomaterial' table. You can move, or remove it, as needed.
            //this.consultaRequisicaomaterialTableAdapter.Fill(this.database1DataSet.ConsultaRequisicaomaterial);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
            //this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
            //this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
            //this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
            //this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
           // this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
            //this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
            //this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
          //  this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
           

        }

        private void rEq_SalasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InserirReqSala frm = new InserirReqSala();
            frm.ShowDialog();
            atualizarDataGrid();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.consultaRequisicaosalaTableAdapter.FillBySala(this.database1DataSet.ConsultaRequisicaosala, Convert.ToString(this.comboBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PesqREqSalas frm = new PesqREqSalas();
            frm.ShowDialog();
            atualizarDataGrid();
        }
    }
}
