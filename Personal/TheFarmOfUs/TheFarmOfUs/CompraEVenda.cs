using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFarmOfUs
{
    class CompraEVenda
    {
        public static double tenhodisponivel,valorrestante;
        public static int qtdanimais,novaqtdani;
        public static string cone = "";

        public static string PegarValorDisponivel(string escolha) //isso aqui vai servir tanto pra agricultura qto pra pecuária
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
                cone = "Não foi possível estabelecer conexão no momento. Por favor, tente mais tarde.";
            }

            if (escolha == "gado")
            {
                cmd.CommandText = String.Format(@"SELECT Valor_disponivel
                                                FROM Disponivel
                                                WHERE Setor = 'Pecuaria'");
                tenhodisponivel = (double)cmd.ExecuteScalar();
            }

            else //(escolha == "planta") //-> pq ainda vai ter a parte da agricultura
            {
                cmd.CommandText = String.Format(@"SELECT Valor_disponivel
                                                FROM Disponivel
                                                WHERE Setor = 'Agricultura'");
                tenhodisponivel = (double)cmd.ExecuteScalar();
            }

            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Connection.Close();

            return tenhodisponivel.ToString();
        }

        public static void ComprarGado(string deseja,double valorcompra,string animal,int quantidadeani)
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
                cone = "Não foi possível estabelecer conexão no momento. Por favor, tente mais tarde.";
            }

            cmd.CommandText = String.Format(@"SELECT Valor_disponivel
                                                FROM Disponivel
                                                WHERE Setor = 'Pecuaria'");
            tenhodisponivel = (double)cmd.ExecuteScalar();

            cmd.CommandText = String.Format(@"SELECT Quantidade
                                      FROM Gado
                                      WHERE Animal = '{0}';", animal);
            qtdanimais = (int)cmd.ExecuteScalar();

            if (deseja == "comprar") //r A CONTA MUDA ENT POR ISSO TEM ESSAS COISAS
            {
                valorrestante = tenhodisponivel + valorcompra;

                cmd.CommandText = String.Format(@"UPDATE Disponivel 
                                                 SET Valor_disponivel = {0}
                                                 WHERE Setor = 'Pecuaria'", valorrestante);

                cmd.CommandText = String.Format(@"UPDATE Gado 
                                                 SET Quantidade = {0}
                                                 WHERE Animal = '{1}'", novaqtdani, animal);

                //return String.Format("Venda efetuada com sucesso, o saldo atual para uso do setor Gado é de R$ {0}.\nVocê possui {1} animais agora!" + valorrestante);
            }

            else //ele só tem que verificar o valor na hr da venda
            {
                if (qtdanimais > quantidadeani) //se tiver mais no banco do q ele quiser vender 
                {
                    if (tenhodisponivel > valorcompra)
                    {
                    }
                }

                else
                {
                    //vai ter que dar um return maroto dizendo que String.Format("Não há animais suficientes para a venda.Por favor,insira um número até {0}",qtdanimais);
                }
            }

        }
    }
}


/*,
 * 
 * fiz merda hehe
 * 
public static string cone = "",tenhotxtrecebe,tenhotxtenvia,caiu;
public static double tenho, precototal;
public static int qtdatual, novaqtd;

public static CompraGado(int qtdcomprada, double preco, string animal)
{
    precototal = preco * qtdcomprada;

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
        cone = "Não foi possível efeutar a conexão, tente mais tarde";
    }

    //AQUI ELE PEGA O VALOR QUE EU POSSO GASTAR 
    cmd.CommandText = String.Format(@"SELECT Valor_disponivel
                                       FROM Disponivel
                                       WHERE Setor = 'Pecuaria'");
    tenhotxtrecebe = cmd.ExecuteScalar().ToString();

    tenho = double.Parse(tenhotxtrecebe);
    //ACABA 

    //AQUI ELE SELECIONA A QUANTIDADE QUE TEM DE ANIMAIS, ISSO É PARA SOMAR DPS COM A QUANTIDADE QUE ELE QUER COMPRAR
    cmd.CommandText = String.Format(@"SELECT Quantidade
                                       FROM Gado
                                       WHERE Animal = '{0}';", animal);
    qtdatual = (Int32)cmd.ExecuteScalar();
    //ACABA


    if (precototal > tenho)
    {
        caiu = "Poucos dinheiros.Pode-se gastar até R$" + tenho + " por favor,insira um novo valor";
        // MessageBox.Show("Poucos dinheiros.Pode-se gastar até R$" + tenho + " por favor,insira um novo valor");
    }

    else
    {
        if (//tem que dar um jeito de enviar isso pra lá O total da sua compra é de R$" + precototal + "\nDeseja continuar?", "Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
        {
            /*  qtd.Clear();
              valor.Clear();
              animais.ResetText();*

            tenho = tenho - precototal;
            novaqtd = qtdatual + qtdcomprada;
            tenhotxtenvia = tenho.ToString();

            cmd.CommandText = String.Format(@"UPDATE Gado 
                                            SET Quantidade = {0}
                                            WHERE Animal = '{1}'", novaqtd, animal);

            MessageBox.Show("compra efetuada com sucesso, o saldo atual para uso do setor Gado é de R$" + tenho);
            MessageBox.Show("Efetuado com sucesso!\nVocê possui " + novaqtd + " " + animal + "(s) agora.");
        }
        SqlDataReader reader = cmd.ExecuteReader();
        cmd.Connection.Close();
    }

    return String.Format(cone);
    }*/

