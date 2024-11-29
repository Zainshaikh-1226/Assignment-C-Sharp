using System;

class Program
{
    static void Main()
    {
        // Ask the user to input a year
        Console.Write("Enter a year: ");

        // Read the user input and convert it to an integer
        int year = Convert.ToInt32(Console.ReadLine());

        // Check if the year is a leap year
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine(year + " is a leap year.");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year.");
        }
    }
}

