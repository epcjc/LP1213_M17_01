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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void requisitadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Requisitadores' table. You can move, or remove it, as needed.
            this.requisitadoresTableAdapter.Fill(this.database1DataSet.Requisitadores);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void requisitadoresBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.requisitadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
    }
}