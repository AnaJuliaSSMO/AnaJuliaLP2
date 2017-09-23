using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LeituraOtica
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, A,B,C,D,E;

            string resposta = "nice";

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int preto = 0, branco = 0, ast = 0;

                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                C = int.Parse(Console.ReadLine());
                D = int.Parse(Console.ReadLine());
                E = int.Parse(Console.ReadLine());

                if (A <= 100) { preto++; resposta = "A"; }
                else if (A >= 155) { branco++; }
                else { ast++; }

                if (B <= 100) { preto++; resposta = "B"; }
                else if (B >= 155) { branco++; }
                else { ast++; }

                if (C <= 100) { preto++; resposta = "C"; }
                else if (C >= 155) { branco++; }
                else { ast++; }

                if (D <= 100) { preto++; resposta = "D"; }
                else if (D >= 155) { branco++; }
                else { ast++; }

                if (E <= 100) { preto++; resposta = "E"; }
                else if (E >= 155) { branco++; }
                else { ast++; }

                if (preto > 1 || ast >= 1 || branco > 4)
                {
                    Console.WriteLine("*");
                }

                else if (preto == 1)
                {
                    Console.WriteLine(resposta);
                }
            }
        }
    }
}
