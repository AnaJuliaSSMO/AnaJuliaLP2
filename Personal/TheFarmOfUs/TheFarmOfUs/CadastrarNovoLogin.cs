using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFarmOfUs
{
    class CadastrarNovoLogin
    {
        public static string confirmasenha,senha,nick,nomecom,setor,ok,possui = "s",usuariojatem,cpfjatem,cone = "";

        public static void CadastroLogin(string conf,string senha1,string usuario, string nome, string seto,string cpf)
        {
            confirmasenha = conf;
            senha = senha1;
            nick = usuario;
            nomecom = nome;
            setor = seto;

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

            try
            {
                cmd.CommandText = String.Format(@"SELECT Usuario, CPF
                                               FROM Login
                                               WHERE Usuario = '{0}'", nick); //AND CPF = '{1}';", nick,cpf);

                usuariojatem = cmd.ExecuteScalar().ToString();
            //    cmd.Parameters.AddWithValue("@Usuario", usuariojatem);
               // cmd.Parameters.AddWithValue("@CPF", cpfjatem); // = 
            }

            catch
            {
                possui = "s";
            }

            if(possui == "n")
            {
                if (senha1 == conf)
                {
                    cmd.Connection.Open();
                    cmd.CommandText = String.Format(@"INSERT 
                                INTO Login
                                VALUES('{0}','{1}',{2},'{3}','{4}')", nome, usuario, senha1, seto);

                    SqlDataReader reader = cmd.ExecuteReader();

                    ok = "s";
                }

                else
                {
                    ok = "n";
                }
            }
            cmd.Connection.Close();
        }
    }
}
