using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFarmOfUs
{
    class Logar //É A PRIMEIRA TELA, VC SÓ RECEBE LOGIN E SENHA ;)
    {
        public static string nomeconf,userconf,senhaconf, cone="",entrou;
        public static void RealizarLogin(string user, string pass)
        {
            entrou = "n";

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
                entrou = "semconexao";
            }

            if (cone == "")
            {
                cmd.CommandText = String.Format(@"SELECT nome,usuario,senha
                                              FROM Login
                                              WHERE Usuario = '{0}' AND Senha = '{1}';", user, pass);

                try
                {
                    userconf = cmd.ExecuteScalar().ToString();
                    senhaconf = cmd.ExecuteScalar().ToString();
                }

                catch
                {
                    entrou = "s";
                }

                if(entrou == "n")
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            nomeconf = reader.GetString(0);
                        }
                    }

                    MessageBox.Show("Tudo ok, bem vindo Sr / Sra " + Logar.nomeconf, "Acesso com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Seja bem vindo à The Farm of Us.\n\nThe Farm of Us foi criado para poder lhe ajudar na administração de sua fazenda\n\nAqui, você poderá controlar seus gastos, vendas,compras e tudo o que voce pode imaginar.\n\nAproveite e obrigado por aderir aos nossos serviços.");
                }

                else
                {
                    MessageBox.Show("Senha ou usuário inválido.");
                }
            }

            else
            {
                MessageBox.Show(cone);
            }

            cmd.Connection.Close();
        }
    }
}
    
