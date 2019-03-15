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
        public delegate void DateOverdueEventHandler(object source, EventArgs args);
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string[] Labels { get; set; }
        public string Tags { get; set; }
        public Category TaskCategory { get; set; }
        public Priority TaskPriority { get; set; }
        public User Responsibility { get; set; }
        public bool IsDateOverdue { get; set; } = false;

        public event DateOverdueEventHandler Overdue;

        //private bool taskIsOverdue;

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
            Tags = Tags.Replace(" ", String.Empty);
            Labels = Tags.Split(',');
        }
        protected virtual void OnDateOverdue()
        {
            if(Overdue != null)
            {
                Overdue(this, EventArgs.Empty);
            }
            //DateTime example = new DateTime(2019, 03, 15, 15, 22,0);
            //if (DateTime.Now == example)
            //{
            //    Overdue(this, new TaskEventArgs("true"));
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
        }

        private void OnDateOverdue(object sender, EventArgs e)
        {
            IsDateOverdue = true;
        }

        public override string ToString()
        {
            return $"{Title} {Responsibility.FirstName} {TaskCategory} {DueDate} {TaskPriority}";
        }
    }
}
