/*  Purpose:    Get the total of an item using the user inputed price and tax.
 *  Input:      price in dollars and cents
 *  Outputs:    sales total
 *  Algorithm:  Step 1: Ask the user for the sale price, then read the user's input
 *              Step 2: Caclulate the sales total using the formula:
 *                      total = price + tax;
 *                      where tax = price * 0.05
 *              Step 3: Display the computed total of the item to the screen.
 *  Last modified:  2022-01-12
 */
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
