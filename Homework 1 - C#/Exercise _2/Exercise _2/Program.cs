namespace Exercise__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 2");

            string firstName = "Frosina";
            string lastName = "Stamenkovska";

            string fullName = firstName + " " + lastName; // way 1
            string fullNameTwo = $"{firstName} {lastName}"; // way 2
            Console.WriteLine(fullName);
            Console.WriteLine(fullNameTwo);

            string firstNumber = "9";
            string secondNumber = "3";

            string concatenateStrings = firstNumber + secondNumber;
            Console.WriteLine(concatenateStrings);

        }
    }
}