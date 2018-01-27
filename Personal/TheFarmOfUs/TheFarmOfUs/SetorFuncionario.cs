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
    public partial class SetorFuncionario : Form
    {
        public SetorFuncionario()
        {
            InitializeComponent();
        }

        private void funcoesfuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            int resp = funcoesfuncionario.SelectedIndex;

            if (resp == 0)
            {
                AddFuncionario add = new AddFuncionario();
                add.Show();
            }

            else if (resp == 1)
            {
                DemitirFunc ret = new DemitirFunc();
                ret.Show();
            }

            else if (resp == 2)
            {
                AttFuncionario att = new AttFuncionario();
                att.Show();
            }

            else if (resp == 3)
            {
                ConsultaRegistroFuncionario con = new ConsultaRegistroFuncionario();
                con.Show();
            }

            else if (resp == 4)
            { 
                ConsultaDemissoesFunc con = new ConsultaDemissoesFunc();
                con.Show();
            }

            else if (resp == 5)
            {
                ConsultaLogin con = new ConsultaLogin();
                con.Show();
            }

            else
            {
                Agrupamento_Setores menu = new Agrupamento_Setores();
                menu.ShowDialog();
            }
            this.Close();

        }
    }
}
