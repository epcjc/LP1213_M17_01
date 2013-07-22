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
    public partial class frmFinalizarRequisicao : Form
    {
        private int id_requisicao;

        private int id_material;

        public int Id_material
        {
            get { return id_material; }
            set { id_material = value; }
        }

        public frmFinalizarRequisicao()
        {
            InitializeComponent();
        }

        private void frmFinalizarRequisicao_Load(object sender, EventArgs e)
        {
            
            this.requisiçõesMaterialTableAdapter.FillByRequisicaoAbertaPorMaterial(this.database1DataSet.RequisiçõesMaterial, Id_material);

            DataRow dr = this.database1DataSet.RequisiçõesMaterial.Rows[0];
            id_requisicao = Convert.ToInt32(dr["ID_requisicao"]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.requisiçõesMaterialTableAdapter.FinalizarRequisicao(DateTime.Now, this.textBox1.Text, "Concluida", id_requisicao);
            this.materialTableAdapter.AlterarEstado("Disponível", Id_material);

            this.Close();
        }

        
    }
}
