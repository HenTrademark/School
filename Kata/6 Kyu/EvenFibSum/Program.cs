using System;

namespace EvenFibSum {
    class Program {
        public static long Fibonacci(int max)
        {
            if (max < 3) { return 0; }
            long ans = 0;
            int[] fib = { 0, 1, 1};
            for (int index = 2; fib[index] < max; index++) {
                if (fib[index] % 2 == 0) { ans += fib[index]; }
                Array.Resize(ref fib, index + 2);
                fib[index+1] = fib[index] + fib[index-1];
            }
            return ans;
        }
        static void Main(string[] args) {
            Console.WriteLine(Fibonacci(999999999));
        }
    }
}