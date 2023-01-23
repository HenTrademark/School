// This program will output the times table for whatever number the user inputs (up to 12 ×)

using System;

namespace Program4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Times Table
            Console.WriteLine("Which Times Table do you want to learn?");
            int tt = int.Parse(Console.ReadLine()); // Asks the user what times table to do
            for (int i = 1; i <= 12; i++) { // Does the times tables for these
                Console.WriteLine("{0} * {1} = {2}",i,tt,i*tt);
            }
        }
    }
}
