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
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
            this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
            this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
            this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
            this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
            this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
            this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
            this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
            // TODO: This line of code loads data into the 'database1DataSet._REq_Salas' table. You can move, or remove it, as needed.
            this.rEq_SalasTableAdapter.FillReq_salas(this.database1DataSet._REq_Salas);
           

        }

        private void rEq_SalasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
