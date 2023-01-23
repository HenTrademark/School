using System;

namespace TemperatureConvert {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter temperature in Fahrenheit: ");
            double F = double.Parse(Console.ReadLine());
            double C = (F - 32) * 5f / 9f;
            Console.WriteLine("{0}F in Celcius is: {1}C",F,Math.Round(C,2));
        }
    }
}
