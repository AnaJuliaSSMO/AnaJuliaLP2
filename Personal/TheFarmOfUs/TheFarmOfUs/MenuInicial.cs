using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
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
        
        private void MenuInicial_Load(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(TheFarmOfUs.Audios.reigado);
            simpleSound.Play();
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
            Agrupamento_Setores gp = new Agrupamento_Setores();

            string user = usuario.Text;
            string pass = senha.Text;

            Logar.RealizarLogin(user,pass);

            if(Logar.entrou == "s")
            {
                usuario.Clear();
                senha.Clear();
            }

            else
            {
                usuario.Clear();
                senha.Clear();
                gp.Show();
                Hide();
            }
        }

        private void esquecisenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AcessoSenha senha= new AcessoSenha();
            senha.Show();
        }
    }
}
    