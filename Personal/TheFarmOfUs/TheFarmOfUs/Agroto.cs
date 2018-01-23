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
    public partial class Agroto : Form
    {
        public Agroto()
        {
            InitializeComponent();
        }

        private void quercomprar_Click(object sender, EventArgs e)
        {
            string agro = nomedesejado.Text;
            int quantidade = int.Parse(qtd.Text);
            double valorunitario = double.Parse(valor.Text);
            string plantadestino = destino.Text;
            double valorcompra = quantidade * valorunitario;
            
            if (MessageBox.Show("O Valor se sua compra foi: R$ " + valorcompra + ".\nDeseja continuar?", "Valor total foi de:", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                CompraVendaSaldogeral.CompraAgro(agro, quantidade, valorcompra, plantadestino);
            }
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
