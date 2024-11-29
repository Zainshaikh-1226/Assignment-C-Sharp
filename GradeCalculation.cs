using System;

class Program
{
    static void Main()
    {
        // Ask the user to input marks for each subject
        Console.Write("Enter marks for English: ");
        int english = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Urdu: ");
        int urdu = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Maths: ");
        int maths = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Science: ");
        int science = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Islamiat: ");
        int islamiat = Convert.ToInt32(Console.ReadLine());

        // Calculate the total marks and average marks
        int totalMarks = english + urdu + maths + science + islamiat;
        double averageMarks = totalMarks / 5.0;  // Average marks for all subjects

        // Display the total and average marks
        Console.WriteLine("\nTotal Marks: " + totalMarks);
        Console.WriteLine("Average Marks: " + averageMarks);

        // Assign grade based on average marks
        if (averageMarks >= 90)
        {
            Console.WriteLine("Your grade is A.");
        }
        else if (averageMarks >= 80)
        {
            Console.WriteLine("Your grade is B.");
        }
        else if (averageMarks >= 70)
        {
            Console.WriteLine("Your grade is C.");
        }
        else if (averageMarks >= 60)
        {
            Console.WriteLine("Your grade is D.");
        }
        else
        {
            Console.WriteLine("Your grade is F.");
        }
    }
}

