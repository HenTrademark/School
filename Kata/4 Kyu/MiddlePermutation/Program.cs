// https://www.codewars.com/kata/58ad317d1541651a740000c5/solutions/csharp

using System;

namespace MiddlePermutation
{
    class Program
    {
        public static string MiddlePermutation(string s){
            int len = s.Length;
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string str = "", ans = "";
            foreach (char c in chars) { str += c; }

            if (len % 2 == 1) {
                ans += str[(len - 1) / 2];
                str = str.Substring(0, (len - 1) / 2) + str.Substring((len + 1) / 2);
                len -= 1;
            }

            ans += str[(len / 2) - 1];
            str = str.Substring(0, (len / 2) - 1) + str.Substring(len / 2);

            for (int i = str.Length - 1; i >= 0; i--) { ans += str[i]; }

            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MiddlePermutation("chars"));
        }
    }
}