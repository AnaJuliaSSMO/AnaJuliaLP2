using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Produtos
{
    class Produto
    {
        private string Id { get; set; }
        private int Quantidade { get; set; }
        private string Nome { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }

        public Produto(string nome,string id, int qtd)
        {
            this.Nome = nome;
            this.Id = id;
            this.Quantidade = qtd;
        }
        public string Repor(int qtd, int colocar)
        {
            this.Quantidade = qtd;
            this.Quantidade += colocar;

            return String.Format("Reposição realizada com sucesso. Número de itens atual:{0}",this.Quantidade);
        }

        public string Retirar(int qtd, int colocar ,int retirar)
        {
            this.Quantidade = qtd;
            this.Quantidade += colocar;

            if(this.Quantidade >= retirar)
            {
               this.Quantidade -= retirar;

               return String.Format("Retirada realizada com sucesso. Número de itens atual:{0}", this.Quantidade);
            }

            else
            {
                throw new Exception("VOLUME DE ESTOQUE INSUFICIENTE!");
            }
        }

        public string Print(string id, string nome, double preco,int qtd,int colocar, int retirar)
        {
            this.Preco = preco;
            this.Quantidade = qtd;
            this.Quantidade += colocar;
            this.Quantidade -= retirar;

            return String.Format ("\nProduto Nº:{0}.\nNome:{1}.\nPreço do produto:R${2:0.00}.\nQuantidade disponível no estoque:{3}",id, nome, Preco,this.Quantidade);
        }
    }
}
