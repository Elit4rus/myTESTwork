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
using TESTwork.Model;

namespace TESTwork.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddStudentPage.xaml
    /// </summary>
    public partial class AddStudentPage : Page
    {
        public AddStudentPage()
        {
            InitializeComponent();
            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.mainFrame.Navigate(new View.Pages.TeacherPage());
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(FullNameTb.Text))
            {
                mes += "Введите ФИО\n";
            }
            if (string.IsNullOrWhiteSpace(GroupCmb.Text))
            {
                mes += "Выберите группу\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Group selectedGroup = GroupCmb.SelectedItem as Group;
            if (selectedGroup == null)
            {
                MessageBox.Show("Ошибка выбора группы");
                return;
            }

            Student student = new Student()
            {
                Name = FullNameTb.Text,
                GroupID = selectedGroup.ID
            };
            App.context.Student.Add(student);
            App.context.SaveChanges();
            MessageBox.Show("Студент добавлен");

            FullNameTb.Text = "";
            GroupCmb.Text = "";
        }
    }
}
