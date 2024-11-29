using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your weight in kilograms:");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter your height in meters:");
        double height = double.Parse(Console.ReadLine());

        double bmi = weight / (height * height);

        if (bmi < 18.5)
        {
            Console.WriteLine("You are underweight.");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("Your BMI is normal.");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("You are overweight.");
        }
        else
        {
            Console.WriteLine("You are obese.");
        }
    }
}
