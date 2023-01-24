using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LastSurvivor2 {
    class Program {
        public static string last_survivors(string str) {
            while (str.Distinct().Count() != str.Length) {
                string newstr = "";
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                str = "";
                foreach (char c in chars) {
                    str += c;
                }
                for (int i = 0; i < str.Length - 1; i++) {
                    if (str[i] == str[i + 1]) {
                        if (str[i] == 'z') { newstr += 'a'; }
                        else { newstr += (char)(str[i] + 1); }
                        i++;
                    }
                    else {
                        newstr += str[i];
                    }
                    if (i == str.Length - 2) { newstr += str[i + 1]; }
                }
                str = newstr;
            }
            return str;
        }
        static void Main(string[] args) {
            Console.WriteLine(last_survivors("zzab"));
        }
    }
}
