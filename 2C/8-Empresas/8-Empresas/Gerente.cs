using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresas
{
    class Gerente : Funcionario
    {
        public string Setor { get; set; }
        public string Bonus { get; set; }

        public Gerente(string nome, string cpf, string regis, string email, string data, string setor) : base(nome, cpf, regis, email, data,setor)
        {

        }
        public string Infos(string nome, string cpf, string regis, string email, string data, string setor, double sal,double bonus)
        {   

            return String.Format("O nome do(a) gerente é {0}.\n", nome);
        }
    }
}

