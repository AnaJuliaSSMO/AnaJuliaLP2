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
        public static string confirmasenha,senha,nick,nomecom,setor,ok;

        public static void CadastroLogin(string conf,string senha1,string usuario, string nome, string seto)
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

            if (senha1 == conf)
            {
                cmd.CommandText = String.Format(@"INSERT 
                                INTO Login
                                VALUES('{0}','{1}',{2},'{3}')", nome, usuario, senha1, seto);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.Connection.Close();

                ok = "s";
            }

            else
            {
                ok = "n";
            }
        }
    }
}
