namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 4");

            int n = 102;
            int m = 5;

            int result = n / m;
            int moneyLeft = n % m;
            Console.WriteLine($"You can send {result} messages and you will have {moneyLeft} credits left!");
        }
    }
}