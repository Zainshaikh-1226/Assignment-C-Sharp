using System;

class Program
{
    static void Main()
    {
        // Ask the user to input the first integer
        Console.Write("Enter the first integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        // Ask the user to input the second integer
        Console.Write("Enter the second integer: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Compare the two integers and print the greater one
        if (num1 > num2)
        {
            Console.WriteLine("The greater number is: " + num1);
        }
        else if (num2 > num1)
        {
            Console.WriteLine("The greater number is: " + num2);
        }
        else
        {
            Console.WriteLine("Both numbers are equal.");
        }
    }
}
