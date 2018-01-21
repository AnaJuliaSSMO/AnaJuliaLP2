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
    public partial class AlimentoRemedioEtc : Form
    {
        public AlimentoRemedioEtc()
        {
            InitializeComponent();
        }

        private void quercomprar_Click(object sender, EventArgs e)
        {
            string tipo = desejo.SelectedItem.ToString();
            string nome = nomedesejado.Text;
            string destinado = destino.SelectedItem.ToString();
            int quantidade = int.Parse(qtd.Text);
            double valorunitario = double.Parse(valor.Text);
            double valortotal;

            valortotal = valorunitario * quantidade;
            if (MessageBox.Show("O Valor se sua compra foi: R$ " + valortotal + ".\nDeseja continuar?", "Valor total foi de:", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) ;
            {
                CompraEVenda.CompraeVendaAlimentos(tipo, nome, quantidade, valortotal, destinado);
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar operação?", "Tem certeza de sua escolha?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Gado gd = new Gado();
                gd.Show();
                Close();
            }
        }
    }
}
