using System;

namespace Program4_9 {
    internal class Program {
        static void Main(string[] args) {
            int sum = 0; // Declaring the variable
            for (int i = 1; i < 1000; i++) { // While "i" is under 1000
                // If "i" is a multiple of 3 or 5, add it to "sum"
                if (i % 3 == 0 || i % 5 == 0) { sum += i; }
            } // Then print out the sum of it all
            Console.WriteLine("The sum of all multiples of 3 and 5 under 1000 is: {0}", sum);
        }
    }
}
