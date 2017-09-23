using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double cel = 0;
            string e;

            ConvertTemp temp = new ConvertTemp();


            Console.WriteLine("Para qual escala quer converter? F para Fahrenheit e K para kelvin");
            e = Console.ReadLine();

            Console.WriteLine("\nInsira a temperatura em celsius");
            cel = double.Parse(Console.ReadLine());

            temp.cels = cel;

            if(e == "F")
            {
                Console.WriteLine("\n" + temp.paraF(temp.far));
            }

            else
            {
                Console.WriteLine("\n" + temp.paraK(temp.kel));
            }
        }
    }
}
