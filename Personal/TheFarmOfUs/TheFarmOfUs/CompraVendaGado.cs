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

/*primeiro ele vai ter que fazer um SELECT
 * pedindo pra trazer o valor que tem na tabela "diponivel"*/
namespace TheFarmOfUs
{
    public partial class CompraVendaGado : Form
    {
        public CompraVendaGado()
        {
            InitializeComponent();
        }

        SqlCommand cmd = new SqlCommand()
        {
            Connection = new SqlConnection(@"Data Source=(localdb)\MySlave;Initial Catalog=LOGINUSER;Integrated Security=SSPI")
        };

        string escolha = "gado";

        private void quercomprar_Click(object sender, EventArgs e)
        {
            string animalescolhido = animais.SelectedItem.ToString();
            int quantidadeani = int.Parse(qtd.Text);
            double valorunitario = double.Parse(valor.Text);
            //OUTRAS
            string deseja = "comprar";
            double valorcompra = valorunitario * quantidadeani;

            MessageBox.Show("O animal escolhido foi: " + animalescolhido);
            if(MessageBox.Show("O Valor se sua compra foi: R$ " + valorcompra + ".\nDeseja continuar?","Valor total foi de:",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                CompraVendaRetiradaSaldo.CompraVendaGado(deseja, valorcompra, animalescolhido, quantidadeani);

                if(CompraVendaRetiradaSaldo.ok == "s")
                {
                    animais.ResetText();
                    qtd.Text = "Insira a quantidade";
                    valor.Text = "00,00";
                }

                else
                {
                    valor.Text = "00,00";
                }
            }
            //MessageBox.Show(CompraEVenda.PegarValorDisponivel(escolha));

        }

        private void quervender_Click(object sender, EventArgs e)
        {
            string animalescolhido = animais.SelectedItem.ToString();
            int quantidadeani = int.Parse(qtd.Text);
            double valorunitario = double.Parse(valor.Text);
            //OUTRAS
            string deseja = "vender";
            double valorcompra = valorunitario * quantidadeani;

            MessageBox.Show("O animal escolhido foi: " + animalescolhido);
            if (MessageBox.Show("O Valor se sua compra foi: R$ " + valorcompra + ".\nDeseja continuar?", "Valor total foi de:", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                CompraVendaRetiradaSaldo.CompraVendaGado(deseja, valorcompra, animalescolhido, quantidadeani);

                if (CompraVendaRetiradaSaldo.ok == "s")
                {
                    animais.ResetText();
                    qtd.Text = "Insira a quantidade";
                    valor.Text = "00,00";
                }

                else
                {
                    qtd.Text = "Insira a quantidade";
                }
            }

            // MessageBox.Show(CompraEVenda.PegarValorDisponivel(escolha));
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar operação?", "Tem certeza de sua escolha?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SetorPecuaria gd = new SetorPecuaria();
                gd.Show();
                Close();
            }
        }
    }
}


/* EU FIZ UMA MERDA MT MT MT MT MT GRANDE
 * DICULPA
 * 
 * private void quercomprar_Click(object sender, EventArgs e)
 {
     //variáveis vindas da form
     int qtdcomprada = int.Parse(qtd.Text);
     double preco = double.Parse(valor.Text);
     string animal = animais.SelectedItem.ToString();

     CompraEVenda.CompraVendaGado(qtdcomprada, preco, animal);


     if (CompraEVenda.CompraVendaGado(cone) == "")//ele dá erro pq n ta retornando
     {

         MessageBox.Show("O animal escolhido foi: " + animal);
     }

     else
     {
         MessageBox.Show(cone);
     }
 }

 private void quervender_Click(object sender, EventArgs e)
 {
     /*
      * q q eu to fazendo pelo amor dos deuses
   //variáveis vindas da form
   int qtdvendida = int.Parse(qtd.Text), qtdatual,novaqtd;
   double preco = double.Parse(valor.Text),tenho = 5000;
   string animal = animais.SelectedItem.ToString(),cone = "";

   //variáveis "auxiliares"
   double precototal = preco * qtdvendida;

   //COMEÇA O SELECT
   try
   {
       cmd.Connection.Open();
   }

   catch (SqlException)
   { 
       cone = "Não foi possível efeutar a conexão, tente mais tarde";
   }

   if(cone == "")
   {
      * 
      *  cmd.CommandText = String.Format(@"SELECT Quantidade
                                      FROM Gado
                                      WHERE Animal = '{0}';", animal);
       qtdatual = (Int32)cmd.ExecuteScalar();
       //TERMINA O SELECT

       MessageBox.Show("O animal escolhido foi: " + animal);

       if (qtdatual < qtdvendida)
       {
           qtd.Clear();
           MessageBox.Show("Não há animais suficientes para a venda.Por favor,insira um número até " + qtdatual, "Ops");
       }

       else
       {
           tenho = tenho + precototal;
           novaqtd = qtdatual - qtdvendida;
           if (MessageBox.Show("O total da sua venda é de R$" + precototal + "\nDeseja continuar?", "Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
           {
               qtd.Clear();
               valor.Clear();
               animais.ResetText();

               cmd.CommandText = String.Format(@"UPDATE Gado 
                                           SET Quantidade = {0}
                                           WHERE Animal = '{1}'", novaqtd, animal);

               SqlDataReader reader = cmd.ExecuteReader();
               MessageBox.Show("Venda efetuada com sucesso, o saldo atual para uso do setor Gado é de R$" + tenho);
               MessageBox.Show("Você possui " + novaqtd + " " + animal + "(s) agora.");
               cmd.Connection.Close();
           }
       }

       cmd.Connection.Close();
   }

   else
   {
       MessageBox.Show(cone);
   }
   }*/
