namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {   // The inputs are not parsed because there are no math operations
            // and the application can be used for swapping any other characters as well.
            Console.WriteLine("Enter the first number!");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the second number!");
            string input2 = Console.ReadLine();
            Console.WriteLine($"Before swapping, first number: {input1}, second number: {input2}");

            string storeInput1Value = input1;
            input1 = input2;
            input2 = storeInput1Value;

            Console.WriteLine($"After swapping, first number: {input1}, second number: {input2}");
        }
    }
}