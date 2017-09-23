using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Geometria
{
    class Triângulo
    {
        private double areatri;
        public double Areatri
        {
            get { return areatri; }
        }

        private double perim;
        public double Perim
        {
            get { return perim; }
        }


        public string AreaT(double bas, double hal)
        {
            areatri = (bas * hal) / 2;

            return String.Format("A área do triângulo é:{0}cm\n", areatri);
        }

        public string Perimetro(double lado1, double lado2, double lado3)
        {
            perim = lado1 + lado2 + lado3;

            return String.Format("O perímetro do triângulo é:{0}cm\n", perim);
        }

        public string Classificacao(double lado1, double lado2, double lado3)
        {
            if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
            {
                return String.Format("O triângulo é equilátero\n");
            }

            else if (lado1 == lado2 && lado1 != lado3)
            {
                return String.Format("O triângulo é isósceles\n");
            }

            else if (lado1 == lado3 && lado1 != lado2)
            {
                return String.Format("O triângulo é isósceles\n");
            }

            else if (lado2 == lado3 && lado2 != lado1)
            {
                return String.Format("O triângulo é isósceles\n");
            }

            else if (lado2 == lado3 && lado3 != lado1)
            {
                return String.Format("O triângulo é isósceles\n");
            }

            else
            {
                return String.Format("O triângulo é escaleno\n");
            }

        }
    }
}
