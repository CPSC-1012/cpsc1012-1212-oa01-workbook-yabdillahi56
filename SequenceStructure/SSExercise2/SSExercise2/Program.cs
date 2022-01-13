/* EXCECISE 2: Calculate the area and volume by reading the radius and length of an cylinder
 * Date created: 2022-01-13
 */
using System;

namespace SSExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area;
            double radius;
            double pi = 3.14;
            double volume;
            double length;
            String numberstring;

            Console.WriteLine("Enter the radius and length of a cylinder: ");

            numberstring = Console.ReadLine();
            radius = double.Parse(numberstring);

            numberstring = Console.ReadLine();
            length = double.Parse(numberstring);

            area = radius * radius * pi;
            volume = area * length;

            Console.WriteLine($"The area is {area}");
            Console.WriteLine($"The volume is {volume}");
        }
    }
}
