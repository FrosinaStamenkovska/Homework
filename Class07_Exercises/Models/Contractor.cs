using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Contractor : Employee // task 1
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, double workHours, int payPerHour, Manager responsible)
        : base(firstName, lastName, RoleEnum.Other, 0)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;

        }

        public override double GetSalary()
        {   
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public string CurrentPosition()
        {
            return Responsible.Department;
        }
    }

    
}
