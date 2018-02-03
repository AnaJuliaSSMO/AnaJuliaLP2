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
    public partial class AcessoPecuaria : Form
    {
        public AcessoPecuaria()
        {
            InitializeComponent();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            string nrfs = nrf.Text;

            if (nrfs == "cowandothers" || nrfs == "masterajmlc1901")
            {
                MessageBox.Show("Acesso permitido");
                SetorPecuaria set = new SetorPecuaria();
                set.Show();
                Close();
            }

            else { MessageBox.Show("Acesso negado");}
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Agrupamento_Setores ag = new Agrupamento_Setores();
            ag.Show();
            Close();
        }
    }
}
