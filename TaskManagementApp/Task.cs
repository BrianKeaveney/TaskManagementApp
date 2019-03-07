using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp
{
    public enum Category { };
    public enum Priority { low, medium, high};
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public List<string> Labels { get; set; }
        public Category TaskCategory { get; set; }
        public Priority TaskPriority { get; set; }
        public User Responsibility { get; set; }
    }
}
