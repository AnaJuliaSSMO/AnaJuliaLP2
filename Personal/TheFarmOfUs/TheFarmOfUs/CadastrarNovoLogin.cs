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
        public static string ok, cone = "",userco,cpfco,msg = "",msg2 = "",tudocerto;// confirmasenha, senha, nick, nomecom, setor,possuiuser = "n",possuicpf = "n"

        public static void CadastroLogin(string conf, string senha, string usuario, string nome, string seto,string cpf)
        {
            /*confirmasenha = conf;
            senha = senha1;
            nick = usuario;
            nomecom = nome;
            setor = seto;*/

            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
            };

            try
            {
                cmd.Connection.Open();
            }

            catch(SqlException)
            {
                cone = "Não foi possível estabelecer conexão no momento. Por favor, tente mais tarde.";
            }

            //VERIFICA SE EXISTE O USUÁRIO NO BD
            try
            {
                cmd.CommandText = String.Format(@"SELECT Usuario
                                FROM Login
                                WHERE Usuario = '{0}')",usuario);
                userco = cmd.ExecuteScalar().ToString();
               // cmd.Parameters.AddWithValue("@Usuario",usuario);
            }

            catch
            {
                msg = "Nome de usuário já foi escolhido, por favor insira outro.";
            }

            //VERIFICA SE EXISTE O CPF NO BD
            try
            {
                cmd.CommandText = String.Format(@"SELECT CPF
                                FROM Login
                                WHERE CPF = '{0}')", cpf);
                cpfco = cmd.ExecuteScalar().ToString();
            //    cmd.Parameters.AddWithValue("@CPF", cpf);
            }

            catch
            {
                msg2 = "CPF já cadastrado no sistema.";
            }

           if(msg != "" || msg2 != "")
            {
                cmd.Connection.Close();
            }

            else
            {
                if (senha == conf) //ELE SÓ VAI CHEGAR ATÉ AQUI SE NÃO TIVER USUÁRIO CADASTRADO E NEM CPF CADASTRADO
                {
                    cmd.CommandText = String.Format(@"INSERT 
                                INTO Login
                                VALUES('{0}','{1}','{2}','{3}','{4}')", nome, usuario, senha, seto, cpf);

                    SqlDataReader reader = cmd.ExecuteReader();

                    ok = "s";
                }

                else
                {
                    ok = "n";
                }
                cmd.Connection.Close();
             }
        }
    }
}