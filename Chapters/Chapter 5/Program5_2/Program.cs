using System;

namespace Program5_2
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
                Console.Write("{0} | ", clubs[i]);
            }
            Array.Sort(clubs); // Sorts the array by alphabetical order
            Console.WriteLine("\n");

            // Search for a club

            // Asks for a team
            Console.Write("Enter a football club: ");
            string team = Console.ReadLine();
            Console.WriteLine();
            /* Array.BinarySearch(array, item) returns an integer
               The index of the item if it is in the array
               And a negative number if not in there   */ 
            int index = Array.BinarySearch(clubs, team);
            if (index < 0)
            { // If less than 0, the team isn't there  
                Console.WriteLine("That club is NOT on the list.");
            }
            else
            { // If 0 or more, the team is there
                Console.WriteLine("That club is on the list (Number {0} on the list)",index + 1);
            }

        }
    }
}
