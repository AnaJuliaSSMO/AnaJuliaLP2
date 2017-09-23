using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            string data, dia, mes, ano;

            data = Console.ReadLine();
           
            dia = data.Substring(0,2);
            mes = data.Substring(3,2);
            ano = data.Substring(6,4);
            
            switch (mes)
            {
                case "01":
                    mes  = "janeiro";
                    break;

                case "02":
                    mes = "fevereiro";
                    break;

                case "03":
                    mes = "março";
                    break;

                case "04":
                    mes = "abril";
                    break;

                case "05":
                    mes = "maio";
                    break;

                case "06":
                    mes = "junho";
                    break;

                case "07":
                    mes = "julho";
                    break;

                case "08":
                    mes = "agosto";
                    break;

                case "09":
                    mes = "setembro";
                   break;

                case "10":
                    mes = "outubro";
                    break;

                case "11":
                    mes = "novembro";
                   break;

                case "12":
                    mes = "dezembro";
                   break;            
            }

            Console.WriteLine("{0} de {1} de {2}", dia,mes,ano);
            Console.ReadKey();
        }  
    }
}
