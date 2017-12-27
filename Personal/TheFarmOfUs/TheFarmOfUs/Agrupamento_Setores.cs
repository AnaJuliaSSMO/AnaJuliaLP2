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
                Gado vaca = new Gado();
                vaca.Show();
            }

            else if(resp == 1)
            {
                Agricultura planta = new Agricultura();
                planta.Show();
            }

            else if(resp == 2)
            {
                Funcionario func = new Funcionario();
                func.Show();
            }

            else
            {
                Contabilidade cont = new Contabilidade();
                cont.Show();
            }
        }
    }
}
