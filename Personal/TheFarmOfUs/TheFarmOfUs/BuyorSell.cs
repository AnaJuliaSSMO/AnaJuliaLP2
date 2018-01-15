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
    public partial class BuyorSell : Form
    {
        public BuyorSell()
        {
            InitializeComponent();
        }

        SqlCommand cmd = new SqlCommand()
        {
            Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
        };


        private void quercomprar_Click(object sender, EventArgs e)
        {//variáveis vindas da form
            int qtdcomprada = int.Parse(qtd.Text), qtdatual;
            double preco = double.Parse(valor.Text);
            string animal = animais.SelectedItem.ToString();

            //variáveis "auxiliares"
            double precototal = preco * qtdcomprada;

            //por enquanto, já que não tenho setor de contabilidade, vou estabelecer que eu posso gastar até 5000 conto
            double tenho = 5000;

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

            MessageBox.Show("O animal escolhido foi: " + animal);

            if (precototal > tenho)
            {
                MessageBox.Show("Poucos dinheiros.Pode-se gastar até R$" + tenho + " por favor,insira um novo valor");
            }

            else
            {
                if (MessageBox.Show("O total da sua compra é de R$" + precototal + "\nDeseja continuar?", "Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    tenho = tenho - precototal;
                    qtdatual = qtdatual + qtdcomprada;

                    cmd.CommandText = String.Format(@"UPDATE Gado 
                                                    SET Quantidade = {0}
                                                    WHERE Animal = '{1}'", qtdatual, animal);

                    MessageBox.Show("compra efetuada com sucesso, o saldo atual para uso do setor Gado é de R$" + tenho);
                    MessageBox.Show("Efetuado com sucesso!\nVocê possui " + qtdatual + " " + animal + "(s) agora.");
                }
            }

            cmd.Connection.Close();
        }

        private void quervender_Click(object sender, EventArgs e)
        {
            //variáveis vindas da form
            int qtdvendida = int.Parse(qtd.Text), qtdatual;
            double preco = double.Parse(valor.Text),tenho = 5000;
            string animal = animais.SelectedItem.ToString();
            //variáveis "auxiliares"
            double precototal = preco * qtdvendida;

            //COMEÇA O SELECT
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
            //TERMINA O SELECT

            MessageBox.Show("O animal escolhido foi: " + animal);

            if (qtdatual < qtdvendida)
            {
                qtd.Clear();
                MessageBox.Show("Não há animais suficientes para a venda.Por favor,insira um número até " + qtdatual, "Ops");
            }

            else
            {
                tenho = tenho + precototal;
                qtdatual = qtdatual - qtdvendida;
                if (MessageBox.Show("O total da sua venda é de R$" + precototal + "\nDeseja continuar?", "Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    qtd.Clear();
                    valor.Clear();
                    animais.ResetText();

                    cmd.CommandText = String.Format(@"UPDATE Gado 
                                                    SET Quantidade = {0}
                                                    WHERE Animal = '{1}'", qtdatual, animal);

                    SqlDataReader reader = cmd.ExecuteReader();
                    MessageBox.Show("Venda efetuada com sucesso, o saldo atual para uso do setor Gado é de R$" + tenho);
                    MessageBox.Show("Você possui " + qtdatual + " " + animal + "(s) agora.");
                    cmd.Connection.Close();
                }
            }

            cmd.Connection.Close();

            /* ele vai ter que acessar o setor de contabilidade pra dizer o qto isso vai acrescentar na área do gado
            * ele vai ter que pegar o valor que tinha pro setor G + o tot da compra = novodinheiro
            * MessageBox.Show("Venda efetuada com sucesso, o saldo atual para uso do setor "Gado" é de {0}reais.",novodinheiro);
            * else
            * nada
            */
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
