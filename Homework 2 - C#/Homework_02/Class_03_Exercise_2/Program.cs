namespace Class_03_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number!");
            string input1 = Console.ReadLine();
            if (!int.TryParse(input1, out int number1))
            {
                Console.WriteLine("Invalid input, please enter a valid number");
                return;
            }

            Console.WriteLine($"Even numbers from 2 to {number1}:");
            if (number1 < 0)
            {
                for (int i = 2; i >= number1; i--)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }  
            }
            else
            {
                for (int i = 2; i <= number1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.WriteLine("Enter the second number!");
            string input2 = Console.ReadLine();
            if (!int.TryParse(input2, out int number2))
            {
                Console.WriteLine("Invalid input, please enter a valid number");
                return;
            }

            Console.WriteLine($"Odd numbers from 1 to {number2}:");
            if (number2 < 0)
            {
                for (int i = 1; i >= number2; i--)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                for (int i = 1; i <= number2; i++)
                {
                    if(i % 2 != 0) 
                    {
                        Console.WriteLine(i);
                    }
                }
            }

                


        }
    }
}