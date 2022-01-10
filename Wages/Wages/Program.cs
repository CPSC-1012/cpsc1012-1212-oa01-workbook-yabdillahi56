using System;

namespace Wages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double regularWages;
            double basePay = 25;
            double regularHours = 40;
            double overtimeWages;
            double overtimePay = 37.5;
            double overtimeHours = 10;
            double totalWages;

            regularWages = basePay * regularHours;
            overtimeWages = overtimePay * overtimeHours;
            totalWages = regularWages + overtimeWages;
            Console.WriteLine($"Wages for this week are {totalWages:c}");
        }
    }
}
