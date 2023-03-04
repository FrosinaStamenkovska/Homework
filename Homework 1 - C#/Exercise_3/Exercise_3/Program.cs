namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 3");

            string firstVarString = "6";
            int secondVarInteger = 8;

            // concatenating string and integer
            string firstResult = firstVarString + secondVarInteger;
            Console.WriteLine(firstResult);

            //  parsing the string into integer
            int secondResult = Int16.Parse(firstVarString) + secondVarInteger;
            Console.WriteLine(secondResult);
        }
    }
}