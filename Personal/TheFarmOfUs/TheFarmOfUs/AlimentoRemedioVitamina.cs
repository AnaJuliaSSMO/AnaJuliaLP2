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
        //VARIÁVEIS GERAIS, são aquelas que vou usar em mais de uma classe
        public static string possui = "n",cone = "",an,msg;

        //ISSO AQUI É PARA A COMPRA
        public static int qtd = 0,novaqtd;

        //ISSO AQUI É PARA ACRESCENTA OU RETIRA 
        public static int qtd2 = 0, novaqtd2 = 0;

        public static void Retirar(string nomedotipo, string tiposelecionado,int quantidade)
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


            cmd.CommandText = String.Format(@"SELECT Quantidade
                                               FROM AlRemVa
                                               WHERE Nome = '{0}'",nomedotipo);

            qtd2 = (Int32)cmd.ExecuteScalar();
            cmd.Parameters.AddWithValue("@Quantidade", qtd2);

            if(qtd2 > quantidade) //se a quantidade no banco for maior do que a quantidade que a pessoa quer retirar, ent ta ok
            {
                an = "ok";
                novaqtd2 = qtd2 - quantidade;

                cmd.CommandText = String.Format(@"UPDATE AlRemVa 
                                              SET Quantidade = {0}
                                              WHERE Nome = '{1}' AND Tipo = '{2}'", novaqtd2, nomedotipo, tiposelecionado);
            }
            
            else
            {
                an = "nop";
                msg = "Você não possui o suficiente, por favor, insira um número até " + qtd2;
            }
            
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Connection.Close();
        }
    }
}

/*
        public static void Compra(string tipo, string nome, int quantidade,double valores)
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
            }

            catch
            {
                possui = "s";
            }


            cmd.CommandText = String.Format(@"SELECT Quantidade
                                               FROM AlRemVa
                                               WHERE Nome = '{0}';", nome);
            
           // cmd.Parameters.AddWithValue("@Quantidade", qtd); ISSO AQUI NÃO SERVIA PARA O QUE EU PENSAVA EXATAMENTE :)
            novaqtd = qtd + quantidade;

            if (possui == "s") // Se o que ele quiser comprar já tiver na tabela ele só vai atualizar a quantidade
            {
                cmd.CommandText = String.Format(@"UPDATE AlRemVa 
                                                  SET Quantidade = {0}
                                                  WHERE Nome = '{1}'", novaqtd, nome);

            }

            else //se não, ele vai dar um insert
            {
                cmd.CommandText = String.Format(@"INSERT  
                                                  INTO AlRemVa 
                                                  VALUES ('{0}','{1}',{2})", nome, tipo, novaqtd);
            }

            SqlDataReader reader = cmd.ExecuteReader(); 
            cmd.Connection.Close();
        }
*/