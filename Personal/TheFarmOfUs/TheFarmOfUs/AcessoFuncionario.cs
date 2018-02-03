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
    public partial class AcessoFuncionario : Form
    {
        public AcessoFuncionario()
        {
            InitializeComponent();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            string nrfs = nrf.Text;

            if (nrfs == "acessibilidadetotal1901" || nrfs == "masterajmlc1901")
            {
                MessageBox.Show("Acesso permitido");
                SetorFuncionario set = new SetorFuncionario();
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
    }
}
