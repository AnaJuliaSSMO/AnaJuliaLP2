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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void funcoesfuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            int resp =funcoesfuncionario.SelectedIndex;

            if (resp == 0)
            {
               // Adicionar um novo funcionário;
            }

            else if (resp == 1)
            {
                //Retirar o registro de um funcionário; FAMOSO DELETE
            }

            else if (resp == 2)
            {
               // Atualizar informações de um funcionário; FMZ UPDATE
            }

            else if (resp == 3)
            {
               /* Cálculo de multa rescisória de acordo com o salário do funcionário e registro da mesma;
                * QUE??*/
            }

            else if(resp == 4)
            {
              //  Consulta de registros; turu bom?
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
