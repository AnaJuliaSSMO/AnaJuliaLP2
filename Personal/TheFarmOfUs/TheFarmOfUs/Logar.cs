﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFarmOfUs
{
    class Logar //É A PRIMEIRA TELA, VC SÓ RECEBE LOGIN E SENHA ;)
    {
        public static string nomeconf,userconf,senhaconf, entrou, cone="";

        public static void RealizarLogin(string user, string pass)
        {
            entrou = "n";

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
                cmd.CommandText = String.Format(@"SELECT nome,usuario,senha
                                              FROM Login
                                              WHERE Usuario = '{0}' AND Senha = '{1}';", user, pass);

                try
                {
                    userconf = cmd.ExecuteScalar().ToString();
                    senhaconf = cmd.ExecuteScalar().ToString();
                }

                catch
                {
                    entrou = "s";
                }

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        nomeconf = reader.GetString(0);
                        userconf = reader.GetString(1);
                        senhaconf = reader.GetString(2);
                    }
                }
            }

            else
            {
                MessageBox.Show(cone);
            }
            
            cmd.Connection.Close();
        } //FEITO //COLOCADO O IF DE CONEXÃO
      }
}
    
