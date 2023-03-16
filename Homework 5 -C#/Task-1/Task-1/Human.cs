namespace Task_1
{
    internal class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }

        public Human(string firstName, string lastName, string age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string GetPersonDetails()
        {
            return $"Fullname: {FirstName} {LastName}, Age: {Age}";
        }
    }
}
