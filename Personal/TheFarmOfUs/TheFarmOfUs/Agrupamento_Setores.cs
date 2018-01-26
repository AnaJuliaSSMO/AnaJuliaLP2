﻿using System;
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
    public partial class Agrupamento_Setores : Form
    {
        public Agrupamento_Setores()
        {
            InitializeComponent();
        }

        private void choosesetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int resp = choosesetor.SelectedIndex;

            if(resp == 0)
            {
                SetorPecuaria vaca = new SetorPecuaria();
                vaca.Show();
                //FEITO
            }

            else if(resp == 1)
            {
                SetorAgricultura planta = new SetorAgricultura();
                planta.Show();
                //FEITO
            }

            else if(resp == 2)
            {
                SetorFuncionario func = new SetorFuncionario();
                func.Show();
            }

            else if(resp == 3)
            {
                SetorContabilidade conta = new SetorContabilidade();
                conta.Show();
            }

            else
            {
                MenuInicial menu = new MenuInicial();
                menu.ShowDialog();
            }
            Close();
        }
    }
}
