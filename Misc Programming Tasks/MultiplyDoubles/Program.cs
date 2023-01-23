using System;

namespace MultiplyDoubles {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter number 1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} = {2}",num1,num2,Math.Round(num1*num2,2));
        }
    }
}
