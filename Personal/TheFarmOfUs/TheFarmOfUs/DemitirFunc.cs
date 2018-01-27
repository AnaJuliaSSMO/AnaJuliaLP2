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
    public partial class DemitirFunc : Form
    {
        public DemitirFunc()
        {
            InitializeComponent();
            outromotivo.Enabled = false;
        }

        private void motivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (motivo.SelectedIndex == 8) { outromotivo.Enabled = true; }
        }

        private void CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cpf = CPF.Text;
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
                                              WHERE CPF = '{0}'", cpf);
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
                                                      WHERE CPF = '{0}'", cpf);

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

        private void att_Click(object sender, EventArgs e)
        {
            string cpf = CPF.Text;
            string nome = nometxt.Text;
            string mot = motivo.SelectedItem.ToString();
            string outro = outromotivo.Text;
            string data = today.Text;
            string motfinal;
            
            if (outromotivo.Enabled == true)
            {
                motfinal = outro;
                RelacaoFuncionarios.DemiteFuncionario(nome, cpf, motfinal,data);
            }

            else
            {
                motfinal = mot;
                RelacaoFuncionarios.DemiteFuncionario(nome, cpf, motfinal,data);
            }

            motivo.ResetText();
            outromotivo.Clear();
            CPF.Clear();
            nometxt.Clear();
            outromotivo.Enabled = false;
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
