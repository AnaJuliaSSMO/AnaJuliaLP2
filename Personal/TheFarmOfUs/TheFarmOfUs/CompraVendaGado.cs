using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFarmOfUs
{
    class CompraVendaGado
    {
        public static double valorunitario, valordacompra = valorunitario * quantidade, sobrou = disponivel - valordacompra;
        public static int quantidade, qtdatual, disponivel, totalcompra = quantidade + qtdatual,totalvenda = qtdatual - quantidade;
        public static string animalescolhido,msg;
        public static string cone = "";

        public static void Negociacao(int qtdcomprada, double preco, string animal,string escolha)
        {
            valorunitario = preco;
            quantidade = qtdcomprada;
            animalescolhido = animal;

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
                                               FROM Gado
                                               WHERE Animal = '{0}';", animal);

            qtdatual = (Int32)cmd.ExecuteScalar();

            if (escolha == "compra")
            {
                cmd.CommandText = String.Format(@"UPDATE Gado 
                                                    SET Quantidade = {0}
                                                    WHERE Animal = '{1}'",totalcompra, animal);
            }

            else
            {
                cmd.CommandText = String.Format(@"UPDATE Gado 
                                                    SET Quantidade = {0}
                                                    WHERE Animal = '{1}'", totalcompra, animal);
            }
        }
    }
}
