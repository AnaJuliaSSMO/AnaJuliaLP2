using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class testando
    {
        private string nome1, nome2, nome3;

        public string Nome
        {
            get { return String.Format("{0} {1}{2}", nome1, nome2, nome3); }

            set
            {
                string[] partes = value.Split(' ');

                nome1 = partes[0];
                nome3 = partes[partes.Length - 1];

                for(int i = 1; i < partes.Length-1;i++)
                {
                    nome2 += partes[i] + " ";
                }
            }
        }

        public string nomesobrenome
        {
            get { return String.Format ("{0} {1}", nome1,nome3); }
        }
        public string nomeum
        {
            get { return nome1; }
        }
        public string sobrenome
        {
            get { return nome3; }
            set { nome3 = value; }
        }
        public testando(string nome)
        {
            this.Nome = nome;
        }
    }
}