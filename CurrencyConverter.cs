using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the amount:");
        double amount = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the currency to convert from (USD, EUR, GBP, PKR, INR):");
        string fromCurrency = Console.ReadLine().ToUpper();

        Console.WriteLine("Enter the currency to convert to (USD, EUR, GBP, PKR, INR):");
        string toCurrency = Console.ReadLine().ToUpper();

        double convertedAmount = 0;

        switch (fromCurrency)
        {
            case "USD":
                if (toCurrency == "EUR")
                    convertedAmount = amount * 0.92;
                else if (toCurrency == "GBP")
                    convertedAmount = amount * 0.76;
                else if (toCurrency == "PKR")
                    convertedAmount = amount * 283.50;
                else if (toCurrency == "INR")
                    convertedAmount = amount * 83.10;
                else
                    convertedAmount = amount;
                break;

            case "EUR":
                if (toCurrency == "USD")
                    convertedAmount = amount * 1.09;
                else if (toCurrency == "GBP")
                    convertedAmount = amount * 0.90;
                else if (toCurrency == "PKR")
                    convertedAmount = amount * 307.50;
                else if (toCurrency == "INR")
                    convertedAmount = amount * 90.40;
                else
                    convertedAmount = amount;
                break;

            case "GBP":
                if (toCurrency == "USD")
                    convertedAmount = amount * 1.32;
                else if (toCurrency == "EUR")
                    convertedAmount = amount * 1.11;
                else if (toCurrency == "PKR")
                    convertedAmount = amount * 372.50;
                else if (toCurrency == "INR")
                    convertedAmount = amount * 101.70;
                else
                    convertedAmount = amount;
                break;

            case "PKR":
                if (toCurrency == "USD")
                    convertedAmount = amount * 0.0035;
                else if (toCurrency == "EUR")
                    convertedAmount = amount * 0.0032;
                else if (toCurrency == "GBP")
                    convertedAmount = amount * 0.0027;
                else if (toCurrency == "INR")
                    convertedAmount = amount * 0.23;
                else
                    convertedAmount = amount;
                break;

            case "INR":
                if (toCurrency == "USD")
                    convertedAmount = amount * 0.012;
                else if (toCurrency == "EUR")
                    convertedAmount = amount * 0.011;
                else if (toCurrency == "GBP")
                    convertedAmount = amount * 0.0098;
                else if (toCurrency == "PKR")
                    convertedAmount = amount * 4.34;
                else
                    convertedAmount = amount;
                break;

            default:
                Console.WriteLine("Invalid currency.");
                return;
        }

        Console.WriteLine($"Converted amount: {convertedAmount} {toCurrency}");
    }
}
