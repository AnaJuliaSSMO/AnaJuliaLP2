using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFarmOfUs
{
    public partial class ConsultaRegistroFuncionario : Form
    {
        public ConsultaRegistroFuncionario()
        {
            InitializeComponent();
        }

        private void retor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja retornar para a área anterior?", "Go back?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SetorFuncionario set = new SetorFuncionario();
                set.Show();
            }
            Close();
        }

        private void ConsultaRegistroFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOGINUSERDataSet4.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.lOGINUSERDataSet4.Funcionario);
        }
    }
}
