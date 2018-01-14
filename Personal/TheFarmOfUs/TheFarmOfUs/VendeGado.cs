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
    public partial class VendeGado : Form
    {
        public VendeGado()
        {
            InitializeComponent();
        }

        private void vende_Click(object sender, EventArgs e)
        {
            //variáveis vindas da form
            int qtdvendida = int.Parse(qtd.Text),qtdatual;
            double preco = double.Parse(valor.Text);
            string animal = animais.SelectedItem.ToString();

            //variáveis "auxiliares"
            double precototal = preco * qtdvendida,totaldinheiro, animaisrestantes;

            MessageBox.Show("O animal escolhido foi: " + animal);
            if (MessageBox.Show("O total da sua venda é de R$" + precototal + "\nDeseja continuar?", "Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
                };

                try
                {
                    cmd.Connection.Open();
                }

                catch (SqlException)
                {
                    MessageBox.Show("Não foi possível efeutar a conexão, tente mais tarde");
                }

                cmd.CommandText = String.Format(@"SELECT Quantidade
                                               FROM Gado
                                               WHERE Animal = '{0}';", animal);

                qtdatual = (Int32)cmd.ExecuteScalar();

                if (qtdatual < qtdvendida)
                {
                    qtd.Clear();
                    MessageBox.Show("Não há animais suficientes para a venda.Por favor,insira um número até " + qtdatual,"Ops");
                }

                else
                {
                    qtd.Clear();
                    valor.Clear();
                    animais.ResetText();
                    int qtdtot = qtdatual - qtdvendida;

                    cmd.CommandText = String.Format(@"UPDATE Gado 
                                                    SET Quantidade = {0}
                                                    WHERE Animal = '{1}'", qtdtot, animal);

                    SqlDataReader reader = cmd.ExecuteReader();
                    MessageBox.Show("Efetuado com sucesso!\nVocê possui " + qtdtot + "" + animal + "(s) agora.");
                    cmd.Connection.Close();
                }
            }
            /* ele vai ter que acessar o setor de contabilidade pra dizer o qto isso vai acrescentar na área do gado
            * ele vai ter que pegar o valor que tinha pro setor G + o tot da compra = novodinheiro
            * MessageBox.Show("Venda efetuada com sucesso, o saldo atual para uso do setor "Gado" é de {0}reais.",novodinheiro);
            * else
            * nada
            */
        }

        private void cancela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar operação?", "Tem certeza de sua escolha?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                BuyorSell bs = new BuyorSell();
                bs.Show();
                Close();
            }
        }
    }
}
