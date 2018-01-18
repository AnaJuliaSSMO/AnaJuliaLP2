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
        public static string oksenha, cone = "",tudocerto;//confirmasenha, senha, nick, nomecom, setor, 

        //VARIÁVEIS APENAS PARA CONFERIR SE JÁ EXISTEM NO BD
        public static string pegauser,existeuser; //USER
        public static string pegacpf, existecpf; //CPF


        public static void CadastroLogin(string conf, string senha, string usuario, string nome,string cpf)
        {
            pegauser = "";
            pegacpf = "";
            existeuser = "";
            existecpf = "";

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

            //1º VERIFICAR SE O NICK JÁ FOI OU NÃO ESCOLHIDO

            try
            {
                cmd.CommandText = String.Format(@"SELECT Usuario
                                FROM Login
                                WHERE Usuario = '{0}'", usuario);
                pegauser = cmd.ExecuteScalar().ToString();
            }

            catch
            {
                existeuser = "s";
            }

            //2 ºVERIFICAR SE O CPF JÁ FOI CADASTRADO 
            try
            {
                cmd.CommandText = String.Format(@"SELECT CPF
                                FROM Login
                                WHERE CPF = '{0}'", cpf);

                pegacpf = cmd.ExecuteScalar().ToString();
            }

            catch
            {
                existecpf = "s";
            }

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            /*
            try
            {
                
              //  cmd.Parameters.AddWithValue("@Usuario", pegacpf);
            }

            catch
            {
                existecpf = "s";
            }
            
            /*

            //3º APÓS VERIFICAR SE TEM OU N, ELE VEM AQUI E VÊ SE TA TUDO OK*/
            /*if (pegauser == usuario)//(existecpf == "s" || existeuser == "s")
            {
                tudocerto = "n";
            }

            else
            {
                tudocerto = "s";
            }*/
        }
    }
}

/*
 * CONFERENCIA DE SENHA ESTÁ OK
 * NÃO TA MAIS
 * NA VDD TA
 * QUEM N TA OK SOU EU
 * HELP
 * 
 * cmd.CommandText = String.Format(@"INSERT 
                                 INTO Login
                                 VALUES('{0}','{1}','{2}','{3}')", nome, usuario, senha, cpf);
                
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.Connection.Close();
*/
