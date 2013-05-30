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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res;
            res = (int)this.loginTableAdapter.CheckLogin(this.textBox1.Text, this.textBox2.Text);

            if (res != 1)
            {
                MessageBox.Show("Acesso negado", "Erro a fazer login", MessageBoxButtons.OK);
            }
            else
            {
                FormPrincipal frm = new FormPrincipal();
                frm.Show();
            }
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDataSet);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.loginDataSet.login);

        }
    }
}
