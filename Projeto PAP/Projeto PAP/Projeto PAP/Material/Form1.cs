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
    public partial class Form1 : Form
    {
        
        public void atualizarDataGrid()
        {
            this.consultasMaterialTableAdapter.Fill(this.database1DataSet.ConsultasMaterial);

            this.consultasMaterialDataGridView.Refresh();
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.Fill(this.database1DataSet.Curso);
            // TODO: This line of code loads data into the 'database1DataSet.ConsultasMaterial' table. You can move, or remove it, as needed.
            this.consultasMaterialTableAdapter.Fill(this.database1DataSet.ConsultasMaterial);
            
            
            // TODO: This line of code loads data into the 'database1DataSet.Material' table. You can move, or remove it, as needed.
            //this.materialTableAdapter.Fill(this.database1DataSet.Material);
           

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmInserirMaterial frm = new frmInserirMaterial();
            frm.ShowDialog();
            atualizarDataGrid();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PesqMaterial frm = new PesqMaterial();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EliminarMaterial frm = new EliminarMaterial();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.consultasMaterialTableAdapter.FillByPesqCurso(this.database1DataSet.ConsultasMaterial, Convert.ToString(this.comboBox1.SelectedValue));

       }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMaterial frm = new frmMaterial();
            frm.ShowDialog();
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

       

        

      

      
    }
}
