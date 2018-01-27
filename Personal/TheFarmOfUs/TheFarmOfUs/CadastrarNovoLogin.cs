using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFarmOfUs
{
    class CadastrarNovoLogin
    {
        public static string cone = ""; 

        //VARIÁVEIS APENAS PARA CONFERIR SE JÁ EXISTEM NO BD
        public static string pegauser,existeuser,existesenha; //USER
        public static string pegacpf, existecpf,confirmaempresa; //CPF
        
        public static void CadastroLogin(string nome, string usuario, string cpf, string senha, string conf)
        {
            existeuser = "";
            existecpf = "";
            existesenha = "";

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
                //1º VERIFICAR SE O NICK JÁ FOI OU NÃO ESCOLHIDO
                cmd.CommandText = String.Format(@"SELECT Usuario
                                                  FROM Login
                                                  WHERE Usuario = '{0}'", usuario);

                pegauser = (string)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();

                //2 ºVERIFICAR SE O CPF JÁ FOI CADASTRADO 
                cmd.CommandText = String.Format(@"SELECT CPF
                                FROM Login
                                WHERE CPF = '{0}'", cpf);

                pegacpf = (string)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();

                //3º ELE SÓ VAI CADASTRAR FUNCIONÁRIOS DA EMPRESA NEAH :P
                cmd.CommandText = String.Format(@"SELECT CPF
                                              FROM Funcionario
                                              WHERE CPF = '{0}'", cpf);

                confirmaempresa = (string)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();

                if (confirmaempresa == null) //se ele não tiver cadastrado lá
                {
                    MessageBox.Show("O dono CPF informado não está cadastrado em nosso banco de funcionários.\nPor favor, verifique as informações ou contate o setor de funcionários.");
                    existecpf = "s";
                }

                else
                {
                    if (pegauser == null && pegacpf == null)
                    {
                        if (conf == senha)
                        {
                            cmd.CommandText = String.Format(@"INSERT 
                                                  INTO Login
                                                  VALUES('{0}','{1}','{2}','{3}')", nome, usuario, senha, cpf);

                            MessageBox.Show("Efetuado com sucesso");
                        }

                        else
                        {
                            MessageBox.Show("Senhas não coincidem,por favor verifique as senhas.");
                            existesenha = "s";
                        }

                    }

                    if (String.IsNullOrEmpty(pegacpf) == false) //se nao está vazia é pq tem coisa :V
                    {
                        MessageBox.Show("Número de CPF já cadastrado em nosso sistema");
                        existecpf = "s";
                    }

                    if (String.IsNullOrEmpty(pegauser) == false) //se nao está vazia é pq tem coisa :V
                    {
                        MessageBox.Show("Nick de usuário já está em uso, por favor insira outro");
                        existeuser = "s";
                    }
                }

            }

            else
            {
                MessageBox.Show(cone);
            }
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Connection.Close();
        } //FEITO //COLOCADO IF DE CONEXÃO
    }
}

/*
 * CONFERENCIA DE SENHA ESTÁ OK
 * NÃO TA MAIS
 * NA VDD TA
 * QUEM N TA OK SOU EU
 * HELP*/