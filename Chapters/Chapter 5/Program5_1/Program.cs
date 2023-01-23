// This program inputs and stores football club names in an array of five elements and then outputs the contents of the array to the screen.

using System;

namespace Program5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of strings with length 5
            string[] clubs = new string[5];
            for (int i = 0; i < 5; i++)
            { // Repeats 5 times, asks for a football club
                Console.WriteLine("Enter a football club");
                clubs[i] = Console.ReadLine();
            }
            Console.Write("\nThese are the clubs you entered: | ");
            for (int i = 0; i < clubs.Length; i++)
            { // For each one, types what they are 
                Console.Write("{0} | ",clubs[i]);
            }
        }
    }
}
