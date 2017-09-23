using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresas
{
    class Terceirizado : Empregado
    {
        public Gerente Setor;
        public string Matriz;

        public Terceirizado(string nome, string cpf, string regis, string email, string data, string setor) : base(nome, cpf, regis, email, data, setor)
        {
        }
        public string Infos(string nome, string cpf, string regis, string email, string data, string setor)
        {
            return String.Format("O nome do(a) terceirizado(a) é {0}.\n", nome);
        }
    }
}
