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
    public partial class Contabilidade : Form
    {
        public Contabilidade()
        {
            InitializeComponent();
        }

        private void Contabilidade_Load(object sender, EventArgs e)
        {
            int resp = cont.SelectedIndex;

            if (resp == 0)
            {
                //pagamentos,abonos salariais, etc
            }

            else if (resp == 1)
            {
                //controlar o quanto ta vendendo, o quanto de dinheiros tem pras vaquinahs muu
            }

            else if (resp == 2)
            {
                // msm coisa do de cima só q cm plantinhas 
            }

            else if(resp == 3)
            {
                //demitir ou admitir novos caras, eh isso
            }

            else
            {
                Agrupamento_Setores set = new Agrupamento_Setores();
                set.Show();
            }
            Close();
        }
    }
}
