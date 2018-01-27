using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFarmOfUs
{
    class RelacaoFuncionarios
    {
        public static string pegacpf,cone = "";
        public static double tenhodisponivel;

        public static void AtualizaFuncionario(string nome, string CPF, string nasceu, string setor)
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
                cmd.CommandText = String.Format(@"SELECT CPF
                                              FROM Funcionario
                                              WHERE CPF = '{0}'", CPF);
                pegacpf = (string)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();

                if (pegacpf == null)
                {
                    MessageBox.Show("CPF não cadastrado em nosso sistema, por favor verifique as informações.");
                }

                else
                {
                    if (setor == "Pecuaria")
                    {
                        cmd.CommandText = String.Format(@"SELECT Salario
                                                          FROM Funcionario
                                                          WHERE Setor = 'Pecuaria'");
                        tenhodisponivel = (double)cmd.ExecuteScalar();

                        cmd.ExecuteNonQuery();
                    }

                    else if (setor == "Agricultura")
                    {
                        cmd.CommandText = String.Format(@"SELECT Salario
                                                          FROM Funcionario
                                                          WHERE Setor = 'Agricultura'");
                        tenhodisponivel = (double)cmd.ExecuteScalar();

                        cmd.ExecuteNonQuery();
                    }

                    else
                    {
                        cmd.CommandText = String.Format(@"SELECT Salario
                                                          FROM Funcionario
                                                          WHERE Setor = 'Contabilidade'");
                        tenhodisponivel = (double)cmd.ExecuteScalar();

                        cmd.ExecuteNonQuery();
                    }

                    cmd.CommandText = String.Format(@"UPDATE Funcionario
                                                      SET nome = '{0}', Data_nascimento = '{1}',Setor = '{2}', Salario = @sal
                                                      WHERE CPF = '{3}'", nome, nasceu, setor, CPF);
                    cmd.Parameters.AddWithValue("@sal", tenhodisponivel);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro efetuado com sucesso!");
                }
            }

            else
            {
                MessageBox.Show(cone);
            }

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        } //FEITO //COLOCADO O IF DE CONEXÃO

        public static void AdmiteFuncionario(string nome, string CPF, string nasceu, string setor,string dataadm)
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
                cmd.CommandText = String.Format(@"SELECT CPF
                                              FROM Funcionario
                                              WHERE CPF = '{0}'", CPF);
                pegacpf = (string)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();

                if (pegacpf == null)
                {
                    if (setor == "pecuaria")
                    {
                        cmd.CommandText = String.Format(@"SELECT Salario
                                                         FROM Funcionario
                                                         WHERE Setor = 'Pecuaria'");
                        tenhodisponivel = (double)cmd.ExecuteScalar();

                    cmd.ExecuteNonQuery();
                    }

                    else if (setor == "agricultura")
                    {
                        cmd.CommandText = String.Format(@"SELECT Salario
                                                  FROM Funcionario
                                                  WHERE Setor = 'Agricultura'");
                        tenhodisponivel = (double)cmd.ExecuteScalar();

                        cmd.ExecuteNonQuery();
                    }

                    else
                    {
                        cmd.CommandText = String.Format(@"SELECT Salario
                                                  FROM Funcionario
                                                  WHERE Setor = 'Contabilidade'");
                        tenhodisponivel = (double)cmd.ExecuteScalar();

                        cmd.ExecuteNonQuery();
                    }

                    cmd.CommandText = String.Format(@"INSERT
                                                     INTO Funcionario
                                                     VALUES ('{0}','{1}','{2}','{3}',@salario,'{4}')", nome, CPF, nasceu, setor,dataadm);

                    cmd.Parameters.AddWithValue("@salario", tenhodisponivel);

                    MessageBox.Show("Registro efetuado com sucesso!");
                }

                else
                {
                    MessageBox.Show("Funcionário já está cadastrado em nosso banco de dados.\nCaso tenha alguma dúvida, verifique a consulta de funcionários.");
                }
            }

            else
            {
                MessageBox.Show(cone);
            }
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        } //FEITO //COLOCADO O IF DE CONEXÃO

        public static void DemiteFuncionario(string nome, string CPF,string mot,string data)
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
                cmd.CommandText = String.Format(@"SELECT CPF
                                                  FROM Demissao
                                                  WHERE CPF = '{0}'", CPF);
                pegacpf = (string)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();

                if(pegacpf == null)
                {
                    cmd.CommandText = String.Format(@"INSERT
                                                  INTO Demissao 
                                                  VALUES ('{0}',@nome,'{1}','{2}')", CPF, mot,data);

                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = String.Format(@"DELETE 
                                                      FROM Funcionario 
                                                      WHERE CPF = '{0}'", CPF);

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = String.Format(@"DELETE 
                                                      FROM Login 
                                                      WHERE CPF = '{0}'", CPF);

                    MessageBox.Show("Demitido com sucesso.\nFoi bom ter você em nossa empresa :)");
                }

                else
                {
                    MessageBox.Show("CPF já tido como demitido");
                }
            }

            else
            {
                MessageBox.Show(cone);
            }

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        } //FEITO //COLOCADO O IF DE CONEXÃO
         
        public static void ConsultaSalario(string escolha)
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
                if (escolha == "pecuaria")
                {
                    cmd.CommandText = String.Format(@"SELECT Salario
                                                  FROM Funcionario
                                                  WHERE Setor = 'Pecuaria'");
                    tenhodisponivel = (double)cmd.ExecuteScalar();

                    MessageBox.Show("O salário atual é de R$" + tenhodisponivel + " para o setor de Pecuária");
                }

                else if (escolha == "agricultura")
                {
                    cmd.CommandText = String.Format(@"SELECT Salario
                                                  FROM Funcionario
                                                  WHERE Setor = 'Agricultura'");
                    tenhodisponivel = (double)cmd.ExecuteScalar();

                    MessageBox.Show("O salário atual é de R$" + tenhodisponivel + " para o setor de Agricultura");
                }

                else
                {
                    cmd.CommandText = String.Format(@"SELECT Salario
                                                  FROM Funcionario
                                                  WHERE Setor = 'Contabilidade'");
                    tenhodisponivel = (double)cmd.ExecuteScalar();

                    MessageBox.Show("O salário atual é de R$" + tenhodisponivel + " para o setor de Contabilidade");
                }
            }

            else
            {
                MessageBox.Show(cone);
            }
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        } //FEITO //COLOCADO O IF DE CONEXÃO

        public static void AlteraSalarioSetores(string setor, double salario)
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
                cmd.CommandText = String.Format(@"UPDATE Funcionario
                                                  SET Salario = @salario
                                                  WHERE Setor = '{0}'", setor);

                cmd.Parameters.AddWithValue("@salario", salario);

                MessageBox.Show("Aletaração efetuada com sucesso!\nO salário atual para o setor de " + setor + " é de R$" + salario);
            }

            else
            {
                MessageBox.Show(cone);
            }

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        } //FEITO //COLOCADO O IF DE CONEXÃO
    }
}
