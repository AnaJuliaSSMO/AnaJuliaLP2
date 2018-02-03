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
    public partial class ConsultaLogin : Form
    {
        public ConsultaLogin()
        {
            InitializeComponent();
        }

        private void ConsultaLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOGINUSERDataSet6.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.lOGINUSERDataSet6.Login);

        }

        private void retor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja retornar para a área anterior?", "Go back?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SetorFuncionario set = new SetorFuncionario();
                set.Show();
                Close();
            }
        }
    }
}
