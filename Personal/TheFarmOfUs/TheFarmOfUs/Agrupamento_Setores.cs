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
    public partial class Agrupamento_Setores : Form
    {
        public Agrupamento_Setores()
        {
            InitializeComponent();
        }

        private void choosesetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int resp = choosesetor.SelectedIndex;

            if(resp == 0)
            {
                AcessoPecuaria ace = new AcessoPecuaria();
                ace.Show();
                //FEITO
            }

            else if(resp == 1)
            {
                AcessoAgricultura ace = new AcessoAgricultura();
                ace.Show();
                //FEITO
            }

            else if(resp == 2)
            {
                AcessoFuncionario ace = new AcessoFuncionario();
                ace.Show();
                //FEITO
            }

            else if(resp == 3)
            {
                AcessoContabilidade ace = new AcessoContabilidade();
                ace.Show();
                //FEITO
            }
                
            else
            {
                MenuInicial menu = new MenuInicial();
                Close();
                menu.ShowDialog();
            }
            Close();
        }
    }
}
