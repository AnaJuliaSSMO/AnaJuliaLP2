using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LivrosHermione //qtdnler = 0,  
{
    class Program
    {
        static void Main(string[] args)
        {
            //ppd = pags por dia (pph*hpd)
            //pph = pags por hora
            //hpd = hrs de leitura por dia
            //templer = tempo de leitura total de 1 livro

            double pph, hpd, ppd, templer = 0, lertodos = 0;
            int n, na1 = 0;

            Console.WriteLine("Insira a quantidade de livros:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas páginas você lê por hora?");
            pph = double.Parse(Console.ReadLine());

            Console.WriteLine("Por quantas horas você lê diariamente?");
            hpd = double.Parse(Console.ReadLine());

            Livro[] book = new Livro[n];

            string[] nau = new string[n];

            ppd = pph * hpd;

            for (int i = 0; i < n; i++)
            {
                book[i] = new Livro();

                Console.WriteLine("\nInsira o título do {0}º livro:", i + 1);
                book[i].title = Console.ReadLine();

                Console.WriteLine("Número de páginas que o livro {0}º  possui:", i + 1);
                book[i].pags = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual o tempo restante para devolução(em dias) do {0}º livro?", i + 1);
                book[i].devolver = double.Parse(Console.ReadLine());

                templer = book[i].pags / ppd; //DE 1 LIVRO

                lertodos = lertodos + templer; //TODOS ELES

                Console.WriteLine("Você levará {0} dia(s) para ler o livro '{1}'", templer, book[i].title);

                if (templer > book[i].devolver)
                {
                    nau[na1] = book[i].title;
                    na1++;
                }
            }
            Console.WriteLine("\nDemorará {0} dias para você ler todos os livros", lertodos);

            if (na1 > 0)
            {
                for (int i = 0; i < na1; i++)
                {
                    Console.WriteLine("\nLivro(s) impossíveis de serem lidos:");
                    Console.WriteLine(nau[i]);
                }
            }

            Console.ReadKey();
        }
    }
}