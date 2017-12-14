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

namespace Tentativa_projeto
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

        ComboBox inte = new ComboBox();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string txt = String.Format(textBox.Text);

            if (integrantes.Items.Contains(txt))
            {
                MessageBox.Show("Já inscrita");
            }

            else
            {
                integrantes.Items.Add(txt);
                MessageBox.Show("Adicionado com sucesso");
            }
            textBox.Clear();
        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            integrantes.Items.Remove(integrantes.SelectedItem);
        }

        private void integrantes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {        
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

       
    }
}
