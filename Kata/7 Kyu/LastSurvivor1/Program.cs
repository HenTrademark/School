using System;

namespace LastSurvivor1 {
    class Program {
        public static string LastSurvivor(string letters, int[] coords) {
            foreach (int i in coords) {
                letters = letters.Substring(0, i) + letters.Substring(i + 1);
            }
            return letters;
        }
        static void Main(string[] args) {
            Console.WriteLine(LastSurvivor("abc", new int[]{1, 1}));
        }
    }
}
