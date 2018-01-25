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
    public partial class CompraMaquinas : Form
    {
        public CompraMaquinas()
        {
            InitializeComponent();
        }

        private void quercomprar_Click(object sender, EventArgs e)
        {
            string deseja = "comprar";
            string marca = marcatxt.Text;
            string modelo = modelotxt.Text;
            int potencia = int.Parse(pote.Text);
            string ano = anotxt.Text;
            string placa = placatxt.Text;
            double capacidadetanque = int.Parse(capacidade.Text);
            double valor = double.Parse(preco.Text);

            if (MessageBox.Show("O Valor se sua compra foi: R$ " + valor + ".\nDeseja continuar?", "Valor total foi de:", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                CompraVendaRetiradaSaldo.CompraVendaAttMaquina(marca, modelo, ano, placa, potencia, capacidadetanque, valor, deseja);

                if (CompraVendaRetiradaSaldo.ok == "s")
                {
                    marcatxt.Clear();
                    modelotxt.Clear();
                    placatxt.Clear();
                    anotxt.Clear();
                    pote.Clear();
                    preco.Clear();
                    capacidade.Clear();
                    pote.Clear();
                }

                else
                {
                    preco.Clear();
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
