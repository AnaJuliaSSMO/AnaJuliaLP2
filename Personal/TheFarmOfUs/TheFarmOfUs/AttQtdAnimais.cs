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
    public partial class AttQtdAnimais : Form
    {
        public AttQtdAnimais()
        {
            InitializeComponent();
        }


        private void acrescentar_Click(object sender, EventArgs e)
        {
            txt.Text = "";
            txt1.Text = "";

            if (animais.Text != null && qtd.Text != "Insira a quantidade")
            {
                string deseja = "colocar";
                int qtdd = int.Parse(qtd.Text);
                string animal = animais.SelectedItem.ToString();

                CompraVendaRetiradaSaldo.AtualizaAnimais(qtdd, animal, deseja);

                qtd.Text = "Insira a quantidade";
                animais.ResetText();
            }

            if(animais.Text == "") { txt.Text = "Preenchimento de campo obrigatório"; }

            if (qtd.Text == "Insira a quantidade") { txt1.Text = "Preenchimento de campo obrigatório"; }
        }

        private void retirar_Click(object sender, EventArgs e)
        {
            txt.Text = "";
            txt1.Text = "";

            if (animais.Text != null && qtd.Text != "Insira a quantidade")
            {
                string deseja = "retirar";
                int qtdd = int.Parse(qtd.Text);
                string animal = animais.SelectedItem.ToString();

                CompraVendaRetiradaSaldo.AtualizaAnimais(qtdd, animal, deseja);

                qtd.Text = "Insira a quantidade";
                animais.ResetText();
            }

            if (animais.Text == "") { txt.Text = "Preenchimento de campo obrigatório"; }

            if (qtd.Text == "Insira a quantidade") { txt1.Text = "Preenchimento de campo obrigatório"; }
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

        private void animais_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sel = animais.SelectedIndex;

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
