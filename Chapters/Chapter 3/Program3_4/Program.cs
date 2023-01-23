using System;

namespace Program3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring the variable
            int score;
            Console.WriteLine("Welcome to the grade calculator!");
            Console.WriteLine();

            // Gets the score from the user
            Console.WriteLine("Please type your score");
            score = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Score calculator
            if (score >= 80) // If score is over 80
            {
                Console.WriteLine("You got a grade A");
            }
            else if (score >= 70) // Knowing that score is under 80, if score is over 70
            {
                Console.WriteLine("You got a grade B");
            }
            else if (score >= 55) // Knowing that score is under 70, if score is over 55
            {
                Console.WriteLine("You got a grade C");
            }
            else if (score >= 45) // Knowing that score is under 55, if score is over 45
            {
                Console.WriteLine("You got a grade D");
            }
            else if (score >= 30) // Knowing that score is under 45, if score is over 30
            {
                Console.WriteLine("You got a grade E");
            }
            else // Anything under 30
            {
                Console.WriteLine("You got a grade F");
            }
        }
    }
}
