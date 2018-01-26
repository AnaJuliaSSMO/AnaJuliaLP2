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
    public partial class ConsultarEstoqueMaquinas : Form
    {
        public ConsultarEstoqueMaquinas()
        {
            InitializeComponent();
        }

        private void ConsultaEstoqueMaquinaPlanta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOGINUSERDataSet.MaquinasA' table. You can move, or remove it, as needed.
            this.maquinasATableAdapter.Fill(this.lOGINUSERDataSet.MaquinasA);
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Desejair co = new Desejair();
            co.Show();
            Close();
        }
    }
}
