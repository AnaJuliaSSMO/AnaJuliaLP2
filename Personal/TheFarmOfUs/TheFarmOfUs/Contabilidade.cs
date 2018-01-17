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
                //controlar o quanto ta vendendo, o quanto de dinheiros tem pras vaquinahs muu e plantinhas 
            }

            else if (resp == 1)
            {
                //pagamentos,abonos salariais (eu nem sei oq k7's é um abono salarial, mas blz), etc
            }

            else if(resp == 2)
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
