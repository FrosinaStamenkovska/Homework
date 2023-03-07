using System;

namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number.");

            string firstInput = Console.ReadLine();
            if(!int.TryParse(firstInput, out int firstNumber))
            {
                Console.WriteLine("Please enter a valid number!");
                return;
            }

            Console.WriteLine("Please enter your second number.");
            string secondInput = Console.ReadLine();
            if (!int.TryParse(secondInput, out int secondNumber))
            {
                Console.WriteLine("Please enter a valid number!");
                return;
            }

            Console.WriteLine("What operation would you like to be done? Please choose one of the following options: + , - , * , / ");

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine(firstNumber + secondNumber);
                    break;
                case "-":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case "*":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case "/":
                    if(firstNumber == 0 || secondNumber == 0)
                    {
                        Console.WriteLine("You cannot divide with 0!");
                        return;
                    }
                    if(firstNumber % secondNumber != 0)
                    {
                        double result = firstNumber / (double) secondNumber;
                        Console.WriteLine(result);
                        return;
                    }
                    Console.WriteLine(firstNumber / secondNumber);

                    break;
                default:
                    Console.WriteLine("You have entered an invalid operation, please choose one of the following options: + , - , * , /");
                    break;
            }

        }
    }
}