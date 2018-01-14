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
    public partial class BuyorSell : Form
    {
        public BuyorSell()
        {
            InitializeComponent();
        }

        private void quercomprar_Click(object sender, EventArgs e)
        {
            CompraGado cg = new CompraGado();
            cg.Show();
            Close();
        }

        private void quervender_Click(object sender, EventArgs e)
        {
            VendeGado vg = new VendeGado();
            vg.Show();
            Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Gado gd = new Gado();
            gd.Show();
            Close();
        }
    }
}
