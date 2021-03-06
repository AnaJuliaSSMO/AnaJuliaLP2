﻿using System;
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
    public partial class CompraAgrotoxicos : Form
    {
        public CompraAgrotoxicos()
        {
            InitializeComponent();
        }

        private void quercomprar_Click(object sender, EventArgs e)
        {
            txt.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";

            if (nomedesejado.Text != "" && qtd.Text != "" && valor.Text != "00,00" && destino.Text != "")
            {
                string agro = nomedesejado.Text;
                int quantidade = int.Parse(qtd.Text);
                double valorunitario = double.Parse(valor.Text);
                string plantadestino = destino.SelectedItem.ToString();
                double valorcompra = quantidade * valorunitario;

                if (MessageBox.Show("O valor de sua compra foi: R$ " + valorcompra + ".\nDeseja continuar?", "Valor total foi de:", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    CompraVendaRetiradaSaldo.CompraAgro(agro, quantidade, valorcompra, plantadestino);

                    if (CompraVendaRetiradaSaldo.ok == "s")
                    {
                        nomedesejado.ResetText();
                        qtd.Clear();
                        valor.Text = "00,00";
                        destino.ResetText();
                    }

                    else
                    {
                        valor.Text = "00,00";
                    }
                }
            }
            if (nomedesejado.Text == "") { txt.Text = "Preenchimento de campo obrigatório"; }

            if (qtd.Text == "") { txt1.Text = "Preenchimento de campo obrigatório"; }

            if (valor.Text == "") { txt3.Text = "Preenchimento de campo obrigatório"; }

            if (destino.Text == "00,00") { txt2.Text = "Preenchimento de campo obrigatório"; }

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
