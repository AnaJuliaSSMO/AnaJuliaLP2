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
    public partial class RefazSenha : Form
    {
        public RefazSenha()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            MenuInicial men = new MenuInicial();
            men.Show();
            Close();
        }

        private void att_Click(object sender, EventArgs e)
        {
            string cone = "";
            string cpf = CPF.Text;
            string sen = senha.Text;
            string confsen = novasenha.Text;
            string confere; 

            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
            };

            try
            {
                cmd.Connection.Open();
            }

            catch (SqlException)
            {
                cone = "Não foi possível efeutar a conexão, tente mais tarde";
            }

            if(sen == confsen)
            {
                cmd.CommandText = String.Format(@"SELECT CPF
                                                  FROM Login
                                                  WHERE CPF = '{0}'", cpf);
                confere = (string)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();

                if (confere == null)
                {
                    MessageBox.Show("CPF não cadastrado em nosso sistema.");
                    CPF.Clear();
                }

                else
                {
                    cmd.CommandText = String.Format(@"UPDATE Login
                                                     SET Senha = @novasenha
                                                     WHERE CPF = '{0}'", cpf);

                    cmd.Parameters.AddWithValue("@novasenha", sen);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Senha alterada com sucesso");
                    CPF.Clear();
                    senha.Clear();
                    novasenha.Clear();
                }
            }

            else
            {
                MessageBox.Show("Senhas não conferem");
                senha.Clear();
                novasenha.Clear();
            }

            cmd.Connection.Close();
        }
    }
}
