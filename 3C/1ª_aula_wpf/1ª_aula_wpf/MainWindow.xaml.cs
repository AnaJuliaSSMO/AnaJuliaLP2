using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1ª_aula_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Melhor pegar um guarda-chuva ;)");
        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Parece que você já tem um guarda chuva :D");
        }

        private void Counter_Click(object sender, RoutedEventArgs e)
        {
            string a = txt1.Text;
            a = a.Replace(" ","");
            int qtd = 0;
            qtd = a.Length;
            MessageBox.Show(qtd.ToString());
        }

        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
