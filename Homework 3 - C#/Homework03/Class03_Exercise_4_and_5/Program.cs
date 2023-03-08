namespace Class03_Exercise_4_and_5
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Exercise 4:

            // Array With words
            string[] words = new string[5] {"This", "array", "has", "five", "words"};

            // Array With decimal values
            decimal[] decimals = new decimal[5] { 2.55m, 3.22m, 8.6m, 11.5m, 7.33m };

            // Array With characters from keyboard
            char[] characters = new char[5] { '1', '2', '3', '4', '5' };

            // Array With true / false values
            bool[] boolArray = new bool[5] { true, false, true, false, true };

            // Array With arrays, each holding 2 whole numbers
            int[,] arrayOfArrays = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            //Exercise 5:

            int[] arrayOfNumbers = new int[5];
            
            int result = 0;
            int i = 0;
            

            while (i < 5)
            {
                Console.WriteLine("Please enter a number.");
                bool sucessfullParsing = int.TryParse(Console.ReadLine(), out int number);
                if (sucessfullParsing)
                {
                    arrayOfNumbers[i] = number;
                    i++;
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
            }

            Console.Write("The values of the elements of the array:");
            foreach (int number in arrayOfNumbers)
            {
                result += number;
                Console.Write($" {number} ");
            }

            Console.WriteLine();
            Console.WriteLine($"The sum of the values is: {result}");

           


        }
    }
}