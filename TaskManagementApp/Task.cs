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
        public string Colour // based on what priority the task is
        {
            get
            {
                return GetColour();
            }
        }
        public string IsVisible { get; set; }

        public event EventHandler<TaskOverdueEventArgs> TaskOverdue;

        public Task()
        {
            IsVisible = "Hidden";
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

        public string GetColour()
        {
            if (TaskPriority.ToString() == "Low")
                return "#FFF9C12D";
            else if (TaskPriority.ToString() == "Medium")
                return "#FFD1651A";
            else if (TaskPriority.ToString() == "High")
                return "#FFB42222";
            else
                return "White";
        }

        //when task is overdue event is called
        public void CheckDates()
        {
            if(DateTime.Now > DueDate)
            {
                OnDateOverdue("Visible");
            }
        }

        private void OnDateOverdue(string result)
        {
            if (TaskOverdue != null)
                TaskOverdue(this, new TaskOverdueEventArgs(result));
        }

        //tags split up from being a string into an array of strings
        public void GetLabels()
        {
            Tags = Tags.Replace(" ", String.Empty);
            Labels = Tags.Split(',');

            for (int i = 0; i < Labels.Length; i++)
            {
                Labels[i] = $"#{Labels[i]}";
            }
        }
    }
}
