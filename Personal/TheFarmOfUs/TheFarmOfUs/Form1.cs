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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }

        private void formal_TextChanged(object sender, EventArgs e)
        {
        }

        private void preencherformulario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string name = formal.Text;

            string texto = String.Format("Obrigado,{0},registro efetuado com sucesso", name);
            this.preencherformulario.Text = texto;

            this.preencherformulario.LinkVisited = true;

            // Isso aqui vai enviar a pessoa pra um formulário que eu criei
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLScNInf1Tk19ddLEG6JACt0g4mtKvyvEKlruD84zn5P0JdrBew/viewform?usp=sf_link");

            this.preencherformulario.Text = texto;       
        }

        private void cadastrarlogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastrarLogin cad = new CadastrarLogin();
            cad.Show();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            string user = usuario.Text;
            string confu;
            int pass = int.Parse(senha.Text);
            int conpass;

            string stringcon = @"Data Source=localhost; Initial Catalog=LOGINUSER; Integrated Security=SSPI;";
            SqlConnection conect = new SqlConnection(stringcon);
            try
            {
                conect.Open();
            }

            catch(SqlException)
            {
                MessageBox.Show("Não foi possível efeutar a conecção, tente mais tarde");
            }


            SqlCommand cmd = new SqlCommand(String.Format(@"SELECT *
                                              FROM Login
                                              WHERE Usuario = {0} AND Senha = {1});", user, pass));

            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                MessageBox.Show("Tudo ok,seja bem vindo!");
                Agrupamento_Setores gp = new Agrupamento_Setores();
                gp.Show();
            }

            MessageBox.Show("Usuário ou senha errados, por favor, verifique as informações");

            /*
                    
            SqlConnection cone = new SqlConnection("Data Source=localhost; Initial Catalog=LOGINUSER; Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = String.Format(@"SELECT *
                                              FROM Login
                                              WHERE Usuario = {0} AND Senha = {1});", user,pass);

            SqlParameter parametroUsuario = new SqlParameter("@Usuario", SqlDbType.VarChar, 20);
            parametroUsuario.Value = usuario;
            confu = usuario.Text;
            cmd.Parameters.Add(parametroUsuario);

            SqlParameter parametroSenha = new SqlParameter("@Senha", SqlDbType.VarChar, 6);
            parametroSenha.Value = senha;
            conpass = int.Parse(senha.Text);
            cmd.Parameters.Add(parametroSenha);

            cmd.Connection.Open();
            if (user == confu)
            {
                MessageBox.Show("Bem vindo!");
            }

            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
            cmd.Connection.Close();

            TENTEI FZR UMA PARADA, DEU ERRADO, TENTEI DNV, CONTINUOU DANDO ERRADO, ITS LIFE 
            */

        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void senha_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
    