// This program displays a conversion table for pounds to kilograms, ranging from 1 pound to 20 pounds [1 pound = 0.4536 kg].

using System;

namespace Program4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Weight conversion
            const float conv = 0.4536f; // Sets constant for the conversion
            // Outputs the top of the table
            Console.WriteLine("Conversion: Pounds to Kilograms");
            Console.WriteLine("_______________________________");
            Console.WriteLine("Pounds       |        Kilograms");
            Console.WriteLine("_______________________________");
            for (float i = 0; i < 10; i++) { // While i is a single digit it adds a space
                Console.WriteLine("   {0}                  {1}", i, i * conv);
            }                                // While i is a double digit it has one less space than the others
            for (float i = 10; i <= 20; i++) {
                Console.WriteLine("   {0}                 {1}", i, i * conv);
            }
        }
    }
}
