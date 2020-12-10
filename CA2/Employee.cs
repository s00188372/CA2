using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Employee(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;

        }

        public override string ToString()
        {
            return string.Format($"{LastName}, {FirstName}");
        }
    }
}
