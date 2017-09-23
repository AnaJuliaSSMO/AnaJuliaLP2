using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Geometria
{
    class Círculo
    {
        private double perimcir;
        public double Perimcir
        {
            get { return perimcir; }
        }

        private double areacir;
        public double Areacir
        {
            get { return areacir; }
        }

        public string PerimetroC(double raio)
        {
            perimcir = (2 * Math.PI) * raio;

            return String.Format("O perímetro do círculo é:{0}cm\n", perimcir);
        }

        public string AreaC(double raio)
        {
            areacir = 2 * (raio * raio);

            return String.Format("A área do círculo é:{0}cm\n", areacir);
        }
    }
}
