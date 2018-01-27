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
    public partial class CompraAlipGado : Form
    {
        public CompraAlipGado()
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
            if (MessageBox.Show("O valor dse sua compra foi: R$ " + valortotal + ".\nDeseja continuar?", "Valor total foi de:", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) 
            {
                CompraVendaRetiradaSaldo.CompraeVendaAlimentos(tipo, nome, quantidade, valortotal, destinado);

                if(CompraVendaRetiradaSaldo.ok == "s")
                {
                    desejo.ResetText();
                    nomedesejado.Clear();
                    destino.ResetText();
                    qtd.Clear();
                    valor.Text = "00,00";
                }

                else
                {
                    valor.Text = "00,00";
                }
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar operação?", "Tem certeza de sua escolha?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SetorPecuaria gd = new SetorPecuaria();
                gd.Show();
                Close();
            }
        }
    }
}
