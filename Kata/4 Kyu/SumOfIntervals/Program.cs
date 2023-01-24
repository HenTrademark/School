using System;

namespace SumOfIntervals {
    internal class Program {
        public static int SumIntervals((int,int)[] intervals) {
            int sum = 0;
            for (int i = 0; i < intervals.Length; i++) {
                sum += intervals[0].Item2 - intervals[0].Item1;
            }
            return sum;
        }
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
}
