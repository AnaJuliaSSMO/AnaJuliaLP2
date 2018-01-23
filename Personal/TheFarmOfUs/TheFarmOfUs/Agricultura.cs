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
                BuySellplantinhas pl = new BuySellplantinhas();
                pl.Show();
                //FEITO
            }

            else if (resp == 1)
            {
                Agroto agro = new Agroto();
                agro.Show();
                //FEITO 
            }

            else if (resp == 2)
            {
                AttSaca saca = new AttSaca();
                saca.Show();
                //FEITO
            }

            else if (resp == 3)
            {
                MaquinasCompraAtt mac = new MaquinasCompraAtt();
                mac.Show();
                /* parcialmente feito
                 * no caso de uma máquina quebrar ela será substituída, 
                 * mas para isso precisa registrar a "retirada"
                 * vai ter:
                 * placa da máquina, que tem q ser única
                 * motivo da retirada
                 */
                 
                //HALF FEITO
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
