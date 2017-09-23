using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CodigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp;
            string frase,frase2, resp2;

            Morse nhe = new Morse();

            do
            {
                Console.Write("\nO que deseja fazer?\n1 - Codificar\n2 - Decodificar\n3 - Sair\n");
                resp = int.Parse(Console.ReadLine());

                if (resp == 1)
                {
                    Console.WriteLine("\nO que deseja codificar?");
                    frase = Console.ReadLine();
                    nhe.Codificar(frase);
                    Console.Write("\n");
                }

                else if (resp == 2)
                {
                    Console.WriteLine("\nO que deseja decodificar?");
                    frase2 = Console.ReadLine();
                    nhe.Decodificar(frase2);
                    Console.Write("\n");
                }
            }

            while (resp != 3);
        }
    }
}
       
    

    

