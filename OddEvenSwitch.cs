using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int number = int.Parse(Console.ReadLine());

        switch (number % 2)
        {
            case 0:
                Console.WriteLine("The number is even.");
                break;
            case 1:
                Console.WriteLine("The number is odd.");
                break;
        }
    }
}
