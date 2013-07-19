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
    public partial class frmMaterial : Form
    {
        public frmMaterial()
        {
            InitializeComponent();
        }

        private void materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void frmMaterial_Load(object sender, EventArgs e)
        {
          
            
            // TODO: This line of code loads data into the 'database1DataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.database1DataSet.Material);

        }

        private void id_cursoTextBox_TextChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.FillByIdCurso(this.database1DataSet.Curso, Convert.ToInt32(this.id_cursoTextBox.Text));
        }

        private void id_categoriaTextBox_TextChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.FillByIdCategoria(this.database1DataSet.Categoria, Convert.ToInt32(this.id_categoriaTextBox.Text));
        }

       
       

    }
}
