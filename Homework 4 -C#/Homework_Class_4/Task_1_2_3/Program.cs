namespace Task_1_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK - 1: Take one string from the input and print its last 5 characters.
            Console.WriteLine("Let's write some word! :)");
            string someWord = Console.ReadLine();

            if(someWord.Length == 0) 
            {
                Console.WriteLine("You haven't write any word!");
            } else if(someWord.Length < 5) 
            {
                Console.WriteLine($"The word \"{someWord}\" has less than 5 characters");
            }
            else
            {
                Console.WriteLine($"Last 5 characters of the word \"{someWord}\": {someWord.Substring(someWord.Length - 5)}");
            }
            

            // TASK - 2: Take a sentence as input and print its words.
            Console.WriteLine("Let's write a sentence");
            string sentence = Console.ReadLine();
            string[] wordsOfTheSentence = sentence.Split(" ");

            if (sentence.Length > 0)
            {   // Way 1 All words from the array are printed in new line
                Console.WriteLine("The words from the sentence:");
                foreach(string word in wordsOfTheSentence)
                {
                    Console.WriteLine(word);
                }
                // Way 2 All words from the array are printed in one line
                string printedWords = string.Join(", ", wordsOfTheSentence);
                Console.WriteLine($"Words from the sentence in one line: {printedWords}.");
            }
            else
            {
                Console.WriteLine("You haven't write any sentence!");
            }

            // ***Bonus*** Take a sentence as input and print its largest word.
            // I will use the sentence from Task 2

            string largestWord = "";

            if(wordsOfTheSentence.Length > 1) 
            {
                for (int i = 0; i < wordsOfTheSentence.Length; i++)
                {
                    if(largestWord.Length < wordsOfTheSentence[i].Length)
                    {
                        largestWord = wordsOfTheSentence[i];
                    }
                }
                Console.WriteLine($"The largest word of the sentence is the word: \"{largestWord}\". ");
            } else if(wordsOfTheSentence.Length == 1 && wordsOfTheSentence[0] != "")
            {
                Console.WriteLine($"The word \"{wordsOfTheSentence[0]}\" is the only word in the sentence. ");
            }
            else
            {
                Console.WriteLine("Cannot get the largest word because you haven't inserted any word!");
            }

            // TASK - 3 Create a function that takes a number as input.
            // This method should return the sum of the digits in the number.
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("You have entered an invalid number!");
                return;
            }

            // creating an array of characters from the string input:
            char[] arrayOfDigits = input.ToCharArray();

            // calling the method SumOfDigits and passing the arrayOfDigits as an argument:
            Console.WriteLine($"The sum of the digits of the number {input} is: {SumOfDigits(arrayOfDigits)}"); 

            // a method that returns Sum of the digits:
            static int SumOfDigits(char[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    int.TryParse(array[i].ToString(), out int parsedDigit);

                    sum += parsedDigit;
                }
                return sum;
            }
        }




    }
}