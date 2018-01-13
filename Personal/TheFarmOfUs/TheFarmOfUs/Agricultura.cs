using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFarmOfUs
{
    public partial class Agricultura : Form
    {
        public Agricultura()
        {
            InitializeComponent();
        }

        private void agri_SelectedIndexChanged(object sender, EventArgs e)
        {
            int resp = agri.SelectedIndex;

            if (resp == 0)
            {
                /* compra e venda de gado
                 * primeiro ele verifica se há dinheiro o suficiente para comprar o gado
                 * na vdd primeiro ele perfgunta qual animal quer comprar ou vender neah
                 * e a qtd de animais tbm
                 * para isso ele acessa a área de contabilidade que tem que ser sempre atualizada
                 * ou seja, se comprar vaquinha, o valor da vaquinha tem que ir pra área de contabilidade
                 * se vender vaquinha tem que ir tbm
                 
                imagina isso, mas com planta*/
            }

            else if (resp == 1)
            {
                /*compra de alimentos, remédios
                 * isso tbm tem que ir pro setor de vaquinhas da área de contabilidade
                 msm coisa, imagina isso com plantinhas*/
            }

            else if (resp == 2)
            {
                /*se plantar ou colher alguma coisa vai aqui eh isto */
            }

            else if (resp == 3)
            {
                //´se vender as maquinas comprar maquina vai tudo aqui
            }

            else if(resp == 4)
            {  
                //qto tem d cada
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
