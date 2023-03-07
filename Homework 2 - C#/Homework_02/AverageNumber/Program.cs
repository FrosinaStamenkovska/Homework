namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's calculate the average of 4 numbers!");

            Console.WriteLine("Enter the first number!");
            string input1 = Console.ReadLine();
            if(!int.TryParse(input1, out int number1)) 
            {
                Console.WriteLine("Invalid input, please enter a valid number");
                return;
            }

            Console.WriteLine("Enter the second number!");
            string input2 = Console.ReadLine();
            if (!int.TryParse(input2, out int number2))
            {
                Console.WriteLine("Invalid input, please enter a valid number");
                return;
            }

            Console.WriteLine("Enter the third number!");
            string input3 = Console.ReadLine();
            if (!int.TryParse(input3, out int number3))
            {
                Console.WriteLine("Invalid input, please enter a valid number");
                return;
            }

            Console.WriteLine("Enter the fourth number!");
            string input4 = Console.ReadLine();
            if (!int.TryParse(input4, out int number4))
            {
                Console.WriteLine("Invalid input, please enter a valid number");
                return;
            }

            float result = (float)(number1 + number2 +  number3 + number4) / 4;
            Console.WriteLine($"The average of {number1}, {number2}, {number3} and {number4} is: {result}");

        }
    }
}