using System;

namespace Garden2 {
    internal class Program {
        static void Main(string[] args) {
            int tpm, length, width;
            Console.Write("Enter length of garden: ");
            length = int.Parse(Console.ReadLine());
            Console.Write("Enter width of garden: ");
            width = int.Parse(Console.ReadLine());
            Console.Write("Enter the cost of turf per square metre: £");
            tpm = int.Parse(Console.ReadLine());

            int price = (length - 2) * (width - 2) * tpm;
            Console.WriteLine("\nThe price of turfing this garden is £{0}",price);
        }
    }
}
