using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        if (number % 5 == 0 && number % 11 == 0)
        {
            Console.WriteLine("The number is divisible by both 5 and 11.");
        }
        else
        {
            Console.WriteLine("The number is not divisible by both 5 and 11.");
        }
    }
}

