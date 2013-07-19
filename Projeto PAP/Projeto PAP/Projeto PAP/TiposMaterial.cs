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
    public partial class TiposMaterial : Form
    {
        public TiposMaterial()
        {
            InitializeComponent();
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void categoriaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void categoriaBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void TiposMaterial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.database1DataSet.Categoria);

        }
    }
}
