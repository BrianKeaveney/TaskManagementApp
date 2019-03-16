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

namespace TaskManagementApp
{
    /// <summary>
    /// Interaction logic for AddTaskPage.xaml
    /// </summary>
    public partial class AddTaskPage : Page
    {
        Task TempTask = new Task();
        public AddTaskPage()
        {
            InitializeComponent();           
        }

        //this constructor is only called when you click to edit a task
        public AddTaskPage(Task editTask): this()
        {
            TempTask = editTask;
            FillFields(editTask);
        }
        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddUserPage());
        }

        //when the page is loaded all of the combo boxes are filled with values
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Array priorities = Enum.GetValues(typeof(Priority));
            Array categories = Enum.GetValues(typeof(Category));

            cbxResponsibility.ItemsSource = DataRepo.AllUsers;
            cbxPriority.ItemsSource = priorities;
            cbxCategory.ItemsSource = categories;
        }

        //if the task is given a title and responsibility then the new task is created and added to the list of tasks to do
        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbxTitle.Text) || cbxResponsibility.SelectedItem == null)
            {
                MessageBox.Show("You must have a title and select a responsibility");
            }
            else
            {
                Task task = new Task();

                task.Title = tbxTitle.Text;
                task.Description = tbxDescription.Text;
                task.TaskCategory = (Category)cbxCategory.SelectedIndex;
                task.DueDate = tbxDueDate.SelectedDate;
                task.TaskPriority = (Priority)cbxPriority.SelectedIndex;
                task.Tags = tbxLabels.Text;
                task.GetLabels();
                task.Responsibility = cbxResponsibility.SelectedItem as User;

                DataRepo.TasksToDo.Add(task);

                this.NavigationService.Navigate(new HomePage());
            }

        }

        //only if the temp task has values can it be added back to the list of tasks to do
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            // temptask will have values if a task is being edited
            if (TempTask.Title != null) // temptask.title checked because by default a temptask will have values having enums as part of the object
            {
                DataRepo.TasksToDo.Add(TempTask);
            }

            this.NavigationService.Navigate(new HomePage());
        }

        //function is called when you are editing a task
        private void FillFields(Task editedTask)
        {
            // all of the fields are filled in from the task you are editing
            tbxTitle.Text = editedTask.Title;
            tbxDescription.Text = editedTask.Description;
            cbxCategory.SelectedItem = editedTask.TaskCategory;
            tbxDueDate.SelectedDate = editedTask.DueDate;
            cbxPriority.SelectedItem = editedTask.TaskPriority;
            tbxLabels.Text = editedTask.Tags;
            cbxResponsibility.SelectedItem = editedTask.Responsibility;
        }
    }
}
