using System;

namespace Program2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Adds 2 numbers together

            // Declaring variables
            string name;
            double num1;
            double num2;
            double total;
            Console.WriteLine("Hello and welcome to the number calculator - what is your name??");
            name = Console.ReadLine(); // Asks for the name and stores in "name"
            Console.WriteLine("Please enter your first number, {0}", name);
            num1 = double.Parse(Console.ReadLine()); // Asks for the number
            Console.WriteLine("Please enter your second number, {0}", name);
            num2 = double.Parse(Console.ReadLine());
            total = num1 + num2; // Adds them together and says the total
            Console.WriteLine("Thank you {0}, your answer is {1}", name, total);
        }
    }
}
