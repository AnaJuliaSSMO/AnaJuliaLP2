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
    public partial class AddFuncionario : Form
    {
        public AddFuncionario()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string nome = nometxt.Text;
            string CPF = cpf.Text;
            string nasceu = nasc.Text;
            string setor = setores.SelectedItem.ToString();
            string datad = data.Text;

            RelacaoFuncionarios.AdmiteFuncionario(nome, CPF, nasceu, setor,datad);
            cpf.Clear();
            nometxt.Clear();
            nasc.Clear();
            setores.ResetText();
            data.Clear();
        }

        private void cance_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar operação?", "Tem certeza de sua escolha?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SetorFuncionario sf = new SetorFuncionario();
                sf.Show();
                Close();
            }
        }
    }
}
