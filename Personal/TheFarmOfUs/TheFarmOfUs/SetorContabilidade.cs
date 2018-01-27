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
    public partial class SetorContabilidade : Form
    {
        public SetorContabilidade()
        {
            InitializeComponent();
        }

        private void Contabilidade_Load(object sender, EventArgs e)
        {
        }

        private void cont_SelectedIndexChanged(object sender, EventArgs e)
        {
            int select = cont.SelectedIndex;

            if (select == 0)
            {
                VerSaldo ver = new VerSaldo();
                ver.Show();
                //FEITO
                //CONFERIDO E MDS Q Q EU TAVA FAZENDO
                //EU NAU SEI
                //literalmente pq eu n lembro oq eu fiz '-'
            }

            else if (select == 1)
            {
                AdministraSalario sal = new AdministraSalario();
                sal.Show();
            }

            else
            {
                Agrupamento_Setores menu = new Agrupamento_Setores();
                menu.ShowDialog();
            }
            Close(); 
        }
    }
}
