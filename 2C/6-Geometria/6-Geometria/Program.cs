using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            double bas, hal, lado1, lado2, lado3;//triangulo
            double raio; //circulo
            double lado; //quadrado

            Console.WriteLine("Escreva as características do triângulo(lado1,lado2,lado3,base e altura):");
            lado1 = double.Parse(Console.ReadLine());
            lado2 = double.Parse(Console.ReadLine());
            lado3 = double.Parse(Console.ReadLine());
            bas = double.Parse(Console.ReadLine());
            hal = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEscreva o raio do círculo:");
            raio = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEscreva o lado do quadrado:");
            lado = double.Parse(Console.ReadLine());

            Triângulo t = new Triângulo();
            Círculo c = new Círculo();
            Quadrado q = new Quadrado();

            Console.WriteLine(t.AreaT(bas,hal));
            Console.WriteLine(t.Perimetro(lado1,lado2,lado3));
            Console.WriteLine(t.Classificacao(lado1,lado2,lado3));

            Console.WriteLine(q.AreaQ(lado));
            Console.WriteLine(q.PerimetroQ(lado));
        }
    }
}
