using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
            Array priorities = Enum.GetValues(typeof(Priority));
            Array categories = Enum.GetValues(typeof(Category));

            lbxTasks.ItemsSource = null;
            lbxTasks.ItemsSource = DataRepo.TasksToDo;
            cbxCategory.ItemsSource = categories;
            cbxPriority.ItemsSource = priorities;
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

        private void btnCompleteTask_Click(object sender, RoutedEventArgs e)
        {
            Task selectedTask = lbxTasks.SelectedItem as Task;

            if(selectedTask != null)
            {
                DataRepo.TasksCompleted.Add(selectedTask);
                DataRepo.TasksToDo.Remove(selectedTask);

                lbxTasks.ItemsSource = null;
                lbxTasks.ItemsSource = DataRepo.TasksToDo;
            }
        }

        private void btnCompletedTasks_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TasksCompletedPage());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string json1 = JsonConvert.SerializeObject(DataRepo.TasksToDo, Formatting.Indented);
            string json2 = JsonConvert.SerializeObject(DataRepo.TasksCompleted, Formatting.Indented);

            using (StreamWriter sw = new StreamWriter(@"TasksToDo.json"))
            {
                sw.Write(json1);
            }

            using (StreamWriter sw = new StreamWriter(@"TasksCompleted.json"))
            {
                sw.Write(json2);
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"TasksToDo.json"))
            {
                string json = sr.ReadToEnd();

                DataRepo.TasksToDo = JsonConvert.DeserializeObject<List<Task>>(json);
            }

            lbxTasks.ItemsSource = null;
            lbxTasks.ItemsSource = DataRepo.TasksToDo;

            using (StreamReader sr = new StreamReader(@"TasksCompleted.json"))
            {
                string json = sr.ReadToEnd();

                DataRepo.TasksCompleted = JsonConvert.DeserializeObject<List<Task>>(json);
            }
        }

        private void TbxTaskSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string searchTerm = tbxTaskSearch.Text.ToLower();
           
            lbxTasks.ItemsSource = DataRepo.TasksToDo.Where(t => t.Title.ToLower().Contains(searchTerm) || t.Tags.ToLower().Contains(searchTerm));
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            string searchTerm = cbx.SelectedItem.ToString();

            if(cbx.Name == "cbxCategory" && cbxPriority.SelectedItem == null)
            {
                lbxTasks.ItemsSource = DataRepo.TasksToDo.Where(t => t.TaskCategory.ToString().Equals(searchTerm));
            }
            else if(cbx.Name =="cbxPriority" && cbxCategory.SelectedItem == null)
            {
                lbxTasks.ItemsSource = DataRepo.TasksToDo.Where(t => t.TaskPriority.ToString().Equals(searchTerm));
            }
            else if(cbxCategory.SelectedItem != null && cbx.Name == "cbxPriority")
            {
                lbxTasks.ItemsSource = DataRepo.TasksToDo.Where(t => t.TaskPriority.ToString().Equals(searchTerm) && t.TaskCategory.ToString().Equals(cbxCategory.SelectedItem.ToString()));
            }
            else if(cbxPriority.SelectedItem != null && cbx.Name =="cbxCategory")
            {
                lbxTasks.ItemsSource = DataRepo.TasksToDo.Where(t => t.TaskCategory.ToString().Equals(searchTerm) && t.TaskPriority.ToString().Equals(cbxPriority.SelectedItem.ToString()));
            }
            else
            {
                lbxTasks.ItemsSource = DataRepo.TasksToDo;
            }
        }

        private void btnClearFilter_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HomePage());
        }

        private void DateFilter_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton selected = sender as RadioButton;

            if(selected.Name == "rdoClosest")
            {
                lbxTasks.ItemsSource = DataRepo.TasksToDo.OrderBy(t => t.DueDate);
            }
            else
            {
                lbxTasks.ItemsSource = DataRepo.TasksToDo.OrderByDescending(t => t.DueDate);
            }
        }
    }
}
