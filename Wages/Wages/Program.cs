/*  Purpose:    Get the user's total wage.
 *  Input:      base pay, regular hours, overtime pay, and overtime hours
 *  Outputs:    wage total
 *  Algorithm:  Step 1: Ask the user for the base pay, regular hours, overtime pay, and overtime hours, then read the user's input
 *              Step 2: Caclulate the wage total using the formula:
 *                      regularWages = basePay * regularHours;
                        overtimeWages = overtimePay * overtimeHours;
                        totalWages = regularWages + overtimeWages;
 *              Step 3: Display the computed total wage to the screen.
 *  Last modified:  2022-01-12
 */
using System;

namespace Wages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask the user for input and set variables based on user input
            Console.Write("What is the base pay: ");
            string theuserinputstring = Console.ReadLine();
            double basePay = double.Parse(theuserinputstring);

            Console.Write("What are the regular hours: ");
            theuserinputstring = Console.ReadLine();
            double regularHours = double.Parse(theuserinputstring);

            Console.Write("What is the overtime pay: ");
            theuserinputstring = Console.ReadLine();
            double overtimePay = double.Parse(theuserinputstring);

            Console.Write("What are the overtime hours: ");
            theuserinputstring = Console.ReadLine();
            double overtimeHours = double.Parse(theuserinputstring);

            //do the calculation
            double regularWages, overtimeWages, totalWages;
            regularWages = basePay * regularHours;
            overtimeWages = overtimePay * overtimeHours;
            totalWages = regularWages + overtimeWages;
            Console.WriteLine($"Wages for this week are {totalWages:c}");
        }
    }
}
