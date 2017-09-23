using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            testando t = new testando("Ana Júlia Silva de Almeida da Silva");

            t.Nome = Console.ReadLine();
            
            Console.WriteLine("\n" + t.Nome + "\n");
            Console.WriteLine(t.nomeum + "\n");
            Console.WriteLine(t.sobrenome + "\n");
            Console.WriteLine(t.nomesobrenome + "\n");

            t.sobrenome = "Olveira";
        }
    }
}
