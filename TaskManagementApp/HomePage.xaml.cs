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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lbxTasks.ItemsSource = null;
            lbxTasks.ItemsSource = DataRepo.TasksToDo;
        }

        private void btnAddTask_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddTaskPage());
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Task selectedTask = lbxTasks.SelectedItem as Task;

            if(selectedTask != null)
            {
                this.NavigationService.Navigate(new AddTaskPage(selectedTask));
                DataRepo.TasksToDo.Remove(selectedTask);
            }
        }

        private void btnDeleteTask_Click(object sender, RoutedEventArgs e)
        {
            Task selectedTask = lbxTasks.SelectedItem as Task;

            if(selectedTask != null)
            {
                DataRepo.TasksToDo.Remove(selectedTask);

                lbxTasks.ItemsSource = null;
                lbxTasks.ItemsSource = DataRepo.TasksToDo;
            }
        }
    }
}
