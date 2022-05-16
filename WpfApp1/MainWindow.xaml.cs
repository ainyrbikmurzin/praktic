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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        class Method
        {
            public string GetCode()
            {
                int[] arr = new int[8];
                Random rnd = new Random();
                string Code = "";

                for (int i=0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(33, 125);
                    Code += (char)arr[i];
                }
                return Code;
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            nomer.Clear();
            parol.Clear();
            kod.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)

        {

            Method P = new Method();
            var code = P.GetCode();
            MessageBox.Show(code, "Генератор кода");
            
        }

        private void nomer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox textBox = e.Source as
                    TextBox;
                if (textBox !=null)
                {
                    parol.IsEnabled =
                        IsEnabled;
                }
            }
        }
    }
}
