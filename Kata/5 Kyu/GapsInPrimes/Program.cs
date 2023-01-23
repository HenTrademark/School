using System;
using System.Drawing;

namespace GapsInPrimes
{
    internal class Program
    {
        public static bool IsPrime(long m) {
            int count = 0;
            for (double i = 2; i <= Math.Sqrt(m) && count == 0; i += 1) {
                double ans = double.Parse(m.ToString()) / i;
                if (ans % 1 == 0) { count++; }
            }
            if (count == 0) { return true; }
            return false;
        }
        public static long nextPrime(long m)
        {
            int TF = 0;
            while (TF == 0) {
                m++;
                if (IsPrime(m) == true) { TF = 1; }
            }
            return m;
        }
        public static long[] Gap(int g, long m, long n) {
            // Check if m is a prime number
            if (IsPrime(m) == false) {
                long next = m;
                long othernext = nextPrime(m);
                while (othernext <= n) {
                    next = othernext;
                    othernext = nextPrime(next);
                    if (othernext <= n) {
                        int diff = int.Parse((othernext - next).ToString());
                        if (diff == g) { return new long[] {next, othernext}; }
                    }
                }
            }
            else {
                long next = m, othernext = m;
                while (othernext <= n) {
                    next = othernext;
                    othernext = nextPrime(next);
                    if (othernext <= n) {
                        int diff = int.Parse((othernext - next).ToString());
                        if (diff == g) { return new long[] { next, othernext }; }
                    }
                }
            }
            return null;
        }

        public static void Main(string[] args)
        {
            long[] arr = Gap(7, 300, 400);
            Console.WriteLine("({0}, {1})", arr[0], arr[1]);
        }
    }
}
