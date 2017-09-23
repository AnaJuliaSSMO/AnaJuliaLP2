using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetografico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var A = double.Parse(textBox1.Text);

            var B = double.Parse(textBox2.Text);

            var C = double.Parse(textBox3.Text);

            var D = double.Parse(textBox4.Text);

            var E = double.Parse(textBox5.Text);

            var med = (A + B + C + D + E) / 5;

            label2.Text = ("A média é " + med);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
