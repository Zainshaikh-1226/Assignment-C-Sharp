using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int num3 = int.Parse(Console.ReadLine());

        if (num1 <= num2 && num1 <= num3)
        {
            Console.WriteLine("The smallest number is: " + num1);
        }
        else if (num2 <= num1 && num2 <= num3)
        {
            Console.WriteLine("The smallest number is: " + num2);
        }
        else
        {
            Console.WriteLine("The smallest number is: " + num3);
        }
    }
}
