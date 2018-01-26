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
    public partial class AddFuncionario : Form
    {
        public AddFuncionario()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string cone = "";
            string nome = nometxt.Text;
            string CPF = cpf.Text;
            string nasceu = nasc.Text;
            string setor = setores.SelectedItem.ToString();
            double sal = double.Parse(salario.Text);
            //
            string pegacpf;
            
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
            };

            try
            {
                cmd.Connection.Open();
            }

            catch (SqlException)
            {
                cone = "Não foi possível estabelecer conexão no momento. Por favor, tente mais tarde.";
            }

            if(cone == "")
            {
                cmd.CommandText = String.Format(@"SELECT CPF
                                              FROM Funcionario
                                              WHERE CPF = '{0}'", CPF);
                pegacpf = (string)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();

                if (pegacpf == null)
                {
                    cmd.CommandText = String.Format(@"INSERT
                                                  INTO Funcionario
                                                  VALUES ('{0}','{1}','{2}','{3}',@salario)", nome, CPF, nasceu, setor);

                    cmd.Parameters.AddWithValue("@salario", sal);

                    MessageBox.Show("Registro efetuado com sucesso!");

                    cpf.Clear();
                    nometxt.Clear();
                    nasc.Clear();
                    setores.ResetText();
                    salario.Text = "00,00";
                }

                else
                {
                    MessageBox.Show("Funcionário já está cadastrado em nosso banco de dados.\nCaso tenha alguma dúvida, verifique a consulta de funcionários.");
                }
            }

            else
            {
                MessageBox.Show(cone);
            }
            cmd.ExecuteNonQuery();
            cmd.Connection.Close(); 
        }

        private void cance_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar operação?", "Tem certeza de sua escolha?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SetorFuncionario sf = new SetorFuncionario();
                sf.Show();
                Close();
            }
        }
    }
}
