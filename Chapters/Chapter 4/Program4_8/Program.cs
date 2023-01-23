using System;

namespace Program4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interest program

            // Declaring variables
            double balance = 50.00f, target = 100.00f; const double interest = 0.02f;
            int months = 0;
            // While the balance is under the target
            while (balance < target) {
                months++; // Increment the months
                Console.WriteLine("After {0} months of interest, your balance increased by £{1}, giving you a total balance of £{2}",
                    months, Math.Round(balance * interest,2), balance + Math.Round(balance * interest, 2) );
                balance = Math.Round(balance + Math.Round(balance * interest, 2), 2); // Gives the balance increase, new balance and the month
            }
            Console.WriteLine("\nThe balance is over £{0}, giving you a total of {1} months", target, months); // Gives the result
        }
    }
}
