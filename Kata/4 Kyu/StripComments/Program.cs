using System;

namespace StripComments
{
    internal class Program
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            string[] arr = text.Split("\n");
            for (int x = 0; x < arr.Length; x++) {
                foreach (string c in commentSymbols) {
                    if (arr[x].Contains(c)) {
                        int index = -1;
                        for (int i = 0; index < 0; i++ ) {
                            if (arr[x][i].ToString() == c) { index = i; }
                        }
                        arr[x] = arr[x].Substring(0,index);
                    }
                }
                if (arr[x].Length > 0) {
                    string rev = "", back = "";
                    foreach (char c in arr[x]) { rev = c + rev; }
                    while (rev.Length > 0 && rev[0] == ' ') {
                        rev = rev.Substring(1);
                    }
                    foreach (char c in rev) { back = c + back; }
                    arr[x] = back;
                }
            }
            return String.Join("\n",arr);
        }

        static void Main(string[] args)
        {
            string x = StripComments(" a #b\nc\n \nd $e f g", new string[] { "#", "$" });
            Console.WriteLine("New string:\n{0}",x);
        }
    }
}
