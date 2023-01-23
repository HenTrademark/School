using System;

namespace Program4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Multiplication questions

            // Declaring variables 
            Random rnd = new Random();
            int first, second, ans, score = 0;
            // Asks whether the user wants to be tested
            Console.WriteLine("Are you ready to be tested? (true/false):");
            string sel = Console.ReadLine().ToLower();
            Console.WriteLine(); // Depending on what the user says, it'll start the game or not
            if (sel == "false") { Console.WriteLine("Oh, okay. Sorry you didn't want to play"); }
            else if (sel == "true") { 
                for (int i = 0; i < 10; i++) { // Repeats 10 times
                    first = rnd.Next(1, 13);  // Makes these numbers a random integer from 1 to 12
                    second = rnd.Next(1, 13); // (1 <= rnd < 13)
                    Console.WriteLine("What is the answer to {0} * {1}?", first, second);
                    ans = int.Parse(Console.ReadLine()); // Asks the user for the answer to the numbers multiplied
                    if (ans == first * second) {
                        Console.WriteLine("Well done! you got the question correct");
                        score++; // If correct, it'll print the above and tell the user the current score
                        Console.WriteLine("Your score is now {0}",score);
                    }
                    else { // If not correct, it'll print the below and tell the user the correct answer
                        Console.WriteLine("Sorry, that's the wrong answer.");
                        Console.WriteLine("{0} * {1} = {2}", first, second, first * second);
                    }
                    Console.WriteLine();
                } // At the end of the test, the user will get their final score
                Console.WriteLine("That's the end of the test, your final score is {0}",score);
            }
            else { Console.WriteLine("Not a valid option."); }
            
        }
    }
}
