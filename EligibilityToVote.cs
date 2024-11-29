using System;

class Program
{
    static void Main()
    {
        // Ask the user to input their age
        Console.Write("Enter your age: ");

        // Read the user input and convert it to an integer
        int age = Convert.ToInt32(Console.ReadLine());

        // Check if the user is eligible to vote
        if (age >= 18)
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote.");
        }
    }
}

