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
    public partial class AdministraSalario : Form
    {
        public AdministraSalario()
        {
            InitializeComponent();
        }

        private void AdministraSalario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui na empresa trabalhamos com a política de um mesmo salário para todos os funcionários de um mesmo setor.\n\nPortanto os salários são dividos de acordo com os setores.");
        }

        private void alt_Click(object sender, EventArgs e)
        {
            string setor = setores.SelectedItem.ToString();
            double sal = double.Parse(salario.Text);

            RelacaoFuncionarios.AlteraSalarioSetores(setor, sal);

            setores.ResetText();
            salario.Text = "00,00";
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (queragri.Checked == true)
            {
                string escolha = "agricultura";
                RelacaoFuncionarios.ConsultaSalario(escolha);
            }

            if (quercont.Checked == true)
            {
                string escolha = "contabilidade";
                RelacaoFuncionarios.ConsultaSalario(escolha);
            }

            if (querpec.Checked == true)
            {
                string escolha = "pecuaria";
                RelacaoFuncionarios.ConsultaSalario(escolha);
            }
        }

        private void sair_Click(object sender, EventArgs e)
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
