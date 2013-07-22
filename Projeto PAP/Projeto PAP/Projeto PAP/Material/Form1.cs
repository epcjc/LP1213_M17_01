using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Projeto_PAP
{
    public partial class Form1 : Form
    {

        private int linhaSelecionada;

        public void preencherCombos()
        {
            //Combobox tipos de material

            DataTable dt1 = this.categoriaTableAdapter.GetData();

            this.comboBox1.Items.Clear();

            Dictionary<string, int> lista1 = new Dictionary<string, int>();
            lista1.Add("Todos", 0);
            comboBox1.Items.Add("Todos");
            foreach (DataRow row in dt1.Rows)
            {
                lista1.Add(row["categoria"].ToString(), (int)row["id_categoria"]);
                comboBox1.Items.Add(row["categoria"].ToString());

            }

            comboBox1.SelectedIndex = 0;


            //Combobox Cursos

            DataTable dt2 = this.cursoTableAdapter.GetData();

            this.comboBox2.Items.Clear();

            Dictionary<string, int> lista2 = new Dictionary<string, int>();
            lista2.Add("Todos", 0);
            comboBox2.Items.Add("Todos");
            foreach (DataRow row in dt2.Rows)
            {
                lista2.Add(row["Curso"].ToString(), (int)row["Id_Curso"]);
                comboBox2.Items.Add(row["Curso"].ToString());

            }

            comboBox2.SelectedIndex = 0;

            //Combobox Estado

            DataTable dt3 = this.estadosTableAdapter.GetData();

            this.comboBox3.Items.Clear();

            Dictionary<string, int> lista3 = new Dictionary<string, int>();
            lista3.Add("Todos", 0);
            comboBox3.Items.Add("Todos");
            foreach (DataRow row in dt3.Rows)
            {
                lista3.Add(row["Estado"].ToString(), (int)row["id_estado"]);
                comboBox3.Items.Add(row["Estado"].ToString());

            }

            comboBox3.SelectedIndex = 0;


        }


        public void atualizarDataGrid()
        {
            this.consultasMaterialTableAdapter.Fill(this.database1DataSet.ConsultasMaterial);

            highlightRows();

            this.consultasMaterialDataGridView.Refresh();
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.database1DataSet.Estados);

            preencherCombos();
            
    

            
            // TODO: This line of code loads data into the 'database1DataSet.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.Fill(this.database1DataSet.Curso);
            // TODO: This line of code loads data into the 'database1DataSet.ConsultasMaterial' table. You can move, or remove it, as needed.
            this.consultasMaterialTableAdapter.Fill(this.database1DataSet.ConsultasMaterial);

         

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

        private void button6_Click(object sender, EventArgs e)
        {
            frmMaterial frm = new frmMaterial();
            frm.ShowDialog();
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // TODO
            // CUIDADO AQUI: porque é que o string está no index 1???
            // O acesso por nome falha!

            string connString = ConfigurationManager.ConnectionStrings[1].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "SELECT * FROM ConsultasMaterial";

            //Construir a query para pesquisar:
            Boolean andNeeded = false;
            if (comboBox1.SelectedIndex != 0 || comboBox2.SelectedIndex != 0 || comboBox3.SelectedIndex != 0)
            {
                query += " WHERE ";

                //Adicionar TIPO
                if (comboBox1.SelectedIndex != 0)
                {
                    query += " categoria = '" + comboBox1.SelectedItem.ToString() + "'";
                    andNeeded = true;
                }

                //Adicionar CURSO
                if (comboBox2.SelectedIndex != 0)
                {
                    if (andNeeded)
                    {
                        query += " AND ";
                    }

                    query += " Curso = '" + comboBox2.SelectedItem.ToString() + "'";
                    andNeeded = true;
                }

                //Adicionar ESTADO
                if (comboBox3.SelectedIndex != 0)
                {
                    if (andNeeded)
                    {
                        query += " AND ";
                    }

                    query += " Estado = '" + comboBox3.SelectedItem.ToString() + "'";
                    andNeeded = true;
                }

                
            }

          // MessageBox.Show(query);

            SqlCommand queryCommand = new SqlCommand(query, conn);
          
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = queryCommand;

            DataTable tabela = new DataTable();
            //tabela.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(tabela);

            BindingSource bs = new BindingSource();
            bs.DataSource = tabela;

            consultasMaterialDataGridView.DataSource = bs;

            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int linha = consultasMaterialDataGridView.SelectedRows[0].Index;

            
            DataGridViewRow dgv = this.consultasMaterialDataGridView.Rows[linha];

            frmFichaMaterial frm = new frmFichaMaterial();

            // indice 0 de dgv.cells -> ID_Material
            frm.Id_material = Convert.ToInt32(dgv.Cells[0].Value);
            frm.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            linhaSelecionada = consultasMaterialDataGridView.SelectedRows[0].Index;

            doRequisicao(linhaSelecionada);
        }


        private void doRequisicao(int linha)
        {
            DataGridViewRow dgv = this.consultasMaterialDataGridView.Rows[linha];

            frmNovaRequisicao frm = new frmNovaRequisicao();

            frm.Id_material = Convert.ToInt32(dgv.Cells[0].Value);
            frm.DesignacaoMaterial = dgv.Cells[1].Value.ToString();
            frm.ShowDialog();

            atualizarDataGrid();
        }
        

        private void consultasMaterialDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int linha = e.RowIndex;

            checkOptions(linha);

        }


        private void checkOptions(int linha)
        {
            DataGridViewRow dgv = this.consultasMaterialDataGridView.Rows[linha];

            // Indice de Cells 4 -> Estado
            string estado = dgv.Cells[4].Value.ToString();

            if (estado == "Requisitado" || estado == "Indisponível")
            {
                button8.Enabled = false;
                if (estado == "Requisitado")
                {
                    button9.Enabled = true;
                    button3.Enabled = true;
                }
                if (estado == "Indisponível")
                {
                    button9.Enabled = false;
                    button3.Enabled = false;
                }
            }
            else
            {
                button8.Enabled = true;
                button9.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void consultasMaterialDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            highlightRows();
        
        }




        private void highlightRows()
        {
            DataGridViewCellStyle corRequisitado = consultasMaterialDataGridView.DefaultCellStyle.Clone();
            corRequisitado.BackColor = Color.Gold;


            DataGridViewCellStyle corIndisponivel = consultasMaterialDataGridView.DefaultCellStyle.Clone();
            corIndisponivel.BackColor = Color.LightGray;

            foreach (DataGridViewRow r in consultasMaterialDataGridView.Rows)
            {
                if (r.Cells[4].Value.ToString().Equals("Indisponível"))
                {
                    r.DefaultCellStyle = corIndisponivel;
                }

                if (r.Cells[4].Value.ToString().Equals("Requisitado"))
                {
                    r.DefaultCellStyle = corRequisitado;
                }
            }
        }

        private void consultasMaterialDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitTest;

            hitTest = consultasMaterialDataGridView.HitTest(e.X, e.Y);

            if (e.Button == MouseButtons.Right) {
                if (hitTest.Type == DataGridViewHitTestType.Cell) {

                    this.contextMenuStrip1.Show(consultasMaterialDataGridView, e.Location, ToolStripDropDownDirection.BelowRight);


                    linhaSelecionada = hitTest.RowIndex;
                    checkOptions(linhaSelecionada);

                    DataGridViewRow dgv = this.consultasMaterialDataGridView.Rows[linhaSelecionada];

                    // Indice de Cells 4 -> Estado
                    string estado = dgv.Cells[4].Value.ToString();

                    
                        if (estado == "Requisitado")
                        {
                            contextMenuStrip1.Items[0].Enabled = false;
                            contextMenuStrip1.Items[1].Enabled = true;
                            contextMenuStrip1.Items[3].Enabled = false;
                            contextMenuStrip1.Items[4].Enabled = false;
                        }
                        if (estado == "Indisponível")
                        {
                            contextMenuStrip1.Items[0].Enabled = false;
                            contextMenuStrip1.Items[1].Enabled = false;
                            contextMenuStrip1.Items[3].Enabled = true;
                            contextMenuStrip1.Items[4].Enabled = false;
                        }

                        if (estado == "Disponível")
                        {
                            contextMenuStrip1.Items[0].Enabled = true;
                            contextMenuStrip1.Items[1].Enabled = false;
                            contextMenuStrip1.Items[3].Enabled = false;
                            contextMenuStrip1.Items[4].Enabled = true;
                        }


                }

            }
            

        
        }

        private void requisitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doRequisicao(linhaSelecionada);
        }

        private void disponibilizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgv = this.consultasMaterialDataGridView.Rows[linhaSelecionada];

            this.materialTableAdapter.AlterarEstado("Disponível", Convert.ToInt32(dgv.Cells[0].Value));

            atualizarDataGrid();
        }

        private void indisponibilizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgv = this.consultasMaterialDataGridView.Rows[linhaSelecionada];

            this.materialTableAdapter.AlterarEstado("Indisponível", Convert.ToInt32(dgv.Cells[0].Value));

            atualizarDataGrid();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            linhaSelecionada = consultasMaterialDataGridView.SelectedRows[0].Index;
       
            DataGridViewRow dgv = this.consultasMaterialDataGridView.Rows[linhaSelecionada];

            frmFinalizarRequisicao frm = new frmFinalizarRequisicao();

            frm.Id_material = Convert.ToInt32(dgv.Cells[0].Value);
            
            frm.ShowDialog();

            atualizarDataGrid();
        }


        private void entregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            DataGridViewRow dgv = this.consultasMaterialDataGridView.Rows[linhaSelecionada];

            frmFinalizarRequisicao frm = new frmFinalizarRequisicao();

            frm.Id_material = Convert.ToInt32(dgv.Cells[0].Value);

            frm.ShowDialog();

            atualizarDataGrid();
        }
        
    }
}
