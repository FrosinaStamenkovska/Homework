namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[5] {"Zdravko", "Petko", "Stanko", "Branko", "Trajko"};
            string[] studentsG2 = new string[5] {"Frosina", "Ana", "Marko", "Martin", "Christos" };

            Console.WriteLine("Enter student group: ( there are 1 and 2 )");
            switch (Console.ReadLine()) // in this case there is no need of parsing the numbers
            {
                case "1":
                    Console.WriteLine("Students in G1:");
                    foreach (string student  in studentsG1)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                 case "2":
                    Console.WriteLine("Students in G2:");
                    foreach(string student in studentsG2)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                 default: Console.WriteLine("There is not such a group, you need to choose either 1 or 2!");
                    break;
                    
            }
        }
    }
}