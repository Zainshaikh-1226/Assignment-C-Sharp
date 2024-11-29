using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a character:");
        char ch = char.Parse(Console.ReadLine());

        if (ch >= 'A' && ch <= 'Z')
        {
            Console.WriteLine("The character is uppercase.");
        }
        else if (ch >= 'a' && ch <= 'z')
        {
            Console.WriteLine("The character is lowercase.");
        }
        else if (ch >= '0' && ch <= '9')
        {
            Console.WriteLine("The character is a digit.");
        }
        else
        {
            Console.WriteLine("The character is a special character.");
        }
    }
}
