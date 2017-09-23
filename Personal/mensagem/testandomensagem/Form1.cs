using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testandomensagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oh, thanks Sr. ;)"); // isso aqui faz aparecer uma mensagem na tela
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You shouldn't have done this >:-)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HEHEHE I LIED!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I really don't care about this, just go out dude");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I including");
            //"Everybody except neither the last but one is lying." mas da onde raios foi que eu tirei essa construção?
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey :3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirarquivo = new OpenFileDialog(); //isso é para pesquisar arquivos

            if (abrirarquivo.ShowDialog()== DialogResult.OK) //quando clicar no botão
            {
                Bitmap bit = new Bitmap(abrirarquivo.FileName); //"variável" de imagem e pesquisa

                pictureBox1.Image = bit; // associar a variável ao botão

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // o jeito que a imagem aparece
            }
        }
    }
}
