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
            string conf = confirmsen.Text;
            string senha1 = senhalog.Text;
            string usuario = username.Text;
            string nome = nomelog.Text;
            string seto = String.Format(setor.Text);

            CadastrarNovoLogin.CadastroLogin(conf, senha1, usuario, nome, seto);

            if(CadastrarNovoLogin.ok == "s")
            {
                MessageBox.Show("Cadastro realizado com sucesso");
                senhalog.Clear();
                confirmsen.Clear();
                username.Clear();
                nomelog.Clear();
                setor.ResetText();
            }

            else
            {
                senhalog.Clear();
                confirmsen.Clear();
                MessageBox.Show("As senhas não conferem, por favor,insira a senha novamente");
            }
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
