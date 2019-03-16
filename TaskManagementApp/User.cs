using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp
{
    public class User
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {Surname}";
        }
    }
}
