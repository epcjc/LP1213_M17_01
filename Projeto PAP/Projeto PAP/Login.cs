using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_PAP
{
    public partial class Login : Form
    {
         SqlConnection sqlConn;
        private string strConn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Login.mdf;Integrated Security=True;User Instance=True";
        private string _Sql = string.Empty;

        public bool logado = false;

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
            if (logar())
            {
                FormPrincipal frm = new FormPrincipal();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Acesso não permitido");
            }
        }

        public bool logar()
        {
            sqlConn = new SqlConnection(strConn);
            string usu, pwd;

            try
            {
                usu = textBox1.Text;
                pwd = textBox2.Text;

                _Sql = "SELECT COUNT(ID) FROM login WHERE Username = @Nome AND Password = @Senha";

                SqlCommand cmd = new SqlCommand(_Sql, sqlConn);

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = usu;
                cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = pwd;

                sqlConn.Open();

                int v = (int)cmd.ExecuteScalar();

                if (v > 0)
                {
                    logado = true;
                }
                else
                {
                    logado = false;
                }

            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }

            return logado;
        }

       

        
    }
}
