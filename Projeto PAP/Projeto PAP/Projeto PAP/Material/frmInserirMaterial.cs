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

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.pictureBox1.Image == null)
                {
                    this.materialTableAdapter.Insert(this.designacaoTextBox.Text,
                    this.marcaTextBox.Text,
                    this.serial_numberTextBox.Text,
                    "disponivel",
                    this.observacaoTextBox.Text,
                    Convert.ToInt32(this.categoriaComboBox.SelectedValue),
                    Convert.ToInt32(this.cursoComboBox.SelectedValue),
                    null);
                    MessageBox.Show("Inserido sem imagem");

                }
                else { 
                     MemoryStream ms = new MemoryStream();
                     pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                     Byte[] data = ms.GetBuffer();

                     this.materialTableAdapter.Insert(this.designacaoTextBox.Text,
                     this.marcaTextBox.Text,
                     this.serial_numberTextBox.Text,
                     "disponivel",
                     this.observacaoTextBox.Text,
                     Convert.ToInt32(this.categoriaComboBox.SelectedValue),
                     Convert.ToInt32(this.cursoComboBox.SelectedValue),
                     data);

                     MessageBox.Show("Inserido com sucesso");
                }

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
