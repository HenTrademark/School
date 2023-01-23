using System;

namespace Subroutines {
    internal class Program {
        static void proc1(int x, ref int y) {
            x = x - 2;
            y = 0;
        }
        static void Main(string[] args) {
            int m = 8, n = 10;
            proc1(m, ref n);
            Console.WriteLine("m = {0}, n = {1}",m,n);
        }
    }
}
