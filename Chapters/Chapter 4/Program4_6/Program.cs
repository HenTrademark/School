// Prompts the user to enter their password; then checks their password against the one in the system. If their password is correct, display ‘You have successfully logged in’. Otherwise, continues to prompt for a password.
// If the user enters an incorrect password three times, displays the message ‘Sorry you are out of tries’ and quit.

using System;

namespace Program4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The Password Program

            // Declaring variables
            const string pass = "acuywdfj";
            bool correct = false;
            // While i is over 0 or correct is false (repeats 3 times)
            for (int i = 2; i >= 0 && correct == false; i--) {
                Console.WriteLine("Please enter your password");
                string guess = Console.ReadLine();
                if (guess == pass) { // If the guess is equal to the password
                    Console.WriteLine("You have successfully logged in");
                    correct = true;
                }
                else {
                    Console.WriteLine("Password incorrect, you have {0} tries left",i);
                }
                Console.WriteLine();
            }
            if (!correct) { Console.WriteLine("Sorry, you are out of tries"); } // Says that the user is out of tries if they didn't get the password
        }
    }
}
