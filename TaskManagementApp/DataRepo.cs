using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp
{
    //acts as a database for the application
    public static class DataRepo
    {
        public static List<Task> TasksToDo { get; set; } = new List<Task>();
        public static List<Task> TasksCompleted { get; set; } = new List<Task>();
        public static ObservableCollection<User> AllUsers { get; set; } = new ObservableCollection<User>();

        public static ObservableCollection<User> GetUsers()
        {
            ObservableCollection<User> users = new ObservableCollection<User>();

            User u1 = new User() { FirstName = "brian", Surname = "keaveney" };
            User u2 = new User() { FirstName = "Tom", Surname = "Sawyer" };
            User u3 = new User() { FirstName = "Eddie", Surname = "Dean" };

            users.Add(u1);
            users.Add(u2);
            users.Add(u3);

            return users;
        }
    }
}
