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
    public partial class AttSaca : Form
    {
        public AttSaca()
        {
            InitializeComponent();
        }

        private void att_Click(object sender, EventArgs e)
        {
            string nome = nom.Text;
            int quant = int.Parse(qtd.Text);

            CompraVendaSaldogeral.AttSacas(nome, quant);
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar operação?", "Tem certeza de sua escolha?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Agricultura ag = new Agricultura();
                ag.Show();
                Close();
            }
        }
    }
}
