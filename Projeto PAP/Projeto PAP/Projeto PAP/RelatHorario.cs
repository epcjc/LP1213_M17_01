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
    public partial class RelatHorario : Form
    {
        public RelatHorario()
        {
            InitializeComponent();
        }

        private void RelatHorario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Horario' table. You can move, or remove it, as needed.
            this.HorarioTableAdapter.Fill(this.Database1DataSet.Horario);

            this.reportViewer1.RefreshReport();
        }
    }
}
