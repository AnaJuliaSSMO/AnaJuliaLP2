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
    public partial class VerSaldo : Form
    {
        public VerSaldo()
        {
            InitializeComponent();
        }

        SqlCommand cmd = new SqlCommand()
        {
            Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
        };

        private void consultar_Click(object sender, EventArgs e)
        {
            if (escolhegado.Checked == true)
            {
                MessageBox.Show("Há R$" + ControleDinheiro.VerPecuaria() + " reais disponíveis para o setor de Pecuária");
            }

            if(escolheplanta.Checked == true)
            {
                MessageBox.Show("Há R$" + ControleDinheiro.VerAgricultura() + " reais disponíveis para o setor de Agricultura");
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar operação?", "Tem certeza de sua escolha?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Contabilidade cont = new Contabilidade();
                cont.Show();
                Close();
            }
        }
    }
}
