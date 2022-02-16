using System;

namespace MathTutor02
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
            //loop each time if user wants to try again to answer correctly
            bool tryagain = false;
            int numOfAttempts = 0;
            do
            {
                numOfAttempts ++;
                //prompt user to guess for the correct answer 
                int userAnswer = PromptForIntegerValue($"What is {num1} + {num2} = ? ");
                //check if user answer is correct
                if (userAnswer == correctAnswer)
                {
                    //correct answer
                    Console.WriteLine($"Correct! {num1} + {num2} = {correctAnswer}. You got the correct answer in {numOfAttempts} attempts.");
                    tryagain = false;
                }
                else
                {
                    //incorrect answer
                    Console.Write($"Incorrect! Would you like to try again (y/n): ");
                    string tryagainString = Console.ReadLine();
                    tryagainString = tryagainString.ToLower();
                    if(tryagainString == "y")
                    {
                        tryagain = true;
                    }
                    else
                    {
                        Console.WriteLine($"The correct answer is {correctAnswer}. You had taken {numOfAttempts} attempts.");
                        tryagain = false;
                    }
                }
            } while (tryagain == true);
        }
        static int PromptForIntegerValue(string message)
        {
            int integerValue = 0;
            //prompt user with message parameter variable
            Console.Write(message);
            while (int.TryParse(Console.ReadLine(), out integerValue) == false)
            {
                //input value is not a integer
                Console.WriteLine("Invalid input, please enter a integer value for the answer.");
                Console.Write(message);
            }
            return integerValue;
        }
    }
}
