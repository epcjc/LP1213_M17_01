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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void salasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Salas' table. You can move, or remove it, as needed.
            this.salasTableAdapter.Fill(this.database1DataSet.Salas);

        }

        private void button1_Click(object sender, EventArgs e)
        {



            try{
                if (textBox1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("inserir nome");
                }
                else
                {
                    this.salasTableAdapter.Insert(this.textBox1.Text);

                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
