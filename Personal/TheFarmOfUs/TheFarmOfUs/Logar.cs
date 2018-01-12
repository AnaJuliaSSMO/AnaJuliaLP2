using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFarmOfUs
{
    class Logar //É A PRIMEIRA TELA, VC SÓ RECEVE LOGIN E SENHA ;)
    {
        public static string usuari,passw,nomeconf,userconf,setor, senhaconf, entrou, cone="";

        public static string RealizarLogin(string user,string pass) 
        {
            usuari = user;
            passw = pass;
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
            }

            cmd.CommandText = String.Format(@"SELECT usuario,senha,nome,setor
                                              FROM Login
                                              WHERE Usuario = '{0}' AND Senha = '{1}';", user, pass);

            try
            {
                userconf = cmd.ExecuteScalar().ToString();
                senhaconf = cmd.ExecuteScalar().ToString();
                nomeconf = cmd.ExecuteScalar().ToString();
                setor = cmd.ExecuteScalar().ToString();
            }

            catch
            {
                entrou = "s";
            }

            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Parameters.AddWithValue("@Usuario", userconf);
            cmd.Parameters.AddWithValue("@Senha", senhaconf);
            cmd.Parameters.AddWithValue("@Nome", nomeconf);
            cmd.Parameters.AddWithValue("@Setor", setor);

            cmd.Connection.Close();

            return nomeconf;
        }
    }
}
