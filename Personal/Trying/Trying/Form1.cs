using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trying
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Integrantes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SE TU N CHEGAR NA @TUTU EU VOU");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("I including");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirarquivo = new OpenFileDialog();
            if (abrirarquivo.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit = new Bitmap(abrirarquivo.FileName);
                pictureBox1.Image = bit;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Setores_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra efetuada com sucesso!");
            button3.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venda efetuada com sucesso!");
            button3.Show();
        }

        private void atualizarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atualização efetuada com sucesso!");
            button3.Show();
        }
    }
}
