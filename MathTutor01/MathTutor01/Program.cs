using System;

namespace MathTutor01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a random object
            Random rand = new Random();
            int num1 = rand.Next(1, 100);
            int num2 = rand.Next(1, 100);
            // add up varaibles for correct answer
            int correctAnswer = num1 + num2;
            //prompt user to guess for the correct answer 
            int userAnswer = PromptForIntegerValue($"What is {num1} + {num2} = ? ");
            //check if user answer is correct
            if(userAnswer == correctAnswer)
            {
                //correct answer
                Console.WriteLine($"Correct! {num1} + {num2} = {correctAnswer}");
            }
            else
            {
                //incorrect answer
                Console.WriteLine($"Incorrect! The correct answer is {correctAnswer}");
            }
        }
        static int PromptForIntegerValue(string message)
        {
            int integerValue = 0;
            //prompt user with message parameter variable
            Console.Write(message);
            while(int.TryParse(Console.ReadLine(), out integerValue) == false)
            {
                //input value is not a integer
                Console.WriteLine("Invalid input, please enter a integer value for the answer.");
                Console.Write(message);
            }
            return integerValue;
        }
    }
}
