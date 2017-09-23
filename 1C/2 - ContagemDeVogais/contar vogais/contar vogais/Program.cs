using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt;

            Console.WriteLine("Escreva sua frase/palavra aqui");
            txt = Console.ReadLine();

            int cont = 0;

            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == 'a' || txt[i] == 'e' || txt[i] == 'i' || txt[i] == 'o' || txt[i] == 'u')
                {
                    cont++;
                }
            }

            Console.WriteLine("Há {0} vogais na palavra", cont);
            Console.ReadKey();
        }
    }
}

