using System;
using System.Reflection;

namespace WhichAreIn {
    internal class Program {
        public static string[] inArray(string[] array1, string[] array2) {
            string[] result = new string[0];
            foreach (string s in array1) {
                int count = 0;
                for (int i = 0; i < array2.Length && count == 0; i++) {
                    if (array2[i].Contains(s)) {
                        Array.Resize(ref result,result.Length + 1);
                        result[result.Length - 1] = s;
                        count++;
                    }
                }
            }
            Array.Sort(result);
            return result;
        }
        static void Main(string[] args) {
            string[] a1 = new string[] { "tarp","mice","bull" };
            string[] a2 = new string[] { "lively","alive","harp","sharp","armstrong" };
            Console.WriteLine("Strings in \"a1\" that are also in \"a2\":  " + String.Join(", ",inArray(a1,a2)));
        }
    }
}
