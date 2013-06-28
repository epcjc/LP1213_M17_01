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
    public partial class PesqHorario : Form
    {
        public PesqHorario()
        {
            InitializeComponent();
        }

        private void horario_SalasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           // this.horario_SalasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void PesqHorario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Salas' table. You can move, or remove it, as needed.
            this.salasTableAdapter.Fill(this.database1DataSet.Salas);

        }

        
        private void PesqHorario_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Salas' table. You can move, or remove it, as needed.
            this.salasTableAdapter.Fill(this.database1DataSet.Salas);
            // TODO: This line of code loads data into the 'database1DataSet.Horario' table. You can move, or remove it, as needed.
            this.horarioTableAdapter.Fill(this.database1DataSet.Horario);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

         this.horarioTableAdapter.FillByPeSALA(this.database1DataSet.Horario, this.textBox1.Text);
            

        }
    }
}
