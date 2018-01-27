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
    public partial class RetirarMaquinas : Form
    {
        public RetirarMaquinas()
        {
            InitializeComponent();
            outromotivo.Enabled = false;
            placas.Enabled = false;
            buscaplacas.Enabled = false;
        }

        private void motivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (motivo.SelectedIndex == 5) { outromotivo.Enabled = true; }
        }

        private void procura_Click(object sender, EventArgs e)
        {
            nomes.Items.Clear();
            string[] names = new string[10000];
            int i = 0;

            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
            };

            cmd.Connection.Open();

            cmd.CommandText = String.Format(@"SELECT Modelo
                                               FROM MaquinasA
                                               WHERE Disponivel = 'Sim'");

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    names[i] = reader.GetString(0);
                    nomes.Items.Add(names[i]);
                    i++;
                }
            }
            cmd.Connection.Close();
            buscaplacas.Enabled = true;
            placas.Enabled = true;
        }

        private void buscaplacas_Click(object sender, EventArgs e)
        {
            placas.Items.Clear();
            string[] placa = new string[10000];
            int i = 0;
            string modelo = nomes.SelectedItem.ToString();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
            };

            cmd.Connection.Open();

            cmd.CommandText = String.Format(@"SELECT Placa
                                               FROM MaquinasA
                                               WHERE Modelo = '{0}'",modelo);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    placa[i] = reader.GetString(0);
                    placas.Items.Add(placa[i]);
                    i++;
                }
            }
            cmd.Connection.Close();
        }

        private void retirar_Click(object sender, EventArgs e)
        {
            string nome = nomes.SelectedItem.ToString();
            string placa = placas.SelectedItem.ToString();
            string reason = motivo.SelectedItem.ToString();
            string notherreason = outromotivo.Text;

            if (outromotivo.Enabled == true)
            {
                CompraVendaRetiradaSaldo.RetiraMaquinas(nome,placa, notherreason);
            }

            else
            {
                CompraVendaRetiradaSaldo.RetiraMaquinas(nome,placa, reason);
            }

            nomes.ResetText();
            motivo.ResetText();
            outromotivo.Clear();
            placas.ResetText();

            outromotivo.Enabled = false;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar operação?", "Tem certeza de sua escolha?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SetorAgricultura ag = new SetorAgricultura();
                ag.Show();
                Close();
            }
        }
    }
}
