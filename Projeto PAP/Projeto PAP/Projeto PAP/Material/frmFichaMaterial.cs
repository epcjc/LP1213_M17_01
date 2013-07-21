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
    public partial class frmFichaMaterial : Form
    {
        Boolean editState = false;
        Boolean changedImage = false;
        Boolean changedRequester = false;

        Boolean changedCourse = false;
        int id_curso;
        String curso;

        Boolean changedType = false;
        int id_tipo;
        String tipo;

        private int id_material;

        public int Id_material
        {
            get { return id_material; }
            set { id_material = value; }
        }


        public frmFichaMaterial()
        {
            InitializeComponent();
        }

        private void frmInserirMaterial_Load(object sender, EventArgs e)
        {
            displayButtons();


            // TODO: This line of code loads data into the 'database1DataSet.ConsultasMaterial' table. You can move, or remove it, as needed.
            this.consultasMaterialTableAdapter.FillByID(this.database1DataSet.ConsultasMaterial, Id_material);

            // TODO: This line of code loads data into the 'database1DataSet.ProfessoresAutorizadosMaterial' table. You can move, or remove it, as needed.
            this.professoresAutorizadosMaterialTableAdapter.FillByIdMaterial(this.database1DataSet.ProfessoresAutorizadosMaterial, Id_material);
            this.listBox1.SelectedItems.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (editState)
            {

                saveChanges();
                editState = false;
            }

            else
            {
                editState = true;
            }

            displayButtons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changedImage = true;

            try
            {
                this.openFileDialog1.FileName = null;
                this.openFileDialog1.Filter = "Fotografias | *.gif;*.jpg;*.png";
                this.openFileDialog1.ShowDialog();

                if (openFileDialog1.FileName != null)
                {
                    this.imagemPictureBox.ImageLocation = openFileDialog1.FileName;
                    this.imagemPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao escolher imagem");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changedImage = true;
            this.imagemPictureBox.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void displayButtons()
        {

            if (editState)
            {
                button1.Show();
                button2.Show();
                button5.Show();
                button6.Show();
                button7.Show();
                button8.Show();

                button4.Text = "Gravar";

            }
            else
            {
                button1.Hide();
                button2.Hide();
                button5.Hide();
                button6.Hide();
                button7.Hide();
                button8.Hide();

                button4.Text = "Editar";
            }

        }


        private void saveChanges()
        {
            if (designacaoTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Designação não pode ser vazia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.listBox1.SelectedItems.Count == 0)
            {

                DialogResult result = MessageBox.Show("Não selecionou professores autorizados. Tem a certeza que quer continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            if (changedImage)
            {              
                Byte[] data = null;

                if (this.imagemPictureBox.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    imagemPictureBox.Image.Save(ms, imagemPictureBox.Image.RawFormat);
                    data = ms.GetBuffer();
                }

                this.materialTableAdapter.alterarImagem(data, Id_material);

            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            changedCourse = true;

            frmMudarCurso frm = new frmMudarCurso();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                id_curso = frm.Id_curso;
                curso = frm.Curso;

                this.cursoTextBox.Text = curso;
            }
            

            frm.Dispose();

        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            changedType = true;

            frmMudarTipo frm = new frmMudarTipo();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                id_tipo = frm.Id_tipo;
                tipo = frm.Tipo;

                this.categoriaTextBox.Text = tipo;
            }


            frm.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


    }

}

