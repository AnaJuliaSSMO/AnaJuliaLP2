using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFarmOfUs
{
    class AlimentoRemedioVitamina
    {
        public static string possui = "s",cone = "",an;
        public static int qtd = 0;
        public static double disp;

        public static void Negocio(string tipo, string nome, int quantidade,double valores,double disponivel)
        {
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
                cmd.CommandText = String.Format(@"SELECT Nome
                                               FROM AlRemVa
                                               WHERE Nome = '{0}';", nome);

                an = cmd.ExecuteScalar().ToString();
            }

            catch
            {
                possui = "n";
            }


            cmd.CommandText = String.Format(@"SELECT Quantidade
                                               FROM AlRemVa
                                               WHERE Nome = '{0}';", nome);
            
            cmd.Parameters.AddWithValue("@Quantidade", qtd);
            qtd += quantidade;

            if (possui == "s") // Se o que ele quiser comprar já tiver na tabela ele só vai atualizar a quantidade
            {
                cmd.CommandText = String.Format(@"UPDATE AlRemVa 
                                                  SET Quantidade = {0}
                                                  WHERE Nome = '{1}'", qtd, nome);

            }

            else
            {
                cmd.CommandText = String.Format(@"INSERT  
                                                  INTO AlRemVa 
                                                  VALUES ('{0}','{1}',{2})", nome, tipo, qtd);
            }

            SqlDataReader reader = cmd.ExecuteReader(); 
            cmd.Connection.Close();
        }
    }
}
