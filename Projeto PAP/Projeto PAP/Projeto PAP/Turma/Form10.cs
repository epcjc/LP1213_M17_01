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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("necessário inserir nome");
                }
                else
                {

                    this.turmasTableAdapter.Insert(this.textBox1.Text);
                    this.Close();
                }

             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                

           
        }

        private void turmasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.turmasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.database1DataSet.Turmas);

        }
    }
}
