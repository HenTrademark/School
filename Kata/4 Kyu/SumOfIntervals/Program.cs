using System;

namespace SumOfIntervals {
    internal class Program {
        public static int SumIntervals((int,int)[] intervals) {
            int sum = 0;
            for (int i = 0; i < intervals.Length; i++) {
                sum += intervals[0][1] - intervals[0][0];
            }
            return sum;
        }
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
}
