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
    public partial class AcessoAgricultura : Form
    {
        public AcessoAgricultura()
        {
            InitializeComponent();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            string nrfs = nrf.Text;

            if (nrfs == "agriculturavegetal" || nrfs == "masterajmlc1901")
            {
                MessageBox.Show("Acesso permitido");
                SetorAgricultura set = new SetorAgricultura();
                set.Show();
                Close();
            }

            else { MessageBox.Show("Acesso negado"); }
        }

        private void sair_Click_1(object sender, EventArgs e)
        {
            Agrupamento_Setores ag = new Agrupamento_Setores();
            ag.Show();
            Close();
        }

        private void nrf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
