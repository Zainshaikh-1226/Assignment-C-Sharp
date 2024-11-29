using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Did you pass the driving test? (yes/no):");
        string testResult = Console.ReadLine().ToLower();

        if (age >= 18)
        {
            if (testResult == "yes")
            {
                Console.WriteLine("Congratulations! You are eligible for a driving license.");
            }
            else
            {
                Console.WriteLine("You are not eligible for a driving license due to failing the test.");
            }
        }
        else
        {
            Console.WriteLine("You are not eligible for a driving license due to age.");
        }
    }
}
