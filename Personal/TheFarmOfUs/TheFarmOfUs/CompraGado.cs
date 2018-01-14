using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFarmOfUs
{
    public partial class CompraGado : Form
    {
        public CompraGado()
        {
            InitializeComponent();
        }

        private void compra_Click(object sender, EventArgs e)
        {   
        }

        private void cancela_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo cancelar operação?", "Tem certeza de sua escolha?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                BuyorSell bs = new BuyorSell();
                bs.Show();
                Close();
            }
        }
    }
}
