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
    public partial class PesqREqSalas : Form
    {
        public PesqREqSalas()
        {
            InitializeComponent();
        }

        private void PesqREqSalas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ConsultaRequisicaosala' table. You can move, or remove it, as needed.
            this.consultaRequisicaosalaTableAdapter.Fill(this.database1DataSet.ConsultaRequisicaosala);
            // TODO: This line of code loads data into the 'database1DataSet.Salas' table. You can move, or remove it, as needed.
           // this.salasTableAdapter.Fill(this.database1DataSet.Salas);
            // TODO: This line of code loads data into the 'database1DataSet.ConsultaRequisicaosala' table. You can move, or remove it, as needed.
            this.consultaRequisicaosalaTableAdapter.Fill(this.database1DataSet.ConsultaRequisicaosala);
            // TODO: This line of code loads data into the 'database1DataSet.Requisições_Salas' table. You can move, or remove it, as needed.
           // this.requisições_SalasTableAdapter.Fill(this.database1DataSet.Requisições_Salas);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
            //this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.consultaRequisicaosalaTableAdapter.FillBySala(this.database1DataSet.ConsultaRequisicaosala, Convert.ToString(this.comboBox1.SelectedValue));
        }

        private void consultaRequisicaosalaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
