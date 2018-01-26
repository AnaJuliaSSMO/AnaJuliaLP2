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
    public partial class RetirarRegistro : Form
    {
        public RetirarRegistro()
        {
            InitializeComponent();
        }

        private void RetirarRegistro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOGINUSERDataSet4.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.lOGINUSERDataSet4.Funcionario);

        }

        private void retirar_Click(object sender, EventArgs e)
        {
            string cpf = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string cone = "";

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
                cmd.CommandText = String.Format(@"DELETE
                                                  FROM Funcionario
                                                  WHERE CPF = '{0}'", cpf);
                cmd.ExecuteNonQuery();

                cmd.CommandText = String.Format(@"DELETE
                                                  FROM Login
                                                  WHERE CPF = '{0}'", cpf);

                MessageBox.Show("Registro retirado com sucesso.\nPara atualizar a tabela volte ao setor anterior e retorne.");
            }
               
            else
            {
                MessageBox.Show(cone);
            }

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.Refresh();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja retornar para a área anterior?", "Go back?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SetorFuncionario set = new SetorFuncionario();
                set.Show();
            }
            Close();
        }
    }
}
