﻿using System;
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
    /// Interaction logic for AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        private User User = new User();
        public AddUserPage()
        {
            InitializeComponent();
            //if(tbxFirstName.Text != null)
            //    Console.WriteLine("hello");
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (tbxFirstName.Text != null && tbxSurname.Text != null)
            {
                User.FirstName = tbxFirstName.Text;
                User.Surname = tbxSurname.Text;
                DataRepo.AllUsers.Add(User);
            }
  
            this.NavigationService.Navigate(new AddTaskPage());
        }
    }
}
