using System;

namespace HeightConvert2 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter a height (Enter like \"feet,inches\"): ");
            string ftin = Console.ReadLine();
            string[] height = ftin.Split(',');
            Console.Write("Enter a weight (Enter like \"stone,pounds\"): ");
            string stlb = Console.ReadLine();
            string[] weight = stlb.Split(',');
            double inches = int.Parse(height[0]) * 12 + int.Parse(height[1]);
            double pounds = int.Parse(weight[0]) * 14 + int.Parse(weight[1]);

            Console.WriteLine();
            Console.WriteLine("{0}in in centimetres is: {1}cm",inches,Math.Round(inches * 2.54,2));
            Console.WriteLine("{0}lbs in kilograms is: {1}kg",pounds,Math.Round(pounds / 2.20462,2));
        }
    }
}
