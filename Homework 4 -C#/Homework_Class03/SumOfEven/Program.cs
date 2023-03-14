namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = new int[6];
            int sumOfEven = 0;
            int i = 0;

            while(i < 6)
            {
                Console.WriteLine("Please enter a number.");
                bool successfulParsing = int.TryParse(Console.ReadLine(), out int number);
                if (successfulParsing)
                {
                    arrayOfInts[i] = number;
                    i++;
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
            }

            for (i = 0;  i < arrayOfInts.Length; i++)
            {
                if(arrayOfInts[i] % 2 == 0)
                {
                    sumOfEven += arrayOfInts[i];
                }
            }

            if (sumOfEven == 0)
            {
                Console.WriteLine("There are no even numbers in the array!");
            }
            else
            {
                Console.WriteLine($"The sum of the even numbers is: {sumOfEven}");
            }
            
        }
    }
}