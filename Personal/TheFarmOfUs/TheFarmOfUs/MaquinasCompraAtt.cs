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
    public partial class MaquinasCompraAtt : Form
    {
        public MaquinasCompraAtt()
        {
            InitializeComponent();
        }

        private void quercomprar_Click(object sender, EventArgs e)
        {
            string deseja = "comprar";
            string marca = marcatxt.Text;
            string modelo = modelotxt.Text;
            string ano = anotxt.Text;
            string placa = placatxt.Text;
            int potencia = int.Parse(pote.Text);
            double valor = double.Parse(preco.Text);

            CompraVendaSaldogeral.CompraVendaAttMaquina(marca, modelo, ano, placa,potencia, valor, deseja);

            if(CompraVendaSaldogeral.ok == "s")
            {
                marcatxt.Clear();
                modelotxt.Clear();
                placatxt.Clear();
                anotxt.Clear();
                pote.Clear();
                preco.Clear();
            }

            else
            {
                preco.Clear();
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
