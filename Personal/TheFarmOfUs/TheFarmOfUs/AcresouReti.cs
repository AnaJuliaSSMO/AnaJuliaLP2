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
    public partial class AcresouReti : Form
    {
        public AcresouReti()
        {
            InitializeComponent();
        }

        SqlCommand cmd = new SqlCommand()
        {
            Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
        };

        private void acrescentar_Click(object sender, EventArgs e)
        {
            int qtdd = int.Parse(qtd.Text),tot;
            string animal = animais.SelectedItem.ToString();
            cmd.Connection.Open();

            cmd.CommandText = String.Format(@"SELECT Quantidade
                                               FROM Gado
                                               WHERE Animal = '{0}';", animal);

            int qtdatual = (Int32)cmd.ExecuteScalar();

            tot = qtdatual + qtdd;
            cmd.CommandText = String.Format(@"UPDATE Gado 
                                             SET Quantidade = {0}
                                             WHERE Animal = '{1}'", tot, animal);

            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Connection.Close();
        }

        private void retirar_Click(object sender, EventArgs e)
        {
            int retirar = int.Parse(qtd.Text), tot;
            string animal = animais.SelectedItem.ToString();
            cmd.Connection.Open();

            cmd.CommandText = String.Format(@"SELECT Quantidade
                                               FROM Gado
                                               WHERE Animal = '{0}';", animal);

            int qtdatual = (Int32)cmd.ExecuteScalar();
            tot = qtdatual - retirar;

            if(retirar > qtdatual)
            {
                MessageBox.Show("Você quer tirar mais do que o permitido, a quantidade atual no estoque é de " + qtdatual + "" + animal + "(s).");
            }
            
            else
            {
                cmd.CommandText = String.Format(@"UPDATE Gado 
                                             SET Quantidade = {0}
                                             WHERE Animal = '{1}'", tot, animal);

                SqlDataReader reader = cmd.ExecuteReader();

                MessageBox.Show("Realizado com sucesso. A quantidade atual de" + animal + "(s) é de " + tot);
                cmd.Connection.Close();
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar operação?", "Tem certeza de sua escolha?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Gado gd = new Gado();
                gd.Show();
                Close();
            }
        }
    }
}
