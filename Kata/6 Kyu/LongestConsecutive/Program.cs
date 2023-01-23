using System;

namespace LongestConsecutive {
    internal class Program {
        public static string LongestConsec(string[] strarr,int k) {
            int n = strarr.Length;
            if (n == 0 || k > n || k <= 0) { return ""; } // Just emulating what was said before the note  

            string BiggestStr = "";

            for (int i = 0; i <= strarr.Length - k; i++) {
                string ConcatStr = "";
                for (int count = 0; count < k; count++) {
                    ConcatStr = String.Concat(ConcatStr,strarr[i + count]);
                }
                if (ConcatStr.Length > BiggestStr.Length) {
                    BiggestStr = ConcatStr;
                }
            }

            return BiggestStr;
        }
        static void Main(string[] args) {
            string[] strarr = new string[] { "ejjjjmmtthh","zxxuueeg","aanlljrrrxx","dqqqaaabbb","oocccffuucccjjjkkkjyyyeehh" };
            Console.WriteLine(LongestConsec(strarr,1));

        }
    }
}
