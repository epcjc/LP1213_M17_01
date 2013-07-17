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
    public partial class AlterarHorario : Form
    {
        public AlterarHorario()
        {
            InitializeComponent();
        }

        private void horario_SalasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.horario_SalasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void AlterarHorario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Salas' table. You can move, or remove it, as needed.
            this.salasTableAdapter.Fill(this.database1DataSet.Salas);
            // TODO: This line of code loads data into the 'database1DataSet.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.database1DataSet.Turmas);
            // TODO: This line of code loads data into the 'database1DataSet.Semana' table. You can move, or remove it, as needed.
            this.semanaTableAdapter.Fill(this.database1DataSet.Semana);
            // TODO: This line of code loads data into the 'database1DataSet.Horas' table. You can move, or remove it, as needed.
            this.horasTableAdapter.Fill(this.database1DataSet.Horas);
            // TODO: This line of code loads data into the 'database1DataSet.Horario_Salas' table. You can move, or remove it, as needed.
            this.horario_SalasTableAdapter.Fill(this.database1DataSet.Horario_Salas);

        }

        private void iD_TempoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
