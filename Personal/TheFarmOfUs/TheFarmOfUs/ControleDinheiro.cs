using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*VOU PRECISAR CRIAR UMA CLASSE
QUE VAI SER USADA TANTO NA AGRICULTURA, PECUÁRIA E CONTABILIDADE
ESSA CLASSE VAI SERVIR PARA CONTROLAR O DINHEIRO
eu posso simplesmente fazer a classe "conta dinheiro"
nessa classe ela só recebe o valor da venda/compra das coisas
a cada compra ela tira o valor à variàvel disponivel
a cada venda ela  add o valor à variável "disponível"

nessa classe vão ter:
vai ter q ter um valor fixo, tipo sla, 5000 reais
aí sem comprar algo o novo valor vai ser permanentemente 5000 - o valor da compra
vice versa 

variáveis
public static double disponívelpecuaria; 
public static double disponivelagricultura;

dois métodos:

Agricultura(recebe um double/int que seja, trazendo os valores gastos)

Pecuária(recebe um double/int que seja, trazendo os valores gastos)
*/
namespace TheFarmOfUs
{
    class ControleDinheiro
    {
        public static double disponívelpecuaria;
        public static double disponivelagricultura;

        public static void Agricultura()
        {

        }

        public static void Pecuária()
        {

        }

    }
}
