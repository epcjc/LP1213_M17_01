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
    public partial class InserirReq : Form
    {
        public InserirReq()
        {
            InitializeComponent();
        }

        private void InserirReq_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.database1DataSet.Material);
            // TODO: This line of code loads data into the 'database1DataSet.Requisitadores' table. You can move, or remove it, as needed.
            this.requisitadoresTableAdapter.Fill(this.database1DataSet.Requisitadores);
            // TODO: This line of code loads data into the 'database1DataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.FillRequi_Material(this.database1DataSet.DataTable1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}