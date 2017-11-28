using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ª_aula_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string modelo, cor, placa, resp;
            int pot, ano;

            Console.WriteLine("Digite o/a:\nModelo:");
            modelo = Console.ReadLine();
            Console.WriteLine("\nCor:");
            cor = Console.ReadLine();
            Console.WriteLine("\nPlaca:");
            placa = Console.ReadLine();
            Console.WriteLine("\nPotência (em horses):");
            pot = int.Parse(Console.ReadLine());
            Console.WriteLine("\nAno:");
            ano = int.Parse(Console.ReadLine());*/

            SqlCommand cmd = new SqlCommand()
            {

                Connection = new SqlConnection("Data Source=localhost; Initial Catalog=AJIN209; Integrated Security=SSPI;"),

                //CommandText = @"DELETE
                            //  FROM CARRO
                            //  WHERE Id = 2",
                
                CommandText = @"SELECT Id,cor,ano
                              FROM CARRO"

              /*  CommandText = string.Format(@"INSERT
                                              INTO CARRO
                                              VALUES ('{0}','{1}','{2}',{3},{4});", modelo, cor, placa, pot, ano)*/
            };

            try
            {
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.Connection.Close(); 
            } 

            catch(Exception e)
            {
                Console.Write("No not today\n");
            }

        }
    }
}
