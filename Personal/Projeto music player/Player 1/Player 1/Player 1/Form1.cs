using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Player_1
{
    public partial class Form1 : Form
    {
        string[] doc, path;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // meu botão 1 abre
        {

            OpenFileDialog abrir = new OpenFileDialog(); // para abrir os arquivos

            abrir.Multiselect = true; // meu prog n rodava sem isso, se n me engano é para selecionar vários

            abrir.Filter = "Mp3 Files|*.mp3|Avi Files|*.avi|Wav Files|*.wav| Mp4 Files|*.mp4"; // pra ele aceitar esses tipos d arquivo pq sem isso só vai o wav 

            if (abrir.ShowDialog() == DialogResult.OK) //quando clicar no botão
            {
                doc = abrir.SafeFileNames;
                path = abrir.FileNames; //autoexplicativo

                for (int i = 0; i < doc.Length; i++) //MANO IF É A MELHOR COISA
                {
                    listBox1.Items.Add(doc[i]);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = path[listBox1.SelectedIndex];
            }

            catch (IndexOutOfRangeException r)
            { }
        }

        private void button2_Click(object sender, EventArgs e) // meu botão 2 da random na parada
        {
            Application.Exit();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog(); // para abrir os arquivos

            abrir.Multiselect = true; // meu prog n rodava sem isso, se n me engano é para selecionar vários

            abrir.Filter = "Mp3 Files|*.mp3|Avi Files|*.avi|Wav Files|*.wav| Mp4 Files|*.mp4"; // pra ele aceitar esses tipos d arquivo pq sem isso só vai o wav 

            if (abrir.ShowDialog() == DialogResult.OK) //quando clicar no botão
            {
                doc = abrir.SafeFileNames;
                path = abrir.FileNames; //autoexplicativo

                for (int i = 0; i < doc.Length; i++) //MANO IF É A MELHOR COISA
                {
                    listBox1.Items.Add(doc[i]);
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog abrirarquivo = new OpenFileDialog(); //isso é para pesquisar arquivos

            if (abrirarquivo.ShowDialog() == DialogResult.OK) //quando clicar no botão
            {
                Bitmap bit = new Bitmap(abrirarquivo.FileName); //"variável" de imagem e pesquisa

                pictureBox1.Image = bit; // associar a variável ao botão

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // o jeito que a imagem aparece
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog(); //isso é para pesquisar arquivos

            if (open.ShowDialog() == DialogResult.OK) //quando clicar no botão
            {
                Bitmap bit = new Bitmap(open.FileName); //"variável" de imagem e pesquisa

                pictureBox2.Image = bit; // associar a variável ao botão

                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom; // o jeito que a imagem aparece
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }
    }
}
