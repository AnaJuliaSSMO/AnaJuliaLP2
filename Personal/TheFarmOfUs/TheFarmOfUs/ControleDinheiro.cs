using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * AO INVÉS DE CRIAR A TAL CLASSE
 * EU VOU CRIAR UMA TABELA NO BD
 * SIMPLES
 * 
 * 
 * 
 * 
 * vou dxar isso aqui so pra ver o quão burra eu tava sendo :)
 * 
 * VOU PRECISAR CRIAR UMA CLASSE
QUE VAI SER USADA TANTO NA AGRICULTURA, PECUÁRIA E CONTABILIDADE
ESSA CLASSE VAI SERVIR PARA CONTROLAR O DINHEIRO
eu posso simplesmente fazer a classe "conta dinheiro"
nessa classe ela só recebe o valor da venda/compra das coisas
a cada compra ela tira o valor à variàvel disponivel
a cada venda ela  add o valor à variável "disponível"

nessa classe vão ter:
vai ter q ter um valor fixo, tipo sla, 5000 reais
aí sem comprar algo o novo valor vai ser permanentemente 5000 - o valor da compra
vice versa 

variáveis
public static double disponívelpecuaria; 
public static double disponivelagricultura;

dois métodos:

Agricultura(recebe um double/int que seja, trazendo os valores gastos)

Pecuária(recebe um double/int que seja, trazendo os valores gastos)

Após falar algumas coisas burras, AJ notou que só tinha q fazer uma conta de + e de - e enviar pra m*rda do banco :)
*/
namespace TheFarmOfUs
{
    class ControleDinheiro
    {
        //NÃO PRECISA DISSO PQ TEM Q PEGAR O VALOR DO BANCO DÃÃÃÃÃÃÃ public static double fixo = 5000; //os dois setores começam com o mesmo valor
        //vou passar a dxar as variáveis erradas pra eu ver o quão idi eu tava sendo
        public static string convtenho,cone = "";
        public static void Pecuaria(double tenho)
        {
            convtenho = tenho.ToString();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
            };

            cmd.Connection.Open();
            cmd.CommandText = String.Format(@"UPDATE Disponivel 
                                            SET Valor_disponivel = '{0}'
                                            WHERE Setor = 'Pecuaria'",convtenho);
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Connection.Close();
        }

        public static void Agricultura(double tenho)
        {
            convtenho = tenho.ToString();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
            };

            cmd.Connection.Open();
            cmd.CommandText = String.Format(@"UPDATE Disponivel 
                                            SET Valor_disponivel = '{0}'
                                            WHERE Setor = 'Agricultura'",convtenho);
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Connection.Close();
        }

        public static string VerPecuaria()
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

            if (cone == "")
            {
                cmd.CommandText = String.Format(@"SELECT Valor_disponivel
                                               FROM Disponivel
                                               WHERE Setor = 'Pecuaria'");

                convtenho = cmd.ExecuteScalar().ToString();

                SqlDataReader reader = cmd.ExecuteReader();
                cmd.Connection.Close();
            }
            return String.Format(convtenho);
        }

        public static string VerAgricultura()
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

            if (cone == "")
            {
                cmd.CommandText = String.Format(@"SELECT Valor_disponivel
                                               FROM Disponivel
                                               WHERE Setor = 'Pecuaria'");

                convtenho = cmd.ExecuteScalar().ToString();

                SqlDataReader reader = cmd.ExecuteReader();
                cmd.Connection.Close();
            }
            return String.Format(convtenho);
        }
    }
}
