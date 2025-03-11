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
using TESTwork.AppData;

namespace TESTwork.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void OKbtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTb.Text))
            {
                MessageBox.Show("Введите пароль");

            }
            else
            {
                if (LoginTb.Text == "123")
                {
                    MessageBox.Show("Данные верны");
                    FrameHelper.mainFrame.Navigate(new View.Pages.TeacherPage());
                }
                else
                {
                    MessageBox.Show("Данные неверны");
                }
            }
        }
    }
}
