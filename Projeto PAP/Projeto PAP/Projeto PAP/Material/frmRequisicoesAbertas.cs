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
    public partial class frmRequisicoesAbertas : Form
    {
        public frmRequisicoesAbertas()
        {
            InitializeComponent();
        }

        private void frmRequisicoesAbertas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.HistoricoRequisicoes' table. You can move, or remove it, as needed.
            this.historicoRequisicoesTableAdapter.Abertas(this.database1DataSet.HistoricoRequisicoes );
            
           

        }
    }
}
