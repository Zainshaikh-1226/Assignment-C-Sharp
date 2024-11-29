using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of units consumed:");
        int units = int.Parse(Console.ReadLine());

        double billAmount = 0;
        double surcharge = 0;
        double totalAmount = 0;

        if (units <= 100)
        {
            billAmount = units * 5; // 5 PKR per unit for the first 100 units
        }
        else if (units <= 200)
        {
            billAmount = 100 * 5 + (units - 100) * 7; // 7 PKR per unit for 101-200
        }
        else if (units <= 300)
        {
            billAmount = 100 * 5 + 100 * 7 + (units - 200) * 10; // 10 PKR per unit for 201-300
        }
        else
        {
            billAmount = 100 * 5 + 100 * 7 + 100 * 10 + (units - 300) * 12; // 12 PKR per unit for above 300
        }

        // Apply surcharge if the bill is over a certain amount (e.g., 1000 PKR)
        if (billAmount > 1000)
        {
            surcharge = billAmount * 0.10; // 10% surcharge for bills above 1000 PKR
        }

        totalAmount = billAmount + surcharge;

        // Display the results in PKR
        Console.WriteLine($"Bill Breakdown:");
        Console.WriteLine($"Basic Bill Amount: {billAmount} PKR");
        if (surcharge > 0)
        {
            Console.WriteLine($"Surcharge (10%): {surcharge} PKR");
        }
        Console.WriteLine($"Total Bill Amount (with surcharge if any): {totalAmount} PKR");
    }
}
