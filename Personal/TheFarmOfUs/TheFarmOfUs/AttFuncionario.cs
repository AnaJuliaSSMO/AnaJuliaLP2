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
    public partial class AttFuncionario : Form
    {
        public AttFuncionario()
        {
            InitializeComponent();
        }

        private void att_Click(object sender, EventArgs e)
        {
            txt.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";

            if (nometxt.Text != "" && setores.Text != null && cpf.Text != "   .   .   -" && nasc.Text != "  /  /")
            {
                string nome = nometxt.Text;
                string CPF = cpf.Text;
                string nasceu = nasc.Text;
                string setor = setores.SelectedItem.ToString();

                RelacaoFuncionarios.AtualizaFuncionario(nome, CPF, nasceu, setor);

                cpf.Clear();
                nometxt.Clear();
                nasc.Clear();
                setores.ResetText();
            }
            if (nometxt.Text == "") { txt1.Text = "Preenchimento de campo obrigatório"; }

            if (cpf.Text == "   .   .   -") { txt.Text = "Preenchimento de campo obrigatório"; }

            if (nasc.Text == "  /  /") { txt2.Text = "Preenchimento de campo obrigatório"; }

            if (setores.Text == null || setores.Text == "") { txt3.Text = "Preenchimento de campo obrigatório"; }
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

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string CPF = cpf.Text;
            string pegacpf, cone = "", nome;

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

            if (cone == "")
            {
                cmd.CommandText = String.Format(@"SELECT CPF
                                              FROM Funcionario
                                              WHERE CPF = '{0}'", CPF);
                pegacpf = (string)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();

                if (pegacpf == null)
                {
                    MessageBox.Show("CPF não cadastrado em nosso sistema, por favor verifique as informações.");
                }

                else
                {
                    cmd.CommandText = String.Format(@"SELECT Nome
                                                      FROM Funcionario
                                                      WHERE CPF = '{0}'", CPF);

                    nome = (string)cmd.ExecuteScalar();
                    cmd.ExecuteNonQuery();

                    nometxt.Text = nome;
                }
            }

            else
            {
                MessageBox.Show(cone);
            }
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
