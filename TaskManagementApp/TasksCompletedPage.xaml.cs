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
    /// Interaction logic for TasksCompletedPage.xaml
    /// </summary>
    public partial class TasksCompletedPage : Page
    {
        public TasksCompletedPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Array priorities = Enum.GetValues(typeof(Priority));
            Array categories = Enum.GetValues(typeof(Category));

            cbxCategory.ItemsSource = categories;
            cbxPriority.ItemsSource = priorities;

            lbxTasksCompleted.ItemsSource = null;
            lbxTasksCompleted.ItemsSource = DataRepo.TasksCompleted;
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HomePage());
        }

        private void TbxTaskSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string searchTerm = tbxTaskSearch.Text.ToLower();

            lbxTasksCompleted.ItemsSource = DataRepo.TasksCompleted.Where(t => t.Title.ToLower().Contains(searchTerm) || t.Tags.ToLower().Contains(searchTerm));
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            string searchTerm = cbx.SelectedItem.ToString();

            if (cbx.Name == "cbxCategory" && cbxPriority.SelectedItem == null)
            {
                lbxTasksCompleted.ItemsSource = DataRepo.TasksCompleted.Where(t => t.TaskCategory.ToString().Equals(searchTerm));
            }
            else if (cbx.Name == "cbxPriority" && cbxCategory.SelectedItem == null)
            {
                lbxTasksCompleted.ItemsSource = DataRepo.TasksCompleted.Where(t => t.TaskPriority.ToString().Equals(searchTerm));
            }
            else if (cbxCategory.SelectedItem != null && cbx.Name == "cbxPriority")
            {
                lbxTasksCompleted.ItemsSource = DataRepo.TasksCompleted.Where(t => t.TaskPriority.ToString().Equals(searchTerm) && t.TaskCategory.ToString().Equals(cbxCategory.SelectedItem.ToString()));
            }
            else if (cbxPriority.SelectedItem != null && cbx.Name == "cbxCategory")
            {
                lbxTasksCompleted.ItemsSource = DataRepo.TasksCompleted.Where(t => t.TaskCategory.ToString().Equals(searchTerm) && t.TaskPriority.ToString().Equals(cbxPriority.SelectedItem.ToString()));
            }
            else
            {
                lbxTasksCompleted.ItemsSource = DataRepo.TasksCompleted;
            }
        }

        private void DateFilter_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton selected = sender as RadioButton;

            if (selected.Name == "rdoClosest")
            {
                lbxTasksCompleted.ItemsSource = DataRepo.TasksCompleted.OrderBy(t => t.DueDate);
            }
            else
            {
                lbxTasksCompleted.ItemsSource = DataRepo.TasksCompleted.OrderByDescending(t => t.DueDate);
            }
        }

        private void btnClearFilter_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TasksCompletedPage());
        }
    }
}
