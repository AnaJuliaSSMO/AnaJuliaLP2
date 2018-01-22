using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFarmOfUs
{
    class CompraEVenda
    {
        public static double tenhodisponivel,valorrestante;
        public static int qtdanimais,novaqtdani;
        public static string cone = "",confirmacaocv;

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
            cmd.ExecuteNonQuery();
            // SqlDataReader reader = cmd.ExecuteReader();
            cmd.Connection.Close();

            return tenhodisponivel.ToString();
        }

        /*TAVA MUITO CONFUSO PRA EU ENXERGAR
         * POR ISSO CASULAMENTE TERÃO ESSAS LINHAS DE COMENT
         * RIKKA TAKANASHI MELHOR WAIFU
         * NÃU TOMEM VACINA CONTRA FEBRE AMARELA 
         * VCS VÃO TER ALERGIA CRIANÇAS
         * O GOVERNO MENTE
         * EH ISTO
         */

        public static string CompraVendaGado(string deseja,double valorcompra,string animal,int quantidadeani)
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
                if (tenhodisponivel > valorcompra)
                {
                    valorrestante = tenhodisponivel - valorcompra;
                    novaqtdani = qtdanimais + quantidadeani;
                    /* txtvalor = valorrestante.ToString("0.00");
                    valorrestante = double.Parse(txtvalor);*/

                    cmd.CommandText = String.Format(@"UPDATE Disponivel 
                                                     SET Valor_disponivel = @valorfinal
                                                     WHERE Setor = 'Pecuaria'",valorrestante);

                    cmd.Parameters.AddWithValue("@valorfinal", valorrestante);
                    cmd.ExecuteNonQuery();
                    //SqlDataReader reader = cmd.ExecuteReader();
                    //reader.Close();

                    cmd.CommandText = String.Format(@"UPDATE Gado 
                                                      SET Quantidade = {0}
                                                      WHERE Animal = '{1}'", novaqtdani, animal);

                    confirmacaocv = "Compra efetuada com sucesso, o saldo atual para uso do setor Gado é de R$ " + valorrestante + ".\nVocê possui " + novaqtdani + " " + animal + "(s) agora!";
                }
               
                else
                {
                    confirmacaocv = "Saldo insuficiente,por favor, insira um valor até R$ " + tenhodisponivel + " ou consulte o setor de contabilidade.";
                }
            }

            else //ele só tem que verificar o valor na hr da venda
            {
                if (qtdanimais > quantidadeani) //se tiver mais no banco do q ele quiser vender 
                {
                    valorrestante = tenhodisponivel + valorcompra;
                    novaqtdani = qtdanimais - quantidadeani;


                    cmd.CommandText = String.Format(@"UPDATE Disponivel 
                                                     SET Valor_disponivel = @valorfinal
                                                     WHERE Setor = 'Pecuaria'", valorrestante);

                    cmd.Parameters.AddWithValue("@valorfinal", valorrestante);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = String.Format(@"UPDATE Gado 
                                                 SET Quantidade = {0}
                                                 WHERE Animal = '{1}'", novaqtdani, animal);
                    confirmacaocv = "Venda efetuada com sucesso, o saldo atual para uso do setor Gado é de R$ " + valorrestante + ".\nVocê possui " + novaqtdani + " " + animal + "(s) agora!";
                }

                else
                {
                    confirmacaocv = "Não há animais suficientes para a venda.Por favor,insira um número até " + qtdanimais;
                }
            }

            // SqlDataReader readertwo = cmd.ExecuteReader();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return confirmacaocv;
        }

        /*Eu não sei como as pessoas conseguem enxergar 
         * tão de boas
         * talvez eu precise de um novo óculos
         * ou um novo olho
         * poderia ter uma funçãoiznha
         * que me permitisse "esconder uma parte do código"
         * se´ra que tem?
         * seria bem util
         * EXISTE ESSA FUNÇÃOZINHA
         * :p
         */


        public static string jaecadastrado;
        public static int quantidadebd,novaqtd;

        public static void CompraeVendaAlimentos(string tipo, string nomedoali, int quantidade, double valorcompra,string animaldestino) //alimento,nomedoalimento,quantidade,valordacompra,animalcorrespondente
        {
            jaecadastrado = "";
            quantidadebd = 0;
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

            cmd.CommandText = String.Format(@"SELECT Nome 
                                               FROM AlRemVa
                                               WHERE Nome = '{0}';", nomedoali);

          //   cmd.Parameters.AddWithValue("@nometeste", jaecadastrado);
           jaecadastrado = (string)cmd.ExecuteScalar();
            cmd.ExecuteNonQuery();

            cmd.CommandText = String.Format(@"SELECT Valor_disponivel
                                                FROM Disponivel
                                                WHERE Setor = 'Pecuaria'");
            tenhodisponivel = (double)cmd.ExecuteScalar();
            cmd.ExecuteNonQuery();

            novaqtd = quantidadebd + quantidade;
            if (tenhodisponivel > valorcompra)
            {
                valorrestante = tenhodisponivel - valorcompra;

                cmd.CommandText = String.Format(@"UPDATE Disponivel 
                                                     SET Valor_disponivel = @valorfinal
                                                     WHERE Setor = 'Pecuaria'", valorrestante);

                cmd.Parameters.AddWithValue("@valorfinal", valorrestante);
                cmd.ExecuteNonQuery();

                if (jaecadastrado == "") // Se o que ele quiser comprar n tiver na tabela ele vai dar insert
                {
                    novaqtd = quantidade;
                    cmd.CommandText = String.Format(@"INSERT  
                                                  INTO AlRemVa 
                                                  VALUES ('{0}','{1}',{2},'{3}')", nomedoali, tipo, novaqtd, animaldestino);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                }

                else //se não, ele vai dar um update
                {
                    cmd.CommandText = String.Format(@"SELECT Quantidade AS qtd
                                               FROM AlRemVa
                                               WHERE Nome = '{0}';", nomedoali);

                    cmd.Parameters.AddWithValue("@qtd", quantidadebd);
                  //  MessageBox.Show("QUANTIDADE BD " + quantidadebd);
                   // cmd.ExecuteNonQuery();
                    //quantidadebd = (int)cmd.ExecuteScalar();
                    // cmd.ExecuteNonQuery();
                    //    SqlDataReader readerr = cmd.ExecuteReader();
                    //     readerr.Close();

                    novaqtd = quantidadebd + quantidade;
                    cmd.CommandText = String.Format(@"UPDATE AlRemVa 
                                                  SET Quantidade = {0}
                                                  WHERE Nome = '{1}'", novaqtd, nomedoali);
                }

                MessageBox.Show("Efetuado com sucesso,você possui " + novaqtd + "kg/embalagens de " + nomedoali);
                MessageBox.Show("O saldo atual para uso do setor Gado é de R$ " + valorrestante + ".");
            }

            else
            {
                MessageBox.Show("Saldo insuficiente,por favor, insira um valor até R$ " + tenhodisponivel + " ou consulte o setor de contabilidade.");
            }
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
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
            MessageBox.Show("Efetuado com sucesso!\nVocê jaecadastrado " + novaqtd + " " + animal + "(s) agora.");
        }
        SqlDataReader reader = cmd.ExecuteReader();
        cmd.Connection.Close();
    }

    return String.Format(cone);
    }*/

