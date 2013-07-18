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
    public partial class Form5 : Form
    {
        public void atualizarDataGrid()
        {
            this.consultaRequisicaomaterialTableAdapter.Fill(this.database1DataSet.ConsultaRequisicaomaterial);

        //    this.consultaRequisicaomaterialTableAdapter

        }

        public Form5()
        {
            InitializeComponent();
        }

        //private void requisiçõesMaterialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.requisiçõesMaterialBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.database1DataSet);

        //}

       

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.database1DataSet.Material);
            // TODO: This line of code loads data into the 'database1DataSet.RequisiçõesMaterial' table. You can move, or remove it, as needed.
            this.requisiçõesMaterialTableAdapter.Fill(this.database1DataSet.RequisiçõesMaterial);
            // TODO: This line of code loads data into the 'database1DataSet.ConsultaRequisicaomaterial' table. You can move, or remove it, as needed.
            this.consultaRequisicaomaterialTableAdapter.Fill(this.database1DataSet.ConsultaRequisicaomaterial);
            // TODO: This line of code loads data into the 'database1DataSet.ConsultaRequisicaomaterial' table. You can move, or remove it, as needed.
            this.consultaRequisicaomaterialTableAdapter.Fill(this.database1DataSet.ConsultaRequisicaomaterial);
            // TODO: This line of code loads data into the 'database1DataSet.DataTable1' table. You can move, or remove it, as needed.
            //this.dataTable1TableAdapter.FillRequi_Material(this.database1DataSet.DataTable1);
            
           

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InserirReq frm = new InserirReq();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.consultaRequisicaomaterialTableAdapter.FillByMaterial(this.database1DataSet.ConsultaRequisicaomaterial, Convert.ToString(this.comboBox1.SelectedValue));
        }

    }
}
