namespace Models
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }
        public string Department { get; set; }

        public Manager(string firstName, string lastName, double salary, string department) :
            base(firstName, lastName, RoleEnum.Manager, salary)
        {
            Bonus = 0;
            Department = department; // Task 1
        }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }

        public override double GetSalary()
        {
            return base.GetSalary() + Bonus;
        }
    }
}

