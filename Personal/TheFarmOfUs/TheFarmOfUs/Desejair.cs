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
    public partial class Desejair : Form
    {
        public Desejair()
        {
            InitializeComponent();
        }

        private void irplanta_Click(object sender, EventArgs e)
        {
            ConsultarEstoqueAgricultura co = new ConsultarEstoqueAgricultura();
            co.Show();
            Close();
        }

        private void irmaquina_Click(object sender, EventArgs e)
        {
            ConsultarEstoqueMaquinas co = new ConsultarEstoqueMaquinas();
            co.Show();
            Close();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            SetorAgricultura set = new SetorAgricultura();
            set.Show();
            Close();
        }
    }
}
