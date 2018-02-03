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
    public partial class CadastrarLogin : Form
    {
        public CadastrarLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = nomelog.Text;
            string usuario = username.Text;
            string cpf = CPF.Text;
            string senha = senhalog.Text;
            string conf = confirmsen.Text;

            CadastrarNovoLogin.CadastroLogin(nome,usuario,cpf,senha,conf);
            if(CadastrarNovoLogin.existecpf == "s")
            {
                CPF.Clear();
            }

            if(CadastrarNovoLogin.existeuser == "s")
            {
                username.Clear();
            }

            if (CadastrarNovoLogin.existesenha == "s")
            {
                senhalog.Clear();
                confirmsen.Clear();
            }


            if (CadastrarNovoLogin.existeuser == "" && CadastrarNovoLogin.existecpf == "")
            {
                username.Clear();
                nomelog.Clear();
                senhalog.Clear();
                confirmsen.Clear();
                CPF.Clear();
            }
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}