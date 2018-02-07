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
            if (nometxt.Text != "" && setores.Text != null && cpf.Text != "   .   .   -" && nasc.Text != "  /  /" && data.Text != "  /  /")
            {
                 RelacaoFuncionarios.AdmiteFuncionario(nometxt.Text, cpf.Text, nasc.Text, setores.Text, data.Text);
                 cpf.Clear();
                 nometxt.Clear();
                 nasc.Clear();
                 setores.ResetText();
                 data.Clear();
            }

            if (nometxt.Text == "") { txt.Text = "Preenchimento de campo obrigatório"; }
            else
            {
                txt.Text = "";
                string nome = nometxt.Text;
            }

            if (cpf.Text == "   .   .   -") { txt1.Text = "Preenchimento de campo obrigatório"; }
            else
            {
                txt1.Text = "";
                string CPF = cpf.Text;
            }

            if (nasc.Text == "  /  /") { txt2.Text = "Preenchimento de campo obrigatório"; }
            else
            {
                txt2.Text = "";
                string nasceu = nasc.Text;
            }

            if (data.Text == "  /  /") { txt4.Text = "Preenchimento de campo obrigatório"; }
            else
            {
                txt3.Text = "";
                string datad = data.Text;
            }

            if (setores.Text == null || setores.Text == "") { txt3.Text = "Preenchimento de campo obrigatório"; }
            else
            {
                txt4.Text = "";
                string setor = setores.SelectedItem.ToString();
            }
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
