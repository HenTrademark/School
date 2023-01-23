using System;

namespace HeightConvert {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter a height (in inches): ");
            double inches = double.Parse(Console.ReadLine());
            Console.Write("Enter a weight (in stones): ");
            double stones = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0}in in centimetres is: {1}cm",inches,Math.Round(inches * 2.54,2));
            Console.WriteLine("{0}st in kilograms is: {1}kg",stones,Math.Round(stones * 6.35029,5));
        }
    }
}
