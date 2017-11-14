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
            SqlConnection conexao = new SqlConnection("Data Source=localhost; Initial Catalog=AJIN209; Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;

            string marca, modelo, cor, placa;
            int pot;

            Console.WriteLine("Digite o/a:Marca");
            marca = Console.ReadLine();
            Console.WriteLine("\nModelo:");
            modelo = Console.ReadLine();
            Console.WriteLine("\nCor:");
            cor = Console.ReadLine();
            Console.WriteLine("\nPlaca:");
            placa = Console.ReadLine();
            Console.WriteLine("\nPotência (em horses):");
            pot = int.Parse(Console.ReadLine());
            
            cmd.CommandText = @"
            INSERT
            INTO carro 
            VALUES (marca,modelo,cor,placa,pot)";
            cmd.Connection.Open();
            cmd.Connection.Close();
       
        }
    }
}
