using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp
{
    public class TaskOverdueEventArgs : EventArgs
    {
        public bool IsOverdue { get; set; }

        public TaskOverdueEventArgs(bool isOverdue)
        {
            IsOverdue = isOverdue;
        }
    }
}
