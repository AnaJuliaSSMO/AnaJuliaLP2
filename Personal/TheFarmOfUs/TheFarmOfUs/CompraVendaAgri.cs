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
    public partial class CompraVendaAgri : Form
    {
        public CompraVendaAgri()
        {
            InitializeComponent();
        }

        private void quercomprar_Click(object sender, EventArgs e)
        {
            string deseja = "comprar";
            string planta = vendiveis.SelectedItem.ToString();
            int qtdplanta = int.Parse(qtd.Text);
            double valorunitario = double.Parse(valor.Text);
            double valorcompra = valorunitario * qtdplanta;

            MessageBox.Show("O item escolhido foi: " + planta);
            if (MessageBox.Show("O valor se sua compra foi: R$ " + valorcompra + ".\nDeseja continuar?", "Valor total foi de:", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                CompraVendaRetiradaSaldo.CompraVendaPlanta(deseja, valorcompra, planta, qtdplanta);

                if(CompraVendaRetiradaSaldo.ok == "s")
                {
                    vendiveis.ResetText();
                    qtd.Text = "Insira a quantidade";
                    valor.Text = "00,00";
                }

                else
                {
                    valor.Text = "00,00";
                }
            }
        }

        private void quervender_Click(object sender, EventArgs e)
        {
            string deseja = "vender";
            string planta = vendiveis.SelectedItem.ToString();
            int qtdplanta = int.Parse(qtd.Text);
            double valorunitario = double.Parse(valor.Text);
            double valorcompra = valorunitario * qtdplanta;

            MessageBox.Show("O item escolhido foi: " + planta);
            if (MessageBox.Show("O valor se sua venda foi: R$ " + valorcompra + ".\nDeseja continuar?", "Valor total foi de:", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                CompraVendaRetiradaSaldo.CompraVendaPlanta(deseja, valorcompra, planta, qtdplanta);

                if (CompraVendaRetiradaSaldo.ok == "s")
                {
                    vendiveis.ResetText();
                    qtd.Text = "Insira a quantidade";
                    valor.Text = "00,00";
                }

                else
                {
                    qtd.Text = "Insira a quantidade";
                }
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar operação?", "Tem certeza de sua escolha?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SetorAgricultura ag = new SetorAgricultura();
                ag.Show();
                Close();
            }
        }
    }
}
