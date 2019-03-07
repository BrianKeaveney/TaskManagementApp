using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp
{
    public class User
    {
        public List<Task> TasksAssigned { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}
