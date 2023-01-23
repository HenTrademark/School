using System;

namespace Program2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Finds the area of a triangle using Heron's theorem

            // Declaring variables
            double side1;
            double side2;
            double side3;
            double s;
            double area;
            Console.WriteLine("Welcome to the Triangle Program"); 

            // Getting the side lengths
            Console.WriteLine("Please enter the length of the first side");
            side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the length of the second side");
            side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the length of the third side");
            side3 = double.Parse(Console.ReadLine());

            // Calculating the area
            s = (side1 + side2 + side3) / 2;
            area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            Console.WriteLine();

            // Giving the user the area
            Console.WriteLine("The area of this triangle is {0}",area);
        }
    }
}
