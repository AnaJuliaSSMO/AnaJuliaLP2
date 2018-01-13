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
    public partial class CompraVendadeGadocs : Form
    {
        public CompraVendadeGadocs()
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
                Gado gado = new Gado();
                gado.ShowDialog();
                Close();
            }
                
        }
    }
}
