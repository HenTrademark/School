using System;

namespace Program3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring the variables
            double num1;
            double num2;
            double num3;
            Console.WriteLine("This program tells you the biggest number out of 3 numbers that you input");
            Console.WriteLine();

            // Getting the variables from the user
            Console.WriteLine("Enter your first number");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your third number");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            // Selection statements
            if (num1 >= num2 && num1 >= num3) // If num1 is the biggest
            {
                Console.WriteLine("The biggest number is {0}", num1);
            }
            else if (num2 >= num1 && num2 >= num3) // If num2 is the biggest
            {
                Console.WriteLine("The biggest number is {0}", num2);
            }
            else if (num3 >= num1 && num3 >= num2) // If num3 is the biggest
            {
                Console.WriteLine("The biggest number is {0}", num3);
            }
        }
    }
}
