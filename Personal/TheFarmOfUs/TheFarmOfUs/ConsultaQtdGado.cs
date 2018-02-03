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
    public partial class ConsultaQtdGado : Form
    {
        public ConsultaQtdGado()
        {
            InitializeComponent();
        }

        private void QuantidadeGado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOGINUSERDataSet2.Gado' table. You can move, or remove it, as needed.
            this.gadoTableAdapter.Fill(this.lOGINUSERDataSet2.Gado);

        }

        private void retor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja retornar para a área anterior?", "Go back?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SetorPecuaria gado = new SetorPecuaria();
                gado.Show();
                Close();
            }
        }
    }
}
