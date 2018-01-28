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
    public partial class MenuInicial : Form
    {
        public MenuInicial()
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
            seg1 ident = new seg1();
            ident.Show();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void entrar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Seja bem vindo à The Farm of Us.\n\nThe Farm of Us foi criado para poder lhe ajudar na administração de sua fazenda\n\nAqui, você poderá controlar seus gastos, vendas,compras e tudo o que voce pode imaginar.\n\nAproveite e obrigado por aderir aos nossos serviços.");
            Agrupamento_Setores gp = new Agrupamento_Setores();

            string user = usuario.Text;
            string pass = senha.Text;

            Logar.RealizarLogin(user,pass);

            if (Logar.entrou == "n")
            {
                usuario.Clear();
                senha.Clear();
                MessageBox.Show("Tudo ok, bem vindo Sr / Sra " + Logar.nomeconf, "Acesso com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gp.Show();
                Hide();
            }

            else
            {
                MessageBox.Show("Usuário ou senha inválidos", "Opa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void esquecisenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefazSenha senha = new RefazSenha();
            senha.Show();
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {
        }
    }
}
    