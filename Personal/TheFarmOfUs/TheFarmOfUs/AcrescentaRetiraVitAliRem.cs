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
    public partial class AcrescentaRetiraVitAliRem : Form
    {
        public AcrescentaRetiraVitAliRem()
        {
            InitializeComponent();
        }

        SqlCommand cmd = new SqlCommand()
        {
            Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
        };

        private void acrescentar_Click(object sender, EventArgs e)
        {
            int qtdd = int.Parse(qtd.Text), i = 0, conte = nomes.Items.Count;
            string nome = nomes.SelectedItem.ToString();
            string select = tipo.SelectedItem.ToString();
            string []names = new string[5000]; 

            cmd.Connection.Open();

            cmd.CommandText = String.Format(@"SELECT Nome
                                               FROM AlRemVa
                                               WHERE Tipo = '{0}';", select);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    names[i] = reader.GetString(0);
                    i++;
                }
            }

            System.Object[] ItemObject = new System.Object[10];
            for (int j = 0; j <= conte ; j++)
            {
                ItemObject[i] = names[i] + j;
                i++;
            }
            nomes.Items.AddRange(ItemObject);



          /*  cmd.CommandText = String.Format(@"UPDATE Gado 
                                             SET Quantidade = {0}
                                             WHERE Animal = '{1}'", tot, animal);*/
            cmd.Connection.Close();
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
