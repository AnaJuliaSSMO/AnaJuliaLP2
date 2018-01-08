using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFarmOfUs
{
    public partial class CadastrarLogin : Form
    {
        public CadastrarLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarLogin cad = new CadastrarLogin();

            string conf = confirmsen.Text;
            string senha1 = senhalog.Text;
            string usuario = username.Text;
            string nome = nomelog.Text;
            string seto = String.Format(setor.Text);


            SqlCommand cmd = new SqlCommand()

            {
                Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")            
            };

            if (senha1 == conf)
            {
                senhalog.Clear();
                confirmsen.Clear();
                username.Clear();
                nomelog.Clear();
                setor.ResetText();

                cmd.CommandText = String.Format(@"INSERT 
                                stringO Login
                                VALUES('{0}','{1}',{2},'{3}')", nome, usuario,senha1,seto);

                MessageBox.Show("Cadastro realizado com sucesso");

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.Connection.Close();
              
            }

            else
            {
                senhalog.Clear();
                confirmsen.Clear();
                MessageBox.Show("As senhas não conferem, por favor,insira a senha novamente");
            }
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
