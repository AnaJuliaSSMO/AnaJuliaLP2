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
            int resp = opitions.SelectedIndex;

            if (resp == 0)  
            {
                BuyorSell bs = new BuyorSell();
                bs.Show();
                /*AINDA FALTA:       
                 * 
                 * COMPRA:
                 * ACESSAR O SETOR DE CONTABILIDADE PARA SABER QUAL O VALOR QUE TEM PARA SER USADO;
                 * ASSOCIAR O VALOR DO SETOR À VARIÁVEL "TENHO"
                 * 
                 * VENDA:
                 * ACESSAR O SETOR DE CONTABILIDADE PARA ADICIONAR O VALOR DA VENDA;
                 * 
                 * GERAL:
                 * QUANDO ALTERAR O VALOR NA COMPRA, ALTERAR O VALOR DO SETOR DE CONTABILIDADE
                 * MESMA COISA COM A VENDA
                 * 
                 * EX
                 * COMPREI 2 VACAS A 50,00
                 * TENHO_NO_SETOR = 5000
                 * 
                 * ENVIO O VALOR DA COMPRA PARA O SETOR
                 * NOVO_TENHO_NO_SETOR = 4900
                 * 
                 * COMPREI 2 VACAS A 50,00 
                 * ENVIO O VALOR DA VENDA PARA O SETOR
                 * NOVO_TENHO_NO_SETOR = 5000*/

            }

            else if (resp == 1)
            {
                AlimentoRemedioEtc avr = new AlimentoRemedioEtc();
                avr.Show();
                /*AINDA FALTA:     
                 * USAR O VALOR DISPONÍVEL NO SETOR GADO
                 * ESSE VALOR TERIA QUE VIR DA CONTABILIDADE
                 * NÃO ESQUECER QUE
                 * 
                 * SE USAR O VALOR DO GADO EM QUALQUER LUGAR, SEJA NA COMPRA DE REMÉDIOS,DE GADO OU VENDA
                 * TEM QUE ATUALIZAR NA CONTABILIDADE*/

            }

            else if (resp == 2)
            {
                AcresouReti acrt = new AcresouReti();
                acrt.Show();
                //FEITO
            }

            else if (resp == 3)
            {
                AcrescentaRetiraVitAliRem acr = new AcrescentaRetiraVitAliRem();
                acr.Show();
                //acrescentar ou retirar remedios do estoque 
            }

            else if(resp == 4)
            {
                QuantidadeGado gadocont = new QuantidadeGado();
                gadocont.Show();
                //FEITO
            }

            else
            {
                Agrupamento_Setores menu = new Agrupamento_Setores();
                menu.ShowDialog();
            }
            Close();
        }
    }
}
