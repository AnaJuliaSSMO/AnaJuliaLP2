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
            //É MT CONFUSO SCRR
            int resp = opitions.SelectedIndex;

            if (resp == 0)  
            { 
                //COMPRA E VENDA DE VAQUINHA MU
                BuyorSell bs = new BuyorSell();
                bs.Show();
                //FEITO
            }

            else if (resp == 1)
            {
                //COMPRA ALIEMTNO VITAMINA REMÉDIO 
                AlimentoRemedioEtc avr = new AlimentoRemedioEtc();
                avr.Show();
                // FEITO
            }

            else if (resp == 2)
            {
                //ACRESCENTA RETIRA GADP
                AcresouReti acrt = new AcresouReti();
                acrt.Show();
                //FEITO
                //CONFERIDO
            }

            else if (resp == 3)
            {
                // RETIRA QTD D VITAMINA ETC
                RetirarVitRemAli acr = new RetirarVitRemAli();
                acr.Show();
                //FEITO
                //CONFERIDO
            }

            else if(resp == 4)
            {
                //CONSULTA DE ESTOQUE
                QuantidadeGado gadocont = new QuantidadeGado();
                gadocont.Show();
                //FEITO
                //CONFERIDO
            }

            else
            {
                //VOLTAR 
                Agrupamento_Setores menu = new Agrupamento_Setores();
                menu.ShowDialog();
            }
            Close();
        }
    }
}
