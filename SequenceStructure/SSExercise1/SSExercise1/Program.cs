/* EXCECISE 1: Ask the user for their name, age, expected annual salary and display that to the user
 * Date created: 2022-01-13
 */

using System;

namespace SSExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name;
            int age;
            double annualPay;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            String ageInputString = Console.ReadLine();
            age = int.Parse(ageInputString);

            Console.Write("Enter your annual salary: ");
            String salaryInputString = Console.ReadLine();
            annualPay = int.Parse(salaryInputString);

            Console.WriteLine($"My name is {name}, my age is {age} and I hope to earn {annualPay:c} per year");
        }
    }
}
