using System;

namespace Program6_2 {
    internal class Program {
        static void Main(string[] args) {
            int num1, num2; // Declares num1 and num2

            // Gets num1 and num2 from the user
            Console.Write("Please enter number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            // Adds num1 and num2
            Addition(num1,num2);
        }
        static void Addition(int num1,int num2) {
            // Outputs "{num1} + {num2} = {num1 + num2}"
            Console.WriteLine("{0} + {1} = {2}",num1,num2,num1 + num2);
        }
    }
}
