/* EXCECISE 3: Calculate the area of a hexagon.
 * Date created: 2022-01-13
 */
using System;

namespace SSExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sidelength;
            double hexagonarea;
            String numberstring;

            Console.WriteLine("Enter the length of the side:");
            numberstring = Console.ReadLine();
            sidelength = double.Parse(numberstring);

            hexagonarea = ((3 * Math.Sqrt(3)) / 2) * (Math.Pow(sidelength, 2));
            Console.WriteLine($"The area of the hexagon is {hexagonarea}");
        }
    }
}
