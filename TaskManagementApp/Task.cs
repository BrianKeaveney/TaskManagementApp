using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp
{
    public enum Category { Incidental, Routine, Project, Problem};
    public enum Priority { Low, Medium, High};
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string[] Labels { get; set; }
        public string Tags { get; set; }
        public Category TaskCategory { get; set; }
        public Priority TaskPriority { get; set; }
        public User Responsibility { get; set; }

        public Task()
        {

        }

        public Task(string title, User responsibility)
        {
            Title = title;
            Responsibility = responsibility;
        }

        public Task(string title, string description, DateTime dueDate, string tags, Category taskCategory, Priority taskPriority, User responsibility)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            Tags = tags;
            TaskCategory = taskCategory;
            TaskPriority = taskPriority;
            Responsibility = responsibility;
        }

        public void GetLabels()
        {
            Labels = Tags.Split(',', ' ');
        }

        public override string ToString()
        {
            return $"{Title} {Responsibility.FirstName}";
        }
    }
}
