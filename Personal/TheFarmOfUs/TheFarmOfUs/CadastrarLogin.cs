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
            string senha = senhalog.Text;
            string conf = confirmsen.Text;
            string MERDA = "",MERDA2 = "";

            CadastrarNovoLogin.CadastroLogin(conf, senha, usuario, nome,cpf);

            if(CadastrarNovoLogin.cone == "")
            {
                if(CadastrarNovoLogin.pegacpf == cpf)
                {
                    MERDA = "A";
                }

                if(CadastrarNovoLogin.pegauser == usuario)
                {
                    MERDA2 = "A";
                }
                
                if(MERDA == "A") 
                {
                    cpfs.Clear();
                    MessageBox.Show("CPF " + CadastrarNovoLogin.pegacpf.ToString());
                    MessageBox.Show("EXITE CPF " + CadastrarNovoLogin.existecpf.ToString());
                }

                if(MERDA2 == "A")
                {
                    username.Clear();
                    MessageBox.Show("EXISTE NA MERDA DO BD NESRE CARALHO");
                    MessageBox.Show("EXISTE USE " + CadastrarNovoLogin.existeuser.ToString());
                    MessageBox.Show("USUARIO " + CadastrarNovoLogin.pegauser.ToString());
                }
                
                if(MERDA == "" && MERDA2 == "")
                {
                    username.Clear();
                    cpfs.Clear();
                    MessageBox.Show("ALGUEM ME AJ");
                }
                /*if (CadastrarNovoLogin.existecpf == "") 
                {
                    username.Clear();
                    MessageBox.Show("Não existe essa merda d usuário na desgraça da tabela");
                }

                else
                {
                    username.Clear();
                    MessageBox.Show("EXISTE NA MERDA DO BD NESRE CARALHO");
                    MessageBox.Show("EXISTE USE " + CadastrarNovoLogin.existeuser.ToString());
                    MessageBox.Show("USUARIO " + CadastrarNovoLogin.pegauser.ToString());
                }

                if (CadastrarNovoLogin.existeuser == "")
                {
                    cpfs.Clear();
                    MessageBox.Show("Não existe essa merda d cpf na porra da tabela");
                }
                else
                {
                    cpfs.Clear();
                    MessageBox.Show("CPF " + CadastrarNovoLogin.pegacpf.ToString());
                    MessageBox.Show("EXITE CPF " + CadastrarNovoLogin.existecpf.ToString());

                }*/
                /*  if(CadastrarNovoLogin.tudocerto == "s")
                  {
                      MessageBox.Show("Não existe");
                  }

                  else
                  {
                      MessageBox.Show("EXISTE NA MERDA DO BD NESRE CARALHO");
                      MessageBox.Show(CadastrarNovoLogin.pegauser.ToString());
                 //     MessageBox.Show(CadastrarNovoLogin.pegacpf.ToString());
                  }
                  /*
                  if (CadastrarNovoLogin.oksenha == "n")
                  {
                      senhalog.Clear();
                      confirmsen.Clear();
                      MessageBox.Show("As senhas não conferem, por favor,insira a senha novamente");
                  }

                  if (CadastrarNovoLogin.possuiuser != "n")
                  {
                      username.Clear();
                      MessageBox.Show(CadastrarNovoLogin.possuiuser);
                  }

                  if(CadastrarNovoLogin.tudocerto == "s")
                  {
                      MessageBox.Show("Cadastro realizado com sucesso");
                      senhalog.Clear();
                      confirmsen.Clear();
                      username.Clear();
                      nomelog.Clear();
                  }

                  else
                  {
                      MessageBox.Show("DISGRAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAÇA\nTUDO DA ERRADO NESTA MERDA");
                  }*/
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