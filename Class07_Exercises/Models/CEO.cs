using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; } 

        public CEO(string firstName, string lastName, double salary, int shares, Employee[] employees)
            :base(firstName, lastName,RoleEnum.CEO, salary)
        {
            Shares = shares;
            Employees = employees;
            SharesPrice = 0;
        }

        public void AddSharesPrice(double sharesPrice)
        {
            SharesPrice = sharesPrice;
        }

        public void PrintEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

        public override double GetSalary()
        {
            Salary += (Shares * SharesPrice);
            return Salary;
        }



    }
}
