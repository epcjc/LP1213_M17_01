﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_PAP
{
    public partial class RelatReqSalas : Form
    {
        public RelatReqSalas()
        {
            InitializeComponent();
        }

        private void RelatReqSalas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Salas' table. You can move, or remove it, as needed.
            this.SalasTableAdapter.Fill(this.Database1DataSet.Salas);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
