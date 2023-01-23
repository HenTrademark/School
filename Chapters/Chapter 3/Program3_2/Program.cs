using System;

namespace Program3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring the variable
            int number;
            Console.WriteLine("This program tells you whether a given integer is odd or even");
            Console.WriteLine();

            // Getting the number from the user
            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            /*  Checking whether the number is even
                MOD (%) divides a number and gives the remainder.
                If the remainder of a division of 2 is 1, the number is odd     */
            if (number % 2 == 1)
            {
                Console.WriteLine("The number \"{0}\" is odd", number);
            }
            else 
            {
                Console.WriteLine("The number \"{0}\" is even", number);
            }

        }
    }
}
