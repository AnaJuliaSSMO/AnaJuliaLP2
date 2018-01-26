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
    public partial class SetorAgricultura : Form
    {
        public SetorAgricultura()
        {
            InitializeComponent();
        }

        private void agri_SelectedIndexChanged(object sender, EventArgs e)
        {
            int resp = agri.SelectedIndex;

            if (resp == 0)
            {
                CompraVendaAgri pl = new CompraVendaAgri();
                pl.Show();
                //FEITO
            }

            else if (resp == 1)
            {
                CompraAgrotoxicos agro = new CompraAgrotoxicos();
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
                CompraMaquinas mac = new CompraMaquinas();
                mac.Show();
                //FEITO
            }

            else if (resp == 4)
            {
                RetirarMaquinas re = new RetirarMaquinas();
                re.Show();
                //FEITO
            }
            else if(resp == 5)
            {
                Desejair de = new Desejair();
                de.Show();
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
