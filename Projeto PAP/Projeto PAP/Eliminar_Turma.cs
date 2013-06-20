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
    public partial class Eliminar_Turma : Form
    {
        public Eliminar_Turma()
        {
            InitializeComponent();
        }

        private void turmasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.turmasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Eliminar_Turma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.database1DataSet.Turmas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.turmasTableAdapter.DeleteTurma(Convert.ToInt16(this.comboBox1.SelectedValue));
                MessageBox.Show("Eliminado com sucesso");
            }

            catch (Exception)
            {
                MessageBox.Show("Turma inserida em horário");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
