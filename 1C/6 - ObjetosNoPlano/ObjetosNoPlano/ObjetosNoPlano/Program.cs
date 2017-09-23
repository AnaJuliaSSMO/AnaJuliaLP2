using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, raio;

            Console.WriteLine("Escreva X inicial");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva Y inicial");
            y = int.Parse(Console.ReadLine());

            Circle obj = new Circle();

            obj.x = x;
            obj.y = y;

            Console.WriteLine("Insira o comando: ");
            
            do
            {
                ConsoleKey comando = Console.ReadKey().Key;

                if (comando == ConsoleKey.RightArrow)
                {
                    obj.IrPraDir();                    
                }

                else if (comando == ConsoleKey.LeftArrow)
                {
                    obj.IrPraEs();
                }

                else if (comando == ConsoleKey.UpArrow)
                {
                    obj.IrPraCima();
                }

                else if (comando == ConsoleKey.DownArrow)
                {
                    obj.IrPraBaixo();
                }

                else if (comando == ConsoleKey.Escape)
                {
                    break;
                }

                if (obj.x > 800)
                {
                    obj.x = 800;
                }          

                if (obj.x < 0)
                {
                    obj.x = 0;
                }

                if (obj.y > 600)
                {
                    obj.y = 600;
                }

                if (obj.y < 0)
                {
                    obj.y = 0;
                }
 
                Console.WriteLine(obj.Coordenadas());
            }

            while (true);
        }
    }
}
