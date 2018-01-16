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
            string nome = nomes.Text;
            int quantidade = int.Parse(qtd.Text);
            double valores = double.Parse(valor.Text);
            double disponivel = 5000;

            valores *= quantidade; 

            if(disponivel > valores)
            {
                AlimentoRemedioVitamina.Compra(tipo, nome, quantidade, valores);
                disponivel -= valores;
                if (AlimentoRemedioVitamina.cone == "")
                {
                    MessageBox.Show("Efetuado com sucesso,você possui " + AlimentoRemedioVitamina.qtd + "kg/embalagens de " + nome);
                    MessageBox.Show("Saldo disponível para o setor de gado: " + disponivel);
                }

                else
                {
                    MessageBox.Show(AlimentoRemedioVitamina.cone);
                }

            }

            else
            {
                MessageBox.Show("Poucos dinheiros.Pode-se gastar até R$" + disponivel + ".Por favor,insira um novo valor");
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
