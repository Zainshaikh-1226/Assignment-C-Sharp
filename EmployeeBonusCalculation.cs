using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of years of service:");
        int yearsOfService = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your salary:");
        double salary = double.Parse(Console.ReadLine());

        double bonus;

        if (yearsOfService >= 5)
        {
            bonus = salary * 0.10;
        }
        else
        {
            bonus = salary * 0.05;
        }

        Console.WriteLine("The bonus is: " + bonus);
    }
}
