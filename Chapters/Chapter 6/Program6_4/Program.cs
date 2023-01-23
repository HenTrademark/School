using System;
using System.Text.RegularExpressions;

namespace Program6_4 {
    internal class Program {
        static void Main(string[] args) {
            string Binary = InputBin();
            Console.WriteLine(Binary);
        }
        static string InputBin() {
            Regex rx = new Regex("^[0|1]{8}$");
            bool valid = false;
            string bin = "";
            while (!valid) {
                Console.Write("Input 8-bit Binary number: ");
                bin = Console.ReadLine();
                if (rx.IsMatch(bin)) { valid = true; }
                else { Console.WriteLine("Invalid input. String has to be 8 bits of 1s and 0s"); }
                Console.WriteLine();
            } 
            return bin;
        }
    }
}
