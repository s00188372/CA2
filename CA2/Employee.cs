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

        public string EmployeeTime { get; set; }

        public decimal FullTimeSalary { get; set; }

        public decimal HourlyRate { get; set; }

        public double Hours { get; set; }



        public Employee(string firstname, string lastname, string employeetime, decimal fulltimesalary, decimal hourlyrate, double hours)
        {
            FirstName = firstname;
            LastName = lastname;
            EmployeeTime = employeetime;
            FullTimeSalary = fulltimesalary;
            HourlyRate = hourlyrate;
            Hours = hours;

        }

        public override string ToString()
        {
            return string.Format($"{LastName}, {FirstName},{EmployeeTime}");
        }
    }
}
