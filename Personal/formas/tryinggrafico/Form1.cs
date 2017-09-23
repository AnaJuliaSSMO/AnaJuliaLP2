using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryinggrafico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        Graphics desenho;

        bool retPressionado = false;
        bool piePressionado = false;
        Brush fundo = Brushes.WhiteSmoke;

        private void button1_Click(object sender, EventArgs e)
        {
            desenho = CreateGraphics();
            if (!retPressionado)
            {
                desenho.FillRectangle(Brushes.Red, 10, 10, 100, 200); //desenho.preencha o retangulo: pinte de (cor), coordenadas: x,y,largura,altura;
                retPressionado = true;
            }
            else 
            {
                desenho.FillRectangle(fundo, 10, 10, 100, 200); //desenho.preencha o retangulo: pinte de (cor), coordenadas: x,y,largura,altura;
                retPressionado = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            desenho = CreateGraphics();
            if (!piePressionado)
            {
                desenho.FillPie(Brushes.Blue, 111, 10, 100, 100, 0, 360);
                piePressionado = true;
            }
            else
            {
                desenho.FillPie(Brushes.PowderBlue, 111, 10, 100, 100, 0, 360);
                piePressionado = false;
            }
             // o círculo muda ali ó, o treco é desenho.preencha a torta (acho q é pq torta é redonda_
        }   // coloca sem cor mesmo,n é como se eu fosse enxergar // enfim, x,y,largura,altura,onde começa, onde fecha (será que da pra desenhar o pacman?)

        private void button3_Click(object sender, EventArgs e)
        {
            // o triângulo eu saquei ó: tem 3pontos, pontos são marcações, marcações são coordenadas
            // então tem que fizer onde cada ponto fica, eu acho

            desenho = CreateGraphics();

            //aqui eu tive que pesquisar, e muito, foi foda 'v'

            Point[] tri = { new Point(212, 20), new Point(211, 120), new Point(340, 120) };

            // aqui vc usa tri como variável

            desenho.FillPolygon(Brushes.Pink, tri);
            //é um polígono, então c usa polygon
        }

        private void button4_Click(object sender, EventArgs e)
        {
            desenho = CreateGraphics();
            desenho.FillPie(Brushes.Yellow, 110, 115, 150, 150, 10, 300);

            desenho = CreateGraphics();
            desenho.FillPie(Brushes.Black, 160, 150, 15, 15, 0, 360);

            //ainda não consegui o trapézio
            //ok, eu definitivamente não sei fazer um trapéio, scrr '-'
            //aaaaaaa que bunitinhu eu fiz o pacman 'v' .
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
