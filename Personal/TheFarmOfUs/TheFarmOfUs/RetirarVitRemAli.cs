﻿using System;
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
    /*TEM QUE FAZER UM
     * 
     * SE QUANTIDADE DO BANCO FOR MENOR QUE QUANTIDADE QUE QUER RETIRAR
     * MOSTRAR UM (SORRY, NÃO HÁ O SUFICIENTE, INSIRA UM NUMERO ATÉ TAL)
     * 
     */
    
    public partial class RetirarVitRemAli : Form
    {
        public RetirarVitRemAli()
        {
            InitializeComponent();
        }

        SqlCommand cmd = new SqlCommand()
        {
            Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
        };

        private void procura_Click(object sender, EventArgs e) //aqui ele importa quais são os nomes disponíveis de vitaminas, remedios e alimentos. CONSEGUI MAN ;V; 
        {
            nomes.Items.Clear();
            string select = tipo.SelectedItem.ToString();
            string[] names = new string[10000];
            int i = 0;

            cmd.Connection.Open();

            cmd.CommandText = String.Format(@"SELECT Nome
                                               FROM AlRemVa
                                               WHERE Tipo = '{0}';", select);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    names[i] = reader.GetString(0);
                    nomes.Items.Add(names[i]);
                    i++;
                }
            }
            cmd.Connection.Close();
        }

        private void retirar_Click(object sender, EventArgs e)
        {
            int qtdd = int.Parse(qtd.Text);
            string nome = nomes.SelectedItem.ToString();
            string select = tipo.SelectedItem.ToString();

            AlimentoRemedioVitamina.Retirar(nome, select,qtdd);

            if (AlimentoRemedioVitamina.cone == "")
            {
                if (AlimentoRemedioVitamina.an == "ok")
                {
                    qtd.Clear();
                    nomes.ResetText();
                    tipo.ResetText();
                    MessageBox.Show("Efetuado com sucesso,agora você possui " + AlimentoRemedioVitamina.novaqtd2 + "kg/embalagens de " + nome);
                }

                else if (AlimentoRemedioVitamina.an == "nop")
                {
                    qtd.Clear();
                    MessageBox.Show(AlimentoRemedioVitamina.msg);
                }
            }

        }

        private void cancelar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar operação?", "Tem certeza de sua escolha?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Gado gd = new Gado();
                gd.Show();
                Close();
            }
        }
    }
}