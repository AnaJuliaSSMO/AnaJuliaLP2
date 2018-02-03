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

            if (cone == "")
            {
                if (sen == confsen)
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
                        MessageBox.Show("Nova senha é: " + sen);
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
            }

            else
            {
                MessageBox.Show(cone);
            }

            cmd.Connection.Close();
        }

        private void CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cpf = CPF.Text;
            string pegacpf, cone = "", nome;

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
                cone = "Não foi possível estabelecer conexão no momento. Por favor, tente mais tarde.";
            }

            if (cone == "")
            {
                cmd.CommandText = String.Format(@"SELECT CPF
                                              FROM Funcionario
                                              WHERE CPF = '{0}'", cpf);
                pegacpf = (string)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();

                if (pegacpf == null)
                {
                    MessageBox.Show("CPF não cadastrado em nosso sistema, por favor verifique as informações.");
                }

                else
                {
                    cmd.CommandText = String.Format(@"SELECT Nome
                                                      FROM Funcionario
                                                      WHERE CPF = '{0}'", cpf);

                    nome = (string)cmd.ExecuteScalar();
                    cmd.ExecuteNonQuery();

                    nometxt.Text = nome;
                }
            }

            else
            {
                MessageBox.Show(cone);
            }
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
