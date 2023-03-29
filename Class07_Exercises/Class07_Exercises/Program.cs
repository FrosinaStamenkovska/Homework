
using Models;

namespace Class07_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, to our company!");

            SalesPerson salesPerson1 = new SalesPerson("Sales", "One");
            SalesPerson salesPerson2 = new SalesPerson("Sales", "Two");

            Manager manager = new Manager("Manager", "Manager", 1500, "Marketing");

            salesPerson1.AddSuccessRevenue(300);
            salesPerson2.AddSuccessRevenue(500);

            salesPerson2.AddSuccessRevenue(300);
            salesPerson1.AddSuccessRevenue(2000);

            manager.AddBonus(450);

            Console.WriteLine(salesPerson1.GetInfo());
            Console.WriteLine(salesPerson2.GetInfo());
            Console.WriteLine(manager.GetInfo());

            Employee otherEmployee = new Employee("Risto", "Panchevski", RoleEnum.Other, 300);

            Console.WriteLine(otherEmployee.GetInfo());

            // Task 1

            Manager manager1 = new Manager("Bob", "Bobski", 2000, "Marketing");
            Manager manager2 = new Manager("Rob", "Robski", 2000, "IT");

            Contractor contractor1 = new Contractor("John", "Doe", 180, 12, manager1);
            Contractor contractor2 = new Contractor("Jane", "Doe", 100, 20, manager2);

            Console.WriteLine(contractor1.GetSalary());
            Console.WriteLine(contractor1.CurrentPosition());

            Console.WriteLine(contractor2.GetSalary());
            Console.WriteLine(contractor2.CurrentPosition());



            // Task 2

            SalesPerson salesPerson = new SalesPerson("Sale", "Salevski");

            Employee[] company = new Employee[5] {manager1, manager2, contractor1, contractor2, salesPerson};

            CEO ceo = new CEO("Ron", "Ronsky", 1500, 100, company);
            

            Console.WriteLine(ceo.GetInfo());
            ceo.AddSharesPrice(14);
            Console.WriteLine($"Salary of CEO is: {ceo.GetSalary():C}");
            ceo.PrintEmployees();
            
            



            

        }
    }
}