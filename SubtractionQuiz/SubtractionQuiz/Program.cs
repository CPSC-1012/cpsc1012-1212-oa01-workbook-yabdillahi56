using System;

namespace SubtractionQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number1 = rand.Next(1, 10);
            int number2 = rand.Next(1, 10);
            if(number1 < number2)
            {
                int temp = number1;
                number1 = number2;
                number2 = temp;
            }
            
        }
    }
}
