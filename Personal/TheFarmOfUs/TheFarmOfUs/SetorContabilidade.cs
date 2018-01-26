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
    public partial class SetorContabilidade : Form
    {
        public SetorContabilidade()
        {
            InitializeComponent();
        }

        private void Contabilidade_Load(object sender, EventArgs e)
        {
        }

        private void cont_SelectedIndexChanged(object sender, EventArgs e)
        {
            int select = cont.SelectedIndex;

            if (select == 0)
            {
                VerSaldo ver = new VerSaldo();
                ver.Show();
                //FEITO
                //CONFERIDO E MDS Q Q EU TAVA FAZENDO
            }

            else if (select == 1)
            {
                /*pagamentos,abonos salariais (eu nem sei oq k7's é um abono salarial, mas blz), etc
                 * DESCOBRI OQ É ABONO
                 * e n sou eu quem controlo isso :p
                 */
            }

            else if (select == 2)
            {
                //demitir ou admitir novos caras, eh isso
                //vou ter que criar um banco "Funcionários"
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
