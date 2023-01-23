using System;

namespace Program4_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Makes a list for the Fibonacci sequence
            int[] Fb = new int[] { 1, 2};
            int num = 0;
            for (int i = 2; i < 42; i++) { // Goes to index 41, the 42nd term
                Array.Resize(ref Fb, Fb.Length + 1); // Adds 1 to the array size
                Fb[i] = Fb[i - 1] + Fb[i - 2]; // Adds the last 2 terms and makes it the last term
                num = Fb[i]; // Sets the number to the last term (will get to the term we want)
            }
            Console.WriteLine("The 42nd Fibonacci number is: {0}",num);
        }
    }
}
