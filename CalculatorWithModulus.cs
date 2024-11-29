using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the operation (+, -, *, /, %):");
        char operation = char.Parse(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.WriteLine("Result: " + (num1 + num2));
                break;
            case '-':
                Console.WriteLine("Result: " + (num1 - num2));
                break;
            case '*':
                Console.WriteLine("Result: " + (num1 * num2));
                break;
            case '/':
                Console.WriteLine("Result: " + (num1 / num2));
                break;
            case '%':
                Console.WriteLine("Result: " + (num1 % num2));
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }
    }
}
