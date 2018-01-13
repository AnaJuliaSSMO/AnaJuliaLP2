using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFarmOfUs
{
    public partial class Gado : Form
    {
        public Gado()
        {
            InitializeComponent();
        }

        private void opitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuantidadeGado gadocont = new QuantidadeGado();
            int resp = opitions.SelectedIndex;

            if (resp == 0)  
            {
                CompraVendadeGadocs a = new CompraVendadeGadocs();
                a.Show();
                /* compra e venda de gado
                 * primeiro ele verifica se há dinheiro o suficiente para comprar o gado
                 * na vdd primeiro ele perfgunta qual animal quer comprar ou vender neah
                 * e a qtd de animais tbm
                 * para isso ele acessa a área de contabilidade que tem que ser sempre atualizada
                 * ou seja, se comprar vaquinha, o valor da vaquinha tem que ir pra área de contabilidade
                 * se vender vaquinha tem que ir tbm
                 Galinha                       
Porco                         
Cabra                         
Cavalo                        
Cavalo                        
Porco                         
Galinha                       
Cabra                         
Coelho                        
Pato                          
Carneiro                      
Boi                           
Vaca*/
            }

            else if (resp == 1)
            {
                /*compra de alimentos, remédios
                 * isso tbm tem que ir pro setor de vaquinhas da área de contabilidade*/
            }

            else if (resp == 2)
            {
                /*se morrer ou nascer algum tem que registrar
                 * e dizer se ele está ou não apto para venda eh isto*/
            }

            else if(resp == 3)
            {
                gadocont.Show();
                //FEITO
            }

            else
            {
                Agrupamento_Setores menu = new Agrupamento_Setores();
                menu.ShowDialog();
            }
            this.Close();
        }
    }
}
