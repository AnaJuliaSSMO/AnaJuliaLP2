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
    public partial class seg1 : Form
    {
        public seg1()
        {
            InitializeComponent();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            string nrfs = nrf.Text;

            if (nrfs == "355457466" || nrfs == "masterajmlc1901")
            {
                MessageBox.Show("Acesso permitido");
                CadastrarLogin set = new CadastrarLogin();
                set.Show();
                Close();
            }

            else { MessageBox.Show("Acesso negado"); }
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
