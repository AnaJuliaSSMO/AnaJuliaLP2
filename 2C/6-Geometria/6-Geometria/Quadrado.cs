using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Geometria
{
    class Quadrado
    {
        private double perimquad;
        public double Perimquad
        {
            get { return perimquad; }
        }

        private double areaquad;
        public double Areaquad
        {
            get { return areaquad; }
        }


        private double diagoquad;
        public double Diagoquad
        {
            get { return diagoquad; }
        }

        public string PerimetroQ(double lado)
        {
            perimquad = (lado*4);

            return String.Format("O perímetro do quadrado é:{0}cm\n", perimquad);
        }

        public string AreaQ(double lado)
        {
            areaquad = (lado * lado);

            return String.Format("A área do quadrado é:{0}cm\n", areaquad);
        }

        public string DiagonalQ(double lado)
        {
            diagoquad = 2*(lado * lado);

            return String.Format("A diaonal do quadrado é:{0}cm\n", diagoquad);
        }
    }
}
