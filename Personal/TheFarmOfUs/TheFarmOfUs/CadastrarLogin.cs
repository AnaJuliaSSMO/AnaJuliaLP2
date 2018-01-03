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
            int conf = int.Parse(confirmsen.Text);
            int senha1 = int.Parse(senhalog.Text);

            if (senha1 == conf)
            {
                MessageBox.Show("Cadastro realizado com sucesso");           
            }

            else
            {
                senhalog.Clear();
                confirmsen.Clear();
                MessageBox.Show("As senhas não conferem, por favor,insira a senha novamente");
            }       
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void senhalog_TextChanged(object sender, EventArgs e)
        {
        }

        private void confirmsen_TextChanged(object sender, EventArgs e)
        {
        }

        private void CadastrarLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
