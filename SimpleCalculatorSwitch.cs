using System;

class Program
{
    static void Main()
    {
        // Ask the user to input the first number
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Ask the user to input the second number
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Ask the user to choose an operation
        Console.WriteLine("Choose an operation: ");
        Console.WriteLine("1. Add (+)");
        Console.WriteLine("2. Subtract (-)");
        Console.WriteLine("3. Multiply (*)");
        Console.WriteLine("4. Divide (/)");

        // Read the user's choice
        Console.Write("Enter the operation number (1/2/3/4): ");
        int operation = Convert.ToInt32(Console.ReadLine());

        // Declare a variable to store the result
        double result = 0;

        // Perform the operation using a switch-case
        switch (operation)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine("The result of {0} + {1} = {2}", num1, num2, result);
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine("The result of {0} - {1} = {2}", num1, num2, result);
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine("The result of {0} * {1} = {2}", num1, num2, result);
                break;
            case 4:
                // Handle division by zero
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("The result of {0} / {1} = {2}", num1, num2, result);
                }
                break;
            default:
                Console.WriteLine("Invalid operation. Please choose a number between 1 and 4.");
                break;
        }
    }
}

