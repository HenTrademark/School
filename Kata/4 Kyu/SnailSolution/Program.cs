using System;
using System.Reflection;

namespace SnailSolution {
    class Program {
        static int[] Snail(int[][] array) {
            int n = array[0].Length;
            int[] result = new int[0];

            if (n == 0) { return result; }
            if (n == 1) {
                Array.Resize(ref result, result.Length + 1);
                result[0] = array[0][0];
                return result;
            }
            for (int i = 0; i < (n / 2); i++) { // For every square
                for (int c = 0 + i; c < (n - i) - 1; c++) { // Top
                    Array.Resize(ref result, result.Length + 1);
                    result[^1] = array[i][c];
                }
                for (int r = 0 + i; r < (n - i) - 1; r++) { // Right
                    Array.Resize(ref result, result.Length + 1);
                    result[^1] = array[r][(n-i)-1];
                }
                for (int c = (n - i) - 1; c > i; c--) { // Bottom
                    Array.Resize(ref result, result.Length + 1);
                    result[^1] = array[(n-i)-1][c];
                }
                for (int r = (n - i) - 1; r > i; r--) { // Left
                    Array.Resize(ref result, result.Length + 1);
                    result[^1] = array[r][i];
                }
            }
            if (n % 2 == 1) {
                Array.Resize(ref result, result.Length + 1);
                result[^1] = array[n/2][n/2];
            }
            return result;
        }
        static void Main() {
            int[] arr = new int[0];
            int[][] array = { arr };
            string x = String.Join(", ", Snail(array));
            Console.WriteLine("String: {0}",x);
        }
    }
}
