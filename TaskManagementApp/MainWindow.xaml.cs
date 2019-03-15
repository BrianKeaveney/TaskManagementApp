﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += Window_Loaded;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataRepo.AllUsers = DataRepo.GetUsers();

            frame.NavigationService.Navigate(new HomePage());
        }

        //private void TestMethod()
        //{

        //    ObservableCollection<string> names = new ObservableCollection<string>();

        //    List<string> names2 = names.ToList();


        //    ObservableCollection<string> names3 = new ObservableCollection<string>(names2);




        //}
    }
}
