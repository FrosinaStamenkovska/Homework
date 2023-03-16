namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please fill out the following information about you!");
            Console.WriteLine("First Name:");
            string firstName = Console.ReadLine();

            // validations if the user leaves empty field or inserts a number for First name or Last name
            if(firstName == "")
            {
                Console.WriteLine("You have to insert your First Name!");
                return;
            } else if (int.TryParse(firstName , out int value))
            {
                Console.WriteLine("You cannot insert a number for First Name!");
                return;
            }
            

            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();

            if (lastName == "")
            {
                Console.WriteLine("You have to insert your Last Name!");
                return;
            }
            else if (int.TryParse(lastName, out int value))
            {
                Console.WriteLine("You cannot insert a number for Last Name!");
                return;
            }

            Console.WriteLine("Age:");
            string age = Console.ReadLine(); // in this case there is no need of parsing the age input into number

            if (age == "")
            {
                Console.WriteLine("You have to insert your age!");
                return;
            }
            else if (!int.TryParse(age, out int value)) // validation if the user doesn't insert a number for age input
            {
                Console.WriteLine("You need to insert a number for the age - field!");
                return;
            }

            // Creating an object from the class Human, using the inputs from the user as arguments
            Human person1 = new Human(firstName, lastName, age);

            //calling the GetPersonDetails Method from the new created Object "person1"
            Console.WriteLine(person1.GetPersonDetails());



        }
    }
}