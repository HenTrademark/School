using System;
using System.Text.RegularExpressions;

namespace BinaryMultipleOf3 {
    internal class Program {
        public static Regex MultipleOf3() {
            return new Regex("^(0|1(01*0)*1)*$");
            /*
                1   ^       Matches the first character in the string 
                2   0|1     Either a 0 or a 1 and the below statements
                3   01*0    Any number of 1s (00, 010, 0110, 01110...) surrounded by a 0 on each side
                4   *1      Any number of the above statement (3) then a 1
                5   *$      Any number of the above statements (2-4), then the end
            */
        }
        static void Main(string[] args) {
            Console.WriteLine(MultipleOf3().IsMatch("0001"));
        }
    }
}
