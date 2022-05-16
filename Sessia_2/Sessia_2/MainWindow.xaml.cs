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
using Sessia_2.Classes;

namespace Sessia_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Abonent());
            Manager.MainFrame = MainFrame;
        }

        private void Prof_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Question_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void support_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void support_Copy1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void support_Copy2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void support_Copy5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void support_Copy4_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
