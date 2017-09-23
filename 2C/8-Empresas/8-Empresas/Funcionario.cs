using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresas
{
    class Funcionario
    {
        public string Regis { get; set; }
        public string Data { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Setor { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string cpf, string regis, string email, string data,string setor)
        {
            this.Nome = nome;
            this.Data = data;
            this.Regis = regis;
            this.CPF = cpf;
            this.Email = email;
        }
        public Funcionario() { }
    }
}
