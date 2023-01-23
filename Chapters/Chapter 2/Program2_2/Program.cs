using System;

namespace Program2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculates the volume and surface area of a cylinder

            // Declaring variables
            const double pi = Math.PI;
            double radius;
            double height;
            double volume;
            double SA;
            Console.WriteLine("Welcome to the cylinder program");
            Console.WriteLine("Please enter the radius of the cylinder");
            radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height of the cylinder");
            height = double.Parse(Console.ReadLine());
            volume = radius * radius * pi * height; /* Calculates the volume
            Calculates the surface area. First part is the 2 circles
            Second is the middle section (circumference * height)    */
            SA = 2 * (pi * radius * radius) + (height * pi * 2 * radius);
            Console.WriteLine("The volume of your cylinder is {0}", volume);
            Console.WriteLine("The surface area of your cylinder is {0}", SA);
        }
    }
}
