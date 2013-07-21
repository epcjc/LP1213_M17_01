using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Projeto_PAP
{
    public partial class frmInserirMaterial : Form
    {
        public frmInserirMaterial()
        {
            InitializeComponent();
        }

        private void frmInserirMaterial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Requisitantes_material' table. You can move, or remove it, as needed.
            this.requisitantes_materialTableAdapter.Fill(this.database1DataSet.Requisitantes_material);
            // TODO: This line of code loads data into the 'database1DataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.database1DataSet.Professores);
            // TODO: This line of code loads data into the 'database1DataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.database1DataSet.Categoria);
            // TODO: This line of code loads data into the 'database1DataSet.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.Fill(this.database1DataSet.Curso);
            // TODO: This line of code loads data into the 'database1DataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.database1DataSet.Material);
            // TODO: This line of code loads data into the 'database1DataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.database1DataSet.Categoria);
            // TODO: This line of code loads data into the 'database1DataSet.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.Fill(this.database1DataSet.Curso);


            this.listBox1.SelectedItems.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (designacaoTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Designação não pode ser vazia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.listBox1.SelectedItems.Count == 0)
            {

                DialogResult result = MessageBox.Show("Não selecionou professores autorizados. Tem a certeza que quer continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) {
                    return;
                }
            }

            int id_material = 0;

            try
            {
                Byte[] data = null;

                if (this.pictureBox1.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    data = ms.GetBuffer();
                }

                this.materialTableAdapter.Insert(this.designacaoTextBox.Text,
                this.marcaTextBox.Text,
                this.serial_numberTextBox.Text,
                "Disponível",
                this.observacaoTextBox.Text,
                Convert.ToInt32(this.categoriaComboBox.SelectedValue),
                Convert.ToInt32(this.cursoComboBox.SelectedValue),
                data);

                id_material = Convert.ToInt32(this.materialTableAdapter.UltimoID());

                if (id_material != 0)
                {
                    foreach (DataRowView drv in listBox1.SelectedItems)
                    {
                        this.requisitantes_materialTableAdapter.Insert(id_material, Convert.ToInt32(drv["ID_Professor"]));
                    }
                }

                MessageBox.Show("Inserido com sucesso");
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERRO " + ex.ToString());
            }
  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                this.openFileDialog1.FileName = null;
                this.openFileDialog1.Filter = "Fotografias | *.gif;*.jpg;*.png";
                this.openFileDialog1.ShowDialog();

                if (openFileDialog1.FileName != null) {
                    this.pictureBox1.ImageLocation = openFileDialog1.FileName;
                    this.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch {
                MessageBox.Show("Erro ao escolher imagem");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       
      



    }
}
