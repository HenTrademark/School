using System;

namespace LetterTriangles {
    class Program {
        static string Triangle(string row) {
            string str = "";
            while (row.Length > 1) {
                for (int i = 0; i < row.Length - 1; i++) {
                    int ascii = (row[i] - 96) + (row[i + 1] - 96);
                    if (ascii > 26) { ascii -= 26; }
                    str += (char)(ascii + 96);
                }
                row = str;
                str = "";
            }
            return row;
        }
        static void Main(string[] args) {
            Console.WriteLine("End: {0}",Triangle("triangle"));
        }
    }
}
