using System;

namespace Program3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring the variables
            string CorrectUser = "kgrid34";
            string CorrectPass = "KG7&56@";
            string GuessUser;
            string GuessPass;

            Console.WriteLine("Welcome to the login system");
            Console.WriteLine();

            // Login System
            Console.WriteLine("Please enter your Username");
            GuessUser = Console.ReadLine().ToLower(); 
            // .ToLower() makes it all lowercase, meaning it is case-insensitive
            Console.WriteLine("Please enter your Password");
            GuessPass = Console.ReadLine();
            Console.WriteLine();

            // Validation
            if (GuessUser == CorrectUser && GuessPass == CorrectPass)
            {
                Console.WriteLine("You are logged in");
            }
            else
            {
                Console.WriteLine("The username or password is incorrect - Log-in failed");
            }
        }
    }
}
