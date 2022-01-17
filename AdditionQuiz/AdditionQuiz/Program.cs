using System;

namespace AdditionQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int minnumber = 1;
            const int maxnumber = 9;
            Random rand = new Random();
            int number1 = rand.Next(minnumber, maxnumber + 1);
            int number2 = rand.Next(minnumber, maxnumber + 1);
            int correctAnswer = number1 + number2; ;
            Console.Write($"What is {number1} + {number2} = ? ");
            int userAnswer = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number1} + {number2} = {userAnswer} is {userAnswer == correctAnswer}");
        }
    }
}
