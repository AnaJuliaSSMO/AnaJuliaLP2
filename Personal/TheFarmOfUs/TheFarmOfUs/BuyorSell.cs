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

/*primeiro ele vai ter que fazer um SELECT
 * pedindo pra trazer o valor que tem na tabela "diponivel"*/
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
            int qtdcomprada = int.Parse(qtd.Text);
            double preco = double.Parse(valor.Text);
            string animal = animais.SelectedItem.ToString();

            CompraEVenda.CompraGado(qtdcomprada, preco, animal);


            if (CompraEVenda.CompraGado(cone) == "")//ele dá erro pq n ta retornando
            {

                MessageBox.Show("O animal escolhido foi: " + animal);
            }

            else
            {
                MessageBox.Show(cone);
            }
        }

        private void quervender_Click(object sender, EventArgs e)
        {
            //variáveis vindas da form
            int qtdvendida = int.Parse(qtd.Text), qtdatual,novaqtd;
            double preco = double.Parse(valor.Text),tenho = 5000;
            string animal = animais.SelectedItem.ToString(),cone = "";
            
            //variáveis "auxiliares"
            double precototal = preco * qtdvendida;

            //COMEÇA O SELECT
            try
            {
                cmd.Connection.Open();
            }

            catch (SqlException)
            { 
                cone = "Não foi possível efeutar a conexão, tente mais tarde";
            }

            if(cone == "")
            {
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
                    novaqtd = qtdatual - qtdvendida;
                    if (MessageBox.Show("O total da sua venda é de R$" + precototal + "\nDeseja continuar?", "Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        qtd.Clear();
                        valor.Clear();
                        animais.ResetText();

                        cmd.CommandText = String.Format(@"UPDATE Gado 
                                                    SET Quantidade = {0}
                                                    WHERE Animal = '{1}'", novaqtd, animal);

                        SqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Venda efetuada com sucesso, o saldo atual para uso do setor Gado é de R$" + tenho);
                        MessageBox.Show("Você possui " + novaqtd + " " + animal + "(s) agora.");
                        cmd.Connection.Close();
                    }
                }

                cmd.Connection.Close();
            }

            else
            {
                MessageBox.Show(cone);
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
