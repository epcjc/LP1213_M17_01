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
    public partial class frmNovaRequisicao : Form
    {
        private int id_material;

        public int Id_material
        {
            get { return id_material; }
            set { id_material = value; }
        }

        public string DesignacaoMaterial;



        public frmNovaRequisicao()
        {
            InitializeComponent();
        }

        private void frmNovaRequisicao_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'database1DataSet.ProfessoresAutorizadosMaterial' table. You can move, or remove it, as needed.
            this.professoresAutorizadosMaterialTableAdapter.FillByIdMaterial(this.database1DataSet.ProfessoresAutorizadosMaterial, Id_material);

            if (this.database1DataSet.ProfessoresAutorizadosMaterial.Rows.Count == 0)
            {
                MessageBox.Show("Não existem professores autorizados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id_professor = Convert.ToInt32(this.comboBox1.SelectedValue);

                this.materialTableAdapter.AlterarEstado("Requisitado", Id_material);

                DateTime data = DateTime.Now;
                this.requisiçõesMaterialTableAdapter.InsereNova(id_professor, data, Id_material, this.textBox1.Text);

                Reports.Form1 frm = new Reports.Form1();
                frm.designacao = DesignacaoMaterial;
                DataRowView drv = (DataRowView) this.comboBox1.SelectedItem;
                frm.nome = drv["Nome_Professor"].ToString();
                frm.data = data.ToShortDateString();
                frm.notas = this.textBox1.Text;

                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            this.Close();
        }
        
    }
}
