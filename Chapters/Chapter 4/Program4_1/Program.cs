using System;

namespace Program4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ordering numbers
            Console.WriteLine("2 options:\n 1. 1 - 99\n 2. 100 - 2");
            Console.WriteLine("\nWhich will it be?");
            // Selection for the top
            int sel = int.Parse(Console.ReadLine());
            Console.WriteLine();
            // Checks the selection
            if (sel == 1)
            { // If 1, does the odd numbers from 1 to 99
                Console.WriteLine("This is a repeating program for odd numbers");
                for (int i = 1; i < 100; i += 2)
                {
                    Console.WriteLine("This number is {0}", i);
                }
            }
            else if (sel == 2) { // If 2, does the even numbers from 100 - 2
                Console.WriteLine("This is a repeating program for even numbers");
                for (int i = 100; i > 0; i -= 2) {
                    Console.WriteLine("This number is {0}",i);
                }
            }
            else { Console.WriteLine("Not a valid option"); } // If another thing, says it's an invalid value
        }
    }
}
