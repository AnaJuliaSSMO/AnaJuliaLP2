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
    public partial class AttQtdAnimais : Form
    {
        public AttQtdAnimais()
        {
            InitializeComponent();
        }


        private void acrescentar_Click(object sender, EventArgs e)
        {
            string deseja = "colocar";
            int qtdd = int.Parse(qtd.Text);
            string animal = animais.SelectedItem.ToString();

            CompraVendaRetiradaSaldo.AtualizaAnimais(qtdd, animal, deseja);
            
            qtd.Text = "Insira a quantidade";
            animais.ResetText();
        }

        private void retirar_Click(object sender, EventArgs e)
        {
            string deseja = "retirar";
            int retirar = int.Parse(qtd.Text);
            string animal = animais.SelectedItem.ToString();

            CompraVendaRetiradaSaldo.AtualizaAnimais(retirar, animal, deseja);
            qtd.Text = "Insira a quantidade";
            animais.ResetText();
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
