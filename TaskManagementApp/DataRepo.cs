using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp
{
    public static class DataRepo
    {
        public static List<Task> TasksToDo { get; set; } = new List<Task>();
        public static List<Task> TasksCompleted { get; set; } = new List<Task>();
        public static List<User> AllUsers { get; set; } = new List<User>();

        //public static List<User> GetUsers()
        //{
        //    List<User> users = new List<User>();

        //    User u1 = new User() { FirstName = "brian", Surname = "keaveney", TasksAssigned = TasksToDo};

        //    users.Add(u1);

        //    return users;
        //}

        //public static List<Task> GetTasks()
        //{
        //    List<Task> tasks = new List<Task>();

          
        //    return tasks;
        //}
    }
}
