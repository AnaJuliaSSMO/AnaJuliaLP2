using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
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

        private void destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sel = destino.SelectedIndex;

            if (sel == 0)
            {
                SoundPlayer simpleSound = new SoundPlayer(TheFarmOfUs.Audios.vaca);
                simpleSound.Play();
            }

            else if (sel == 1)
            {
                SoundPlayer simpleSound = new SoundPlayer(TheFarmOfUs.Audios.boi);
                simpleSound.Play();
            }

            else if (sel == 2)
            {
                SoundPlayer simpleSound = new SoundPlayer(TheFarmOfUs.Audios.galinha);
                simpleSound.Play();
            }

            else if (sel == 3)
            {
                SoundPlayer simpleSound = new SoundPlayer(TheFarmOfUs.Audios.porco);
                simpleSound.Play();
            }

            else if (sel == 4)
            {
                SoundPlayer simpleSound = new SoundPlayer(TheFarmOfUs.Audios.cavalo);
                simpleSound.Play();
            }

            else if (sel == 5)
            {
                SoundPlayer simpleSound = new SoundPlayer(TheFarmOfUs.Audios.cabra);
                simpleSound.Play();
            }

            else if (sel == 6)
            {
                SoundPlayer simpleSound = new SoundPlayer(TheFarmOfUs.Audios.carneiro);
                simpleSound.Play();
            }

            else if (sel == 7)
            {
                SoundPlayer simpleSound = new SoundPlayer(TheFarmOfUs.Audios.coelho);
                simpleSound.Play();
            }

            else
            {
                SoundPlayer simpleSound = new SoundPlayer(TheFarmOfUs.Audios.pato);
                simpleSound.Play();
            }
        }
    }
}
