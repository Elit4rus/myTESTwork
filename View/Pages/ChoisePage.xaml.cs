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
    /// Логика взаимодействия для ChoisePage.xaml
    /// </summary>
    public partial class ChoisePage : Page
    {
        public ChoisePage()
        {
            InitializeComponent();

            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

            StudentCmb.SelectedValuePath = "ID";
            StudentCmb.DisplayMemberPath = "Name";
            StudentCmb.ItemsSource = App.context.Student.ToList();

            TestCmb.SelectedValuePath = "ID";
            TestCmb.DisplayMemberPath = "Name";
            TestCmb.ItemsSource = App.context.Test.ToList();
        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedGroup = Convert.ToInt32(GroupCmb.SelectedValue);
            StudentCmb.ItemsSource = App.context.Student.Where(x => x.GroupID == SelectedGroup).ToList();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(GroupCmb.Text))
                mes += "Выберите группу\n";
            if (string.IsNullOrWhiteSpace(StudentCmb.Text))
                mes += "Выберите студента\n";
            if (string.IsNullOrWhiteSpace(TestCmb.Text))
                mes += "Выберите тест\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            else if (TestCmb.Text == "Общие основые функционирования субъектов хозяйствования")
            {
                FrameHelper.mainFrame.Navigate(new View.Pages.Test1Page());
            }
            else if (TestCmb.Text == "Сущность и структура основного капитала и оборотных средств предприятия")
            {
                //FrameHelper.mainFrame.Navigate(new View.Pages.Test2Page());
            }
            else if (TestCmb.Text == "Формы и системы оплаты труда")
            {
                //FrameHelper.mainFrame.Navigate(new View.Pages.Test3Page());
            }
            else if (TestCmb.Text == "Результаты коммерческой деятельности")
            {
                //FrameHelper.mainFrame.Navigate(new View.Pages.Test4Page());
            }
        }
    }
}
