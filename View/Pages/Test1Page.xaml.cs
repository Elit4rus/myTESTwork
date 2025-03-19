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

namespace TESTwork.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Test1Page.xaml
    /// </summary>
    public partial class Test1Page : Page
    {
        int b = 0;
        int c = 0;
        public Test1Page()
        {
            InitializeComponent();
        }

        private void p10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p3_Click(object sender, RoutedEventArgs e)
        {
            if (Chb1.IsChecked == false && Chb2.IsChecked == false && Chb3.IsChecked == false && Chb4.IsChecked == false && Chb5.IsChecked == false)
            {
                MessageBox.Show("правильно");
                b = b + 1;
            }
            else MessageBox.Show("неправильно");
            p3.Visibility = Visibility.Collapsed;
            products.SelectedItem = v4;
        }

        private void p2_Click(object sender, RoutedEventArgs e)
        {
            if (RB2.IsChecked == true)
            {
                MessageBox.Show("правильно");
                b = b + 1;
            }
            else MessageBox.Show("неправильно");
            p2.Visibility = Visibility.Collapsed;
            products.SelectedItem = v3;
        }

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "5")
            {
                MessageBox.Show("правильно");
                b = b + 1;
            }
            else MessageBox.Show("неправильно");
            p1.Visibility = Visibility.Collapsed;
            products.SelectedItem = v2;
        }
    }
}
