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
            string cpf = cpfs.Text;
            string seto = setor.SelectedItem.ToString();
            string senha = senhalog.Text;
            string conf = confirmsen.Text;
           // string msg = "",msg2 = "";

            CadastrarNovoLogin.CadastroLogin(conf, senha, usuario, nome, seto,cpf);
            if (CadastrarNovoLogin.cone == "")
            {
                if (CadastrarNovoLogin.msg != "" && CadastrarNovoLogin.msg2 == "")
                {
                    username.Clear();
                    MessageBox.Show(CadastrarNovoLogin.msg);
                }

                else if (CadastrarNovoLogin.msg == "" && CadastrarNovoLogin.msg2 != "")
                {
                    cpfs.Clear();
                    MessageBox.Show(CadastrarNovoLogin.msg2);
                }

                else if (CadastrarNovoLogin.msg != "" && CadastrarNovoLogin.msg2 != "")
                {
                    MessageBox.Show(CadastrarNovoLogin.msg + "\n" + CadastrarNovoLogin.msg2);
                }
                
                else
                {
                    if (CadastrarNovoLogin.ok == "s") // SE MSG E MSG2 ESTIVEREM VAZIAS ELE VEM AQUI
                    {
                        MessageBox.Show("Cadastro realizado com sucesso");
                        senhalog.Clear();
                        confirmsen.Clear();
                        username.Clear();
                        nomelog.Clear();
                        setor.ResetText();
                        cpfs.Clear();
                    }

                    else
                    {
                        senhalog.Clear();
                        confirmsen.Clear();
                        MessageBox.Show("As senhas não conferem, por favor,insira a senha novamente");
                    }
                }
            }

            else
            {
                MessageBox.Show(CadastrarNovoLogin.cone);
            }
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
