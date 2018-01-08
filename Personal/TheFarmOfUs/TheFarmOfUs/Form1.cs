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
            string pass = senha.Text;
            string nomeconf = "",userconf = "",setor = "",senhaconf = "";

            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
            };

            try
            {
                cmd.Connection.Open();
            }

            catch(SqlException)
            {
                MessageBox.Show("Não foi possível efeutar a conexão, tente mais tarde");
            }


            cmd.CommandText = String.Format(@"SELECT usuario, senha, nome,setor
                                              FROM Login
                                              WHERE Usuario = '{0}' AND Senha = '{1}';", user, pass);

            try
            {
                nomeconf = cmd.ExecuteScalar().ToString();
                userconf = cmd.ExecuteScalar().ToString();
                senhaconf = cmd.ExecuteScalar().ToString();
                setor = cmd.ExecuteScalar().ToString();
            }
            
            catch
            {
                MessageBox.Show("User inválido");
                usuario.Clear();
                senha.Clear();
            }

            cmd.Parameters.AddWithValue("@Nome",nomeconf);
            cmd.Parameters.AddWithValue("@Usuario",userconf);
            cmd.Parameters.AddWithValue("@Setor", setor);
            cmd.Parameters.AddWithValue("@Senha", senhaconf);

            SqlDataReader reader = cmd.ExecuteReader();
            
                MessageBox.Show("Tudo ok,bem vindo Sr/Sra " + nomeconf);
                Agrupamento_Setores gp = new Agrupamento_Setores();
                gp.Show();
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void senha_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
    