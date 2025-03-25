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
    /// Логика взаимодействия для DeleteStudentPage.xaml
    /// </summary>
    public partial class DeleteStudentPage : Page
    {
        List<Student> students = App.context.Student.ToList();
        List<Group> groups = App.context.Group.ToList();
        public DeleteStudentPage()
        {
            InitializeComponent();

            StudentsLv.ItemsSource = App.context.Student.ToList();
            GroupCmb.ItemsSource = App.context.Group.ToList();
            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.mainFrame.Navigate(new View.Pages.TeacherPage());
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = (Student)StudentsLv.SelectedItem;

            if (selectedStudent != null)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить студента?", "Подтверждение удаления", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    // // Удаление связанных записей из Group
                    var relatedGroups = App.context.Group.Where(gr => gr.ID == selectedStudent.ID).ToList();
                    foreach (var group in relatedGroups)
                    {
                        App.context.Group.Remove(group);
                    }

                    // Удаление связанных записей из Journal
                    var relatedJournal = App.context.Journal.Where(j => j.ID == selectedStudent.ID).ToList();
                    foreach (var journal in relatedJournal)
                    {
                        App.context.Journal.Remove(journal);
                    }

                    // Теперь можно удалить книгу
                    App.context.Student.Remove(selectedStudent);
                    App.context.SaveChanges();

                    // Обновляем список отображаемых книг
                    StudentsLv.ItemsSource = App.context.Student.ToList();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите студента для удаления.");
            }
        }
    }
}
