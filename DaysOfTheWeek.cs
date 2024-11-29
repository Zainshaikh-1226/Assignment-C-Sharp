using System;

class Program
{
    static void Main()
    {
        // Ask the user to input a number between 1 and 7
        Console.Write("Enter a number between 1 and 7 to get the corresponding day of the week: ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        // Display the corresponding day of the week using switch-case
        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("1: Monday");
                break;
            case 2:
                Console.WriteLine("2: Tuesday");
                break;
            case 3:
                Console.WriteLine("3: Wednesday");
                break;
            case 4:
                Console.WriteLine("4: Thursday");
                break;
            case 5:
                Console.WriteLine("5: Friday");
                break;
            case 6:
                Console.WriteLine("6: Saturday");
                break;
            case 7:
                Console.WriteLine("7: Sunday");
                break;
            default:
                Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                break;
        }
    }
}

