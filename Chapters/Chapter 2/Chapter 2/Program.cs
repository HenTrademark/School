using System;

namespace Chapter_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Shows the order of operations
            const int A = 10;
            const int B = 4;
            const int C = 6;
            Console.WriteLine("B + C * A = {0}", B + C * A); // Does C * A first then adds B
            Console.WriteLine("B + C * A = {0}", (B + C) * A); // Does B + C first then multiplies it with C
        }
    }
}
