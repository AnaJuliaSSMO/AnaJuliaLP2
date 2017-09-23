using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = 0;
            double preco;

            Produto p = new Produto("Arroz Dhi&Ana 5kg", "18011901", qtd);

            Console.WriteLine("Qual o preço atual do produto?");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("\nQuantas unidades deseja colocar no estoque?");
            int colocar = int.Parse(Console.ReadLine());
            Console.WriteLine(p.Repor(qtd, colocar));

            Console.WriteLine("\nQuantas unidades deseja retirar do estoque?");
            int retirar = int.Parse(Console.ReadLine());
            Console.WriteLine(p.Retirar(qtd,colocar,retirar));
       
            Console.WriteLine(p.Print("18190101", "Arroz Dhi&Ana 5kg", preco,qtd,colocar,retirar));

        }
    }
}
