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

            if (nrfs != "355457466") { MessageBox.Show("Acesso negado"); }

            else
            {
                MessageBox.Show("Acesso permitido");
                CadastrarLogin cad = new CadastrarLogin();
                cad.Show();
                seg1 seg = new seg1();
                seg.Close();
            }
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
