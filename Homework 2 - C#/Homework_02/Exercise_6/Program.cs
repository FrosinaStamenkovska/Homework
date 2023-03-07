namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number.");
            string firstInput = Console.ReadLine();

            if (!int.TryParse(firstInput, out int firstNumber))
            {
                Console.WriteLine("Your first input is invalid, please enter a valid number!");
                return;
            }

            Console.WriteLine("Please enter the second number.");
            string secondInput = Console.ReadLine();

            if(!int.TryParse(secondInput, out int secondNumber))
            {
                Console.WriteLine("Your second input is invalid, please enter a valid number!");
                return;
            }

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} is larger than {secondNumber}.");
                if (firstNumber % 2 != 0)
                {
                    Console.WriteLine($"{firstNumber} is odd number.");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} is even number.");
                }
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine($"{secondNumber} is larger than {firstNumber}.");
                if (secondNumber % 2 != 0)
                {
                    Console.WriteLine($"{secondNumber} is odd number.");
                }
                else
                {
                    Console.WriteLine($"{secondNumber} is even number.");
                }
            }
            else
            {
                if (firstNumber % 2 != 0)
                {
                    Console.WriteLine("The numbers are equal and they are odd numbers.");
                }
                else
                {
                    Console.WriteLine("The numbers are equal and they are even numbers.");
                }
            }


        }
    }
}