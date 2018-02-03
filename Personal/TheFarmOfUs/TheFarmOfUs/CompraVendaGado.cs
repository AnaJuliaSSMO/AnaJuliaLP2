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

/*primeiro ele vai ter que fazer um SELECT
 * pedindo pra trazer o valor que tem na tabela "diponivel"*/
namespace TheFarmOfUs
{
    public partial class CompraVendaGado : Form
    {
        public CompraVendaGado()
        {
            InitializeComponent();
        }

        SqlCommand cmd = new SqlCommand()
        {
            Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
        };

        string escolha = "gado";

        private void quercomprar_Click(object sender, EventArgs e)
        {
            string animalescolhido = animais.SelectedItem.ToString();
            int quantidadeani = int.Parse(qtd.Text);
            double valorunitario = double.Parse(valor.Text);
            //OUTRAS
            string deseja = "comprar";
            double valorcompra = valorunitario * quantidadeani;

            MessageBox.Show("O animal escolhido foi: " + animalescolhido);
            if(MessageBox.Show("O valor de sua compra foi: R$ " + valorcompra + ".\nDeseja continuar?","Valor total foi de:",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                CompraVendaRetiradaSaldo.CompraVendaGado(deseja, valorcompra, animalescolhido, quantidadeani);

                if(CompraVendaRetiradaSaldo.ok == "s")
                {
                    animais.ResetText();
                    qtd.Text = "Insira a quantidade";
                    valor.Text = "00,00";
                }

                else
                {
                    valor.Text = "00,00";
                }
            }
        }

        private void animais_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sel = animais.SelectedIndex;

            if (sel == 0)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\AnaJuliaLP2\Personal\TheFarmOfUs\songs\vaca.WAV");
                simpleSound.Play();
            }

            else if (sel == 1)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\AnaJuliaLP2\Personal\TheFarmOfUs\songs\boi.WAV");
                simpleSound.Play();
            }

            else if (sel == 2)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\AnaJuliaLP2\Personal\TheFarmOfUs\songs\galinha.WAV");
                simpleSound.Play();
            }

            else if (sel == 3)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\AnaJuliaLP2\Personal\TheFarmOfUs\songs\porco.WAV");
                simpleSound.Play();
            }

            else if (sel == 4)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\AnaJuliaLP2\Personal\TheFarmOfUs\songs\cavalo.WAV");
                simpleSound.Play();
            }

            else if (sel == 5)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\AnaJuliaLP2\Personal\TheFarmOfUs\songs\cabra.WAV");
                simpleSound.Play();
            }

            else if (sel == 6)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\AnaJuliaLP2\Personal\TheFarmOfUs\songs\carneiro.WAV");
                simpleSound.Play();
            }

            else if (sel == 7)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\AnaJuliaLP2\Personal\TheFarmOfUs\songs\coelho.WAV");
                simpleSound.Play();
            }

            else
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\AnaJuliaLP2\Personal\TheFarmOfUs\songs\pato.WAV");
                simpleSound.Play();
            }
        }

        private void quervender_Click(object sender, EventArgs e)
        {
            string animalescolhido = animais.SelectedItem.ToString();
            int quantidadeani = int.Parse(qtd.Text);
            double valorunitario = double.Parse(valor.Text);
            //OUTRAS
            string deseja = "vender";
            double valorcompra = valorunitario * quantidadeani;

            MessageBox.Show("O animal escolhido foi: " + animalescolhido);
            if (MessageBox.Show("O valor de sua compra foi: R$ " + valorcompra + ".\nDeseja continuar?", "Valor total foi de:", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                CompraVendaRetiradaSaldo.CompraVendaGado(deseja, valorcompra, animalescolhido, quantidadeani);

                if (CompraVendaRetiradaSaldo.ok == "s")
                {
                    animais.ResetText();
                    qtd.Text = "Insira a quantidade";
                    valor.Text = "00,00";
                }

                else
                {
                    qtd.Text = "Insira a quantidade";
                }
            }

            // MessageBox.Show(CompraEVenda.PegarValorDisponivel(escolha));
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


/* EU FIZ UMA MERDA MT MT MT MT MT GRANDE
 * DICULPA EU 
 */ 