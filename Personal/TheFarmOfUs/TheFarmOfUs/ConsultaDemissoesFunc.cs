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
    public partial class ConsultaDemissoesFunc : Form
    {
        public ConsultaDemissoesFunc()
        {
            InitializeComponent();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja retornar para a área anterior?", "Go back?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SetorFuncionario set = new SetorFuncionario();
                set.Show();
                Close();
            }
        }

        private void ConsultaDemissoesFunc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOGINUSERDataSet5.Demissao' table. You can move, or remove it, as needed.
            this.demissaoTableAdapter.Fill(this.lOGINUSERDataSet5.Demissao);

        }
    }
}
