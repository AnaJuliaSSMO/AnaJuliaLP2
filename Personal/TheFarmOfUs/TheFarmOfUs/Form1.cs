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
            this.Visible = false;
            //ó,isso aqui vai registrar o login da pessoa, n esquece d criar a 
            //string d conecção, o bd eu tenho aqui, é uma tabela só

            Agrupamento_Setores gp = new Agrupamento_Setores();
            gp.Show();
        }

    }
}
    