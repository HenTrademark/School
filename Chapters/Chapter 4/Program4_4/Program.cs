// This program asks the user a question, checks the answer and outputs a statement that says how many tries the user took to get the answer right. 

using System;

namespace Program4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The Question Program

            // Declaring the variables
            bool correct = false;
            int count = 0;

            // While correct is false, ask what 2 + 2 is
            while (correct == false) {
                Console.WriteLine("What is 2 + 2?");
                int ans = int.Parse(Console.ReadLine());
                if (ans == 4)
                { // If correct, set it to true
                    correct = true;
                }
                else { // If not, say wrong try again
                    Console.WriteLine("Wrong... Try again!");
                }
                count++; // Increments count
            }
            Console.WriteLine("Well done! You got that in {0} tries",count);
        }
    }
}
