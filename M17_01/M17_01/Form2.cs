using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace M17_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'database11DataSet.Horas' table. You can move, or remove it, as needed.
            this.horasTableAdapter.Fill(this.database11DataSet.Horas);
            // TODO: This line of code loads data into the 'database11DataSet.Semana' table. You can move, or remove it, as needed.
            this.semanaTableAdapter.Fill(this.database11DataSet.Semana);
            // TODO: This line of code loads data into the 'database11DataSet.Salas' table. You can move, or remove it, as needed.
            this.salasTableAdapter.Fill(this.database11DataSet.Salas);
            // TODO: This line of code loads data into the 'database11DataSet.Horario_Salas' table. You can move, or remove it, as needed.
            
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
            
        
        }
    }
}
