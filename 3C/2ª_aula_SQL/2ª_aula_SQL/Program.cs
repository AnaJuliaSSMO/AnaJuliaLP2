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
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=localhost; Initial Catalog=AJIN209; Integrated Security=SSPI;"),
            };

            string modelo, cor, placa;
            int pot, ano,resp,ide;

            Console.WriteLine("O que deseja fazer?\n1-Inserir dados;\n2-Deletar dados;\n3-Consultar tabela\n4-Sair;");
            resp = int.Parse(Console.ReadLine());

            if (resp == 1)
            {
                Console.WriteLine("Digite o/a:\nModelo:");
                modelo = Console.ReadLine();
                Console.WriteLine("\nCor:");
                cor = Console.ReadLine();
                Console.WriteLine("\nPlaca:");
                placa = Console.ReadLine();
                Console.WriteLine("\nPotência (em horses):");
                pot = int.Parse(Console.ReadLine());
                Console.WriteLine("\nAno:");
                ano = int.Parse(Console.ReadLine());

                cmd.CommandText = String.Format(@"INSERT
                                              INTO CARRO
                                              VALUES ('{0}','{1}','{2}',{3},{4});", modelo, cor, placa, pot, ano);

                Console.Clear();
                Console.WriteLine("Registro efetuado com sucesso!");
            }

            else if (resp == 2)
            {
                Console.WriteLine("O que deseja deletar? (por ID)");
                ide = int.Parse(Console.ReadLine());

                cmd.CommandText = String.Format(@"DELETE
                                                   FROM CARRO
                                                   WHERE Id = {0});", ide);

                Console.Clear();
                Console.WriteLine("Registro deletado com sucesso!");
            }

            else if (resp == 3)
            {
                cmd.CommandText = @"SELECT *
                                  FROM CARRO";

                Console.WriteLine("{0,3} {1,-18} {2,-15} {3,-9} {4,-6} {5,-3}", "Id", "Modelo", "Cor", "Placa", "Potência", "Ano");

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int Id = reader.GetInt32(0);
                        string Modelo = reader.GetString(1);
                        string Cor = reader.GetString(2);
                        string Placa = reader.GetString(3);
                        int Pot = reader.GetInt32(4);
                        int Ano = reader.GetInt32(5);

                        Console.WriteLine("{0,3} {1,-18} {2,-15} {3,-9} {4,-3} {5,0}", Id, Modelo, Cor, Placa, Pot, Ano);
                    }
                }

                cmd.Connection.Close();

            }

            else
            {
                Console.ReadKey();
            }                  
           
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
