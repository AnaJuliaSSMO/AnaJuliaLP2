using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresas
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf, regis, email, data, nome,setor,resp;
            int cargo;
            double sal,bonus;

            Console.WriteLine("Empresa:AJ's life\nPreenchimento de ficha padrão para funcionários.\nInsira o:");
            while (true)
            {
            cod:
                Console.WriteLine("\nCargo (1-Gerente / 2-Empregado comum /3-Terceirizado");
                cargo = int.Parse(Console.ReadLine());

                if (cargo > 3)
                {
                    Console.Write("\nCargo Inválido, insira o código novamente");
                    goto cod;
                }

                Console.WriteLine("\nNome:");
                nome = Console.ReadLine();

                Console.WriteLine("\nCPF:");
                cpf = Console.ReadLine();

                Console.WriteLine("\nNúmero de registro:");
                regis = Console.ReadLine();

                Console.WriteLine("\nE-mail:");
                email = Console.ReadLine();

                Console.WriteLine("\nData de entrada na empresa(dd/mm/aaaa:");
                data = Console.ReadLine();

                Console.WriteLine("\nSetor:");
                setor = Console.ReadLine();

                Console.WriteLine("\nSalário:");
                sal = double.Parse(Console.ReadLine());

                Funcionario f = new Funcionario(nome, cpf, regis, email, data,setor);
                Gerente g = new Gerente(nome, cpf, regis, email, data,setor);
                Empregado e = new Empregado(nome, cpf, regis, email, data,setor);
                Terceirizado t = new Terceirizado(nome, cpf, regis, email, data,setor);

                if (cargo == 1)
                {
                    Console.WriteLine("\nSua porcetagem de bonus salarial:");
                    bonus = double.Parse(Console.ReadLine());
                    Console.Write(g.Infos(nome, cpf, regis, email, data,setor, sal,bonus));
                }

                else if (cargo == 2)
                {
                    Console.Write(e.Infos(nome, cpf, regis, email, data,setor));
                }

                else if (cargo == 3)
                {
                    Console.Write(t.Infos(nome, cpf, regis, email, data,setor));
                }

                Console.WriteLine("Deseja inserir outro funcionário? S / N");
                resp = Console.ReadLine();

                if (resp == "n" || resp == "N") { break; }
            }
        }
    }
}

/*is it ever gonna change?
let me just give up
let me just stop trying
let me just stop fighting 
if dont wanna ur good advices
or reasons why im alright
you dont know what its like*/