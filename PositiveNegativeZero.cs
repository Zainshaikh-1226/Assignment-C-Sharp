using System;

class Program
{
    static void Main()
    {
        // Ask the user to input a number
        Console.Write("Enter a number: ");

        // Read the user input and convert it to an integer
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is positive, negative, or zero
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}

