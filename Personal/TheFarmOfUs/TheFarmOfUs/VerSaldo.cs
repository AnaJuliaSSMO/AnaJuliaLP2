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
    public partial class VerSaldo : Form
    {
        public VerSaldo()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            /*EU PODERIA CRIAR UM BD
             * PRA SALVAR SÓ ISSO
             * AÍ TERIA A TABELA LÁ
             * COM "VALOR" E AGRICULTURA E PECUÁRIA
             * SEMPRE Q EU MEXESSE NA AGRICULTURA EU DAVA UPDATE EM AGRICULTRA
             * TOP
             */
            Contabilidade cont = new Contabilidade();
            cont.Show();
            Close();
        }
    }
}
