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
    public partial class AttFuncionario : Form
    {
        public AttFuncionario()
        {
            InitializeComponent();
        }

        private void AttFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOGINUSERDataSet4.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.lOGINUSERDataSet4.Funcionario);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.funcionarioTableAdapter.FillBy(this.lOGINUSERDataSet4.Funcionario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
