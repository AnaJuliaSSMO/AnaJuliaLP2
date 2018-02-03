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
    public partial class AcessoSenha : Form
    {
        public AcessoSenha()
        {
            InitializeComponent();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            string nrfs = nrf.Text;

            if (nrfs == "masterajmlc1901")
            {
                MessageBox.Show("Acesso permitido");
                RefazSenha set = new RefazSenha();
                set.Show();
                Close();
            }

            else { MessageBox.Show("Acesso negado"); }
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
