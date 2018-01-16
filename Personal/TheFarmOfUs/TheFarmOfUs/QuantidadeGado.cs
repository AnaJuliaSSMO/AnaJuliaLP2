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
    public partial class QuantidadeGado : Form
    {
        public QuantidadeGado()
        {
            InitializeComponent();
        }

        private void QuantidadeGado_Load(object sender, EventArgs e)
        {

        }

        private void animais_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cont,cone = "";
            string anima = animais.Text.ToString();
            int todos = animais.SelectedIndex;

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
                cone = "Não foi possível efeutar a conexão, tente mais tarde";
            }
            
            if(cone == "")
            {
                if (todos == 0)
                {
                    cmd.CommandText = String.Format(@"SELECT SUM (Quantidade)
                                              AS total 
                                              FROM Gado");

                    cont = cmd.ExecuteScalar().ToString();
                    cmd.Parameters.AddWithValue("@total", cont);
                    MessageBox.Show(cont);
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }

                else
                {
                    cmd.CommandText = String.Format(@"SELECT Quantidade
                                              FROM Gado
                                              WHERE Animal = '{0}';", anima);

                    cont = cmd.ExecuteScalar().ToString();
                    cmd.Parameters.AddWithValue("@Quantidade", cont);
                    MessageBox.Show(cont);

                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }

                if (MessageBox.Show("Deseja retornar para a área anterior?", "Go back?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                    Gado gado = new Gado();
                    gado.Show();
                }
            }

            else
            {
                MessageBox.Show(cone);
            }
            
        }
    }
}
