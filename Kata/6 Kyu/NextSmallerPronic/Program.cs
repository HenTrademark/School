using System;

namespace NextSmallerPronic {
    class Program {
        public static ulong NextSmallerPronic(ulong x) {
            if (Math.Sqrt(x) % 1 == 0) { x--; }
            ulong ans = ulong.Parse((Math.Floor(Math.Sqrt(x)) * Math.Ceiling(Math.Sqrt(x))).ToString());
            if (ans >= x) { ans -= ulong.Parse((2 * Math.Floor(Math.Sqrt(x))).ToString()); }

            return ans;
        }
        static void Main(string[] args) {
            Console.Write("Enter a number: ");
            ulong x = ulong.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Next Smaller Pronic Number: {0}",NextSmallerPronic(x));
            
        }
    }
}