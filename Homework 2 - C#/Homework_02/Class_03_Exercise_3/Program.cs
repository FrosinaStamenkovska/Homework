namespace Class_03_Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string input1 = Console.ReadLine();
            if (!int.TryParse(input1, out int number1))
            {
                Console.WriteLine("Invalid input, please enter a valid number");
                return;
            }

            if(number1 < 1)
            {
                Console.WriteLine("Please enter a positive number!");
                return;
            }

            int printingCounter = 0;
            
            for (int i = 1; i <= number1; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                    printingCounter++;
                    
                    if (printingCounter == 100)
                    {
                        Console.WriteLine("The limit is reached!");
                        break;
                    }
                }
            }

            



        }
    }
}
