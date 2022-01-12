using System;

namespace SalesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the variables for the price, tax and total.
            double price,
                tax,
                total;
            // Assign values to variables
            Console.Write("What is the price?: ");
            String pricestring = Console.ReadLine();
            price = int.Parse(pricestring);
            tax = price * 0.05;
            total = price + tax;
            // Write to the screen the price, tax, and total.
            Console.WriteLine($"The price of the item is {price:C}");
            Console.WriteLine($"The tax is {tax:C}");
            Console.WriteLine($"The tax is {total:C}");
        }
    }
}
