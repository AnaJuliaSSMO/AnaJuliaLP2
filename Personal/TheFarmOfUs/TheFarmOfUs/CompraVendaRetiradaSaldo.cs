using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFarmOfUs
{
    class CompraVendaRetiradaSaldo
    {
        public static double tenhodisponivel, valorrestante;
        public static int qtdanimais, novaqtdani;
        public static string cone = "", confirmacaocv;
        public static string jaecadastrado;
        public static int quantidadebd, novaqtd;
        public static int qtdplantabd;
        public static double novaqtdplanta;
        public static string ok;

        public static void PegarValorDisponivel(string escolha) //isso aqui vai servir tanto pra agricultura qto pra pecuária
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

            if (cone == "")
            {
                if (escolha == "gado")
                {
                    cmd.CommandText = String.Format(@"SELECT Valor_disponivel
                                                FROM Disponivel
                                                WHERE Setor = 'Pecuaria'");
                    tenhodisponivel = (double)cmd.ExecuteScalar();

                    MessageBox.Show("Há R$" + tenhodisponivel + " reais disponíveis para o setor de Pecuária");
                }

                else //(escolha == "planta") //-> pq ainda vai ter a parte da agricultura
                {
                    cmd.CommandText = String.Format(@"SELECT Valor_disponivel
                                                FROM Disponivel
                                                WHERE Setor = 'Agricultura'");
                    tenhodisponivel = (double)cmd.ExecuteScalar();

                    MessageBox.Show("Há R$" + tenhodisponivel + " reais disponíveis para o setor de Agricultura");
                }
            }

            else
            {
                MessageBox.Show(cone);
            }

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        } //FEITO //COLOCADO O IF DE CONEXÃO

        public static void CompraVendaGado(string deseja, double valorcompra, string animal, int quantidadeani)
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

            if (cone == "")
            {
                cmd.CommandText = String.Format(@"SELECT Valor_disponivel
                                                  FROM Disponivel
                                                  WHERE Setor = 'Pecuaria'");
                tenhodisponivel = (double)cmd.ExecuteScalar();
                MessageBox.Show(tenhodisponivel.ToString());

                cmd.CommandText = String.Format(@"SELECT Quantidade
                                      FROM Gado
                                      WHERE Animal = '{0}';", animal);
                qtdanimais = (int)cmd.ExecuteScalar();

                if (deseja == "comprar") //r A CONTA MUDA ENT POR ISSO TEM ESSAS COISAS
                {
                    if (tenhodisponivel >= valorcompra)
                    {
                        valorrestante = tenhodisponivel - valorcompra;
                        novaqtdani = qtdanimais + quantidadeani;
                        /* txtvalor = valorrestante.ToString("0.00");
                        valorrestante = double.Parse(txtvalor);*/

                        cmd.CommandText = String.Format(@"UPDATE Disponivel 
                                                          SET Valor_disponivel = @valorfinal
                                                          WHERE Setor = 'Pecuaria'", valorrestante);

                        cmd.Parameters.AddWithValue("@valorfinal", valorrestante);
                        cmd.ExecuteNonQuery();
                        //SqlDataReader reader = cmd.ExecuteReader();
                        //reader.Close();

                        cmd.CommandText = String.Format(@"UPDATE Gado 
                                                          SET Quantidade = {0}
                                                          WHERE Animal = '{1}'", novaqtdani, animal);

                        MessageBox.Show("Compra efetuada com sucesso, o saldo atual para uso do setor Pecuária é de R$ " + valorrestante + ".\nVocê possui " + novaqtdani + " " + animal + "(s) agora!");

                        ok = "s";
                    }

                    else
                    {
                        MessageBox.Show("Saldo insuficiente,por favor, insira um valor até R$ " + tenhodisponivel + " ou consulte o setor de contabilidade.");
                        ok = "n";
                    }
                }

                else //ele só tem que verificar o valor na hr da venda
                {
                    if (qtdanimais >= quantidadeani) //se tiver mais no banco do q ele quiser vender 
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
                        MessageBox.Show("Venda efetuada com sucesso, o saldo atual para uso do setor Pecuária é de R$ " + valorrestante + ".\nVocê possui " + novaqtdani + " " + animal + "(s) agora!");

                        ok = "s";
                    }

                    else
                    {
                        MessageBox.Show("Não há animais suficientes para a venda.Por favor,insira um número até " + qtdanimais);
                        ok = "n";
                    }
                }

            }

            else
            {
                MessageBox.Show(cone);
            }
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        } //FEITO //COLOCADO IF DE CONEXÃO

        public static void CompraeVendaAlimentos(string tipo, string nomedoali, int quantidade, double valorcompra, string animaldestino) 
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

            if (cone == "")
            {
                cmd.CommandText = String.Format(@"SELECT Nome 
                                                  FROM AlRemVa
                                                  WHERE Nome = '{0}';", nomedoali);

                jaecadastrado = (string)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();

                cmd.CommandText = String.Format(@"SELECT Valor_disponivel
                                                  FROM Disponivel
                                                  WHERE Setor = 'Pecuaria'");
                tenhodisponivel = (double)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();

                if (tenhodisponivel >= valorcompra)
                {
                    valorrestante = tenhodisponivel - valorcompra;

                    cmd.CommandText = String.Format(@"UPDATE Disponivel 
                                                     SET Valor_disponivel = @valorfinal
                                                     WHERE Setor = 'Pecuaria'", valorrestante);

                    cmd.Parameters.AddWithValue("@valorfinal", valorrestante);
                    cmd.ExecuteNonQuery();

                    if (jaecadastrado == null) // Se o que ele quiser comprar n tiver na tabela ele vai dar insert
                    {
                        novaqtd = quantidade;
                        cmd.CommandText = String.Format(@"INSERT  
                                                  INTO AlRemVa 
                                                  VALUES ('{0}','{1}',{2},'{3}')", nomedoali, tipo, novaqtd, animaldestino);
                    }

                    else //se não, ele vai dar um update
                    {
                        cmd.CommandText = String.Format(@"SELECT Quantidade 
                                               FROM AlRemVa
                                               WHERE Nome = '{0}';", nomedoali);

                        quantidadebd = (int)cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();

                        novaqtd = quantidadebd + quantidade;
                        cmd.CommandText = String.Format(@"UPDATE AlRemVa 
                                                  SET Quantidade = {0}
                                                  WHERE Nome = '{1}'", novaqtd, nomedoali);
                    }

                    MessageBox.Show("Efetuado com sucesso,você possui " + novaqtd + "kg/embalagens de " + nomedoali);
                    MessageBox.Show("O saldo atual para uso do setor Pecuária é de R$ " + valorrestante + ".");
                    ok = "s";
                }

                else
                {
                    MessageBox.Show("Saldo insuficiente,por favor, insira um valor até R$ " + tenhodisponivel + " ou consulte o setor de contabilidade.");
                    ok = "n";
                }
            }

            else
            {
                MessageBox.Show(cone);
            }

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        } //FEITO //COLOCADO IF DE CONEXÃO

        public static void RetirarAlimentos(string tipo, string nomedoali, int quantidade)
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
                cone = "Não foi possível efeutar a conexão, tente mais tarde";
            }

            if (cone == "")
            {
                cmd.CommandText = String.Format(@"SELECT Quantidade 
                                               FROM AlRemVa
                                               WHERE Nome = '{0}'", nomedoali);

                quantidadebd = (int)cmd.ExecuteScalar();

                if (quantidadebd >= quantidade) //se a quantidade no banco for maior do que a quantidade que a pessoa quer retirar, ent ta ok
                {
                    novaqtd = quantidadebd - quantidade;

                    cmd.CommandText = String.Format(@"UPDATE AlRemVa 
                                              SET Quantidade = @novaqtd
                                              WHERE Nome = '{1}' AND Tipo = '{2}'", novaqtd, nomedoali, tipo);

                    cmd.Parameters.AddWithValue("@novaqtd", novaqtd);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Efetuado com sucesso,agora você possui " + novaqtd + "kg/embalagens de " + nomedoali);
                    ok = "s";
                }

                else
                {
                    MessageBox.Show("Você não possui o suficiente, por favor, insira um número até " + quantidadebd);
                    ok = "n";
                }
            }

            else
            {
                MessageBox.Show(cone);
            }
            
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        } //FEITO //COLOCADO O IF DE CONEXAO
        
        public static void CompraVendaPlanta(string deseja, double valorcompra, string planta, int qtdplanta)
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

            if (cone == "")
            {
                cmd.CommandText = String.Format(@"SELECT Valor_disponivel
                                              FROM Disponivel
                                              WHERE Setor = 'Agricultura'");
                tenhodisponivel = (double)cmd.ExecuteScalar();

                cmd.CommandText = String.Format(@"SELECT Quantidade
                                              FROM Plantas
                                              WHERE Nome = '{0}';", planta);
                qtdplantabd = (int)cmd.ExecuteScalar();

                if (deseja == "comprar") //r A CONTA MUDA ENT POR ISSO TEM ESSAS COISAS
                {
                    if (tenhodisponivel >= valorcompra)
                    {
                        valorrestante = tenhodisponivel - valorcompra;
                        novaqtdplanta = qtdplantabd + qtdplanta;

                        cmd.CommandText = String.Format(@"UPDATE Disponivel 
                                                     SET Valor_disponivel = @valorfinal
                                                     WHERE Setor = 'Agricultura'", valorrestante);

                        cmd.Parameters.AddWithValue("@valorfinal", valorrestante);
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = String.Format(@"UPDATE Plantas 
                                                      SET Quantidade = @novaqtd
                                                      WHERE Nome = '{1}'", novaqtdplanta, planta);

                        cmd.Parameters.AddWithValue("@novaqtd", novaqtdplanta);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Compra efetuada com sucesso, o saldo atual para uso do setor Agricultura é de R$ " + valorrestante + ".\nVocê possui " + novaqtdplanta + " " + planta + "(s) agora!");
                        ok = "s";
                    }

                    else
                    {
                        MessageBox.Show("Saldo insuficiente,por favor, insira um valor até R$ " + tenhodisponivel + " ou consulte o setor de contabilidade.");
                        ok = "n";
                    }
                }

                else //ele só tem que verificar o valor na hr da compra
                {
                    if (qtdplantabd >= qtdplanta) //se tiver mais no banco do q ele quiser vender 
                    {
                        valorrestante = tenhodisponivel + valorcompra;
                        novaqtdplanta = qtdplantabd - qtdplanta;

                        cmd.CommandText = String.Format(@"UPDATE Disponivel 
                                                     SET Valor_disponivel = @valorfinal
                                                     WHERE Setor = 'Agricultura'", valorrestante);

                        cmd.Parameters.AddWithValue("@valorfinal", valorrestante);
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = String.Format(@"UPDATE Plantas 
                                                    SET Quantidade = @novaqtd
                                                    WHERE Nome = '{1}'", novaqtdplanta, planta);
                        cmd.Parameters.AddWithValue("@novaqtd", novaqtdplanta);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Venda efetuada com sucesso, o saldo atual para uso do setor Pecuária é de R$ " + valorrestante + ".\nVocê possui " + novaqtdplanta + " " + planta + "(s) agora!");
                        ok = "s";
                    }

                    else
                    {
                        MessageBox.Show("Não há sacas o suficiente para a venda.Por favor,insira um número até " + qtdplanta);
                        ok = "n";
                    }

                    cmd.ExecuteNonQuery();
                }
            }

            else
            {
                MessageBox.Show(cone);
            }
            cmd.Connection.Close();
        } //FEITO //COLOCADO O IF DE CONEXÃO

        public static void CompraAgro(string agro, int quantidade, double valorcompra, string plantadestino)
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

            if (cone == "")
            {
                cmd.CommandText = String.Format(@"SELECT Nome 
                                                  FROM Agrotoxicos
                                                  WHERE Nome = '{0}';", agro);

                jaecadastrado = (string)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();

                cmd.CommandText = String.Format(@"SELECT Valor_disponivel
                                                  FROM Disponivel
                                                  WHERE Setor = 'Agricultura'");

                tenhodisponivel = (double)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();

                if (tenhodisponivel >= valorcompra)
                {
                    valorrestante = tenhodisponivel - valorcompra;

                    cmd.CommandText = String.Format(@"UPDATE Disponivel 
                                                      SET Valor_disponivel = @valorfinal
                                                      WHERE Setor = 'Agricultura'", valorrestante);
                      
                    cmd.Parameters.AddWithValue("@valorfinal", valorrestante);
                    cmd.ExecuteNonQuery();

                    if (jaecadastrado == null) // Se o que ele quiser comprar n tiver na tabela ele vai dar insert
                    {
                        novaqtd = quantidade;
                        cmd.CommandText = String.Format(@"INSERT  
                                                          INTO Agrotoxicos 
                                                          VALUES ('{0}',{1},'{2}')", agro, novaqtd, plantadestino);
                    }

                    else //se sim, ele vai dar um update
                    {
                        cmd.CommandText = String.Format(@"SELECT Quantidade 
                                                          FROM Agrotoxicos
                                                          WHERE Nome = '{0}';", agro);

                        quantidadebd = (int)cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();

                        novaqtd = quantidadebd + quantidade;
                        cmd.CommandText = String.Format(@"UPDATE Agrotoxicos 
                                                          SET Quantidade = {0}
                                                          WHERE Nome = '{1}'", novaqtd, agro);
                    }

                    MessageBox.Show("Efetuado com sucesso,você possui " + novaqtd + "kg/embalagens de " + agro);
                    MessageBox.Show("O saldo atual para uso do setor Pecuária é de R$ " + valorrestante + ".");
                    ok = "s";
                }

                else
                {
                    MessageBox.Show("Saldo insuficiente,por favor, insira um valor até R$ " + tenhodisponivel + " ou consulte o setor de contabilidade.");
                    ok = "n";
                }
            }

            else
            {
                MessageBox.Show(cone);
            }
            
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        } //FEITO //COLOCADO IF DE CONEXÃO
        
        public static void AttSacas(string nome, int quantidade)
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
                cone = "Não foi possível efeutar a conexão, tente mais tarde";
            }

            if (cone == "")
            {
                cmd.CommandText = String.Format(@"SELECT Quantidade 
                                               FROM Plantas
                                               WHERE Nome = '{0}';", nome);

                qtdplantabd = (int)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();

                novaqtd = qtdplantabd + quantidade;

                MessageBox.Show("A quantidade de sacas de " + nome + " era de " + qtdplantabd + ".\nA nova quantidade é de " + novaqtd + " sacas.");

                cmd.CommandText = String.Format(@"UPDATE Plantas 
                                              SET Quantidade = {0}
                                              WHERE Nome = '{1}'", novaqtd, nome);
            }

            else
            {
                MessageBox.Show(cone);
            }

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }  //FEITO //COLOCADO O IF DE CONEXÃO
        
        public static void CompraVendaAttMaquina(string marca,string modelo, string ano, string placa, int potencia, double capacidade, double valorcompra,string deseja)
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

            if (cone == "")
            {
                cmd.CommandText = String.Format(@"SELECT Valor_disponivel
                                                FROM Disponivel
                                                WHERE Setor = 'Agricultura'");
                tenhodisponivel = (double)cmd.ExecuteScalar();

                if (deseja == "comprar")
                {
                    if (tenhodisponivel >= valorcompra)
                    {
                        valorrestante = tenhodisponivel - valorcompra;

                        cmd.CommandText = String.Format(@"UPDATE Disponivel 
                                                     SET Valor_disponivel = @valorfinal
                                                     WHERE Setor = 'Agricultura'", valorrestante);

                        cmd.Parameters.AddWithValue("@valorfinal", valorrestante);
                        cmd.ExecuteNonQuery();


                        cmd.CommandText = String.Format(@"INSERT 
                                                      INTO MaquinasA
                                                      VALUES('{0}','{1}','{2}',{3},'{4}',{5},'Sim','')", marca, modelo, ano, potencia, placa, capacidade);

                        MessageBox.Show("Compra efetuada com sucesso, o saldo atual para uso do setor Pecuária é de R$ " + valorrestante +
                                        ".\nSua nova aquisição foi um(a) " + marca + " " + modelo);

                        ok = "s";
                    }

                    else
                    {
                        MessageBox.Show("Saldo insuficiente,por favor, insira um valor até R$ " + tenhodisponivel + " ou consulte o setor de contabilidade.");
                        ok = "n";
                    }
                }

            }

            else
            {
                MessageBox.Show(cone);
            }
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            
        } //FEITO //COLOCADO IF DE CONEXÃO

        public static void RetiraMaquinas(string modelo, string placa, string reason)
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
                cone = "Não foi possível efeutar a conexão, tente mais tarde";
            }

            if (cone == "")
            {
                cmd.CommandText = String.Format(@"UPDATE MaquinasA 
                                              SET Disponivel = 'Não',
                                              MotivoRetirada = @reason
                                              WHERE Modelo = '{0}' AND Placa = '{1}'", modelo, placa);

                cmd.Parameters.AddWithValue("@reason", reason);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Efetuado com sucesso");

            }

            else
            {
                MessageBox.Show(cone);
            }

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }  //FEITO //COLOCADO IF DE CONEXÃO

        public static void AtualizaAnimais(int quantidade, string animal,string deseja)
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
                cone = "Não foi possível efeutar a conexão, tente mais tarde";
            }

            if(cone == "")
            {
                cmd.CommandText = String.Format(@"SELECT Quantidade
                                               FROM Gado
                                               WHERE Animal = '{0}';", animal);

                quantidadebd = (int)cmd.ExecuteScalar();

                if (deseja == "colocar")
                {
                    novaqtd = quantidadebd + quantidade;

                    cmd.CommandText = String.Format(@"UPDATE Gado 
                                             SET Quantidade = {0}
                                             WHERE Animal = '{1}'", novaqtd, animal);
                    MessageBox.Show("Realizado com sucesso. A quantidade atual de" + animal + "(s) é de " + novaqtd);
                }

                else
                {
                    if (quantidade > quantidadebd)
                    {
                        MessageBox.Show("Você quer tirar mais do que o permitido, a quantidade atual no estoque é de " + quantidadebd + " " + animal + "(s).");
                    }

                    else
                    {
                        novaqtd = quantidadebd - quantidade;
                        cmd.CommandText = String.Format(@"UPDATE Gado 
                                             SET Quantidade = {0}
                                             WHERE Animal = '{1}'", novaqtd, animal);

                        MessageBox.Show("Realizado com sucesso. A quantidade atual de" + animal + "(s) é de " + novaqtd);
                    }
                }
                cmd.ExecuteNonQuery();
            }

            else
            {
                MessageBox.Show(cone);
            }
            cmd.Connection.Close();
        } //FEITO  //COLOCADO O IF DE CONEXÃO
    }
} 