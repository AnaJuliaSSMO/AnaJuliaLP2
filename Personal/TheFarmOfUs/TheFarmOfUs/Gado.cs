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
                //FEITO
            }

            else if (resp == 1)
            {
                AlimentoRemedioEtc avr = new AlimentoRemedioEtc();
                avr.Show();
                // FEITO
            }

            else if (resp == 2)
            {
                AcresouReti acrt = new AcresouReti();
                acrt.Show();
                //FEITO
                //CONFERIDO
            }

            else if (resp == 3)
            {
                RetirarVitRemAli acr = new RetirarVitRemAli();
                acr.Show();
                //FEITO
                //CONFERIDO
            }

            else if(resp == 4)
            {
                QuantidadeGado gadocont = new QuantidadeGado();
                gadocont.Show();
                //FEITO
                //CONFERIDO
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
