using System;
using System.Security.Cryptography.X509Certificates;

namespace RomanNumeralsHelper
{
    internal class Program
    {
        public static string ToRoman(int n) {
            string roman = "";
            while (n > 0) {
                if (n >= 1000) { roman += "M"; n -= 1000; }
                else if (n >= 900) { roman += "CM"; n -= 900; }
                else if (n >= 500) { roman += "D"; n -= 500; }
                else if (n >= 400) { roman += "CD"; n -= 400; }
                else if (n >= 100) { roman += "C"; n -= 100; }
                else if (n >= 90) { roman += "XC"; n -= 90; }
                else if (n >= 50) { roman += "L"; n -= 50; }
                else if (n >= 40) { roman += "XL"; n -= 40; }
                else if (n >= 10) { roman += "X"; n -= 10; }
                else if (n >= 9) { roman += "IX"; n -= 9; }
                else if (n >= 5) { roman += "V"; n -= 5; }
                else if (n >= 4) { roman += "IV"; n -= 4; }
                else if (n >= 1) { roman += "I"; n -= 1; }
            }
            return roman;
        }

        public static int FromRoman(string romanNumeral) {
            int num = 0;
            while (romanNumeral.Length > 0) {
                switch (romanNumeral[0]) {
                    case 'M':
                        num += 1000;
                        romanNumeral = romanNumeral.Substring(1);
                        break;
                    case 'D':
                        num += 500;
                        romanNumeral = romanNumeral.Substring(1);
                        break;
                    case 'C':
                        if (romanNumeral.Length > 1) {
                            if (romanNumeral[1] == 'M') {
                                num += 900;
                                romanNumeral = romanNumeral.Substring(2);
                            }
                            else if (romanNumeral[1] == 'D') {
                                num += 400;
                                romanNumeral = romanNumeral.Substring(2);
                            }
                            else {
                                num += 100;
                                romanNumeral = romanNumeral.Substring(1); 
                            }
                        }
                        else
                        {
                            num += 100;
                            romanNumeral = romanNumeral.Substring(1);
                        }
                        break;
                    case 'L':
                        num += 50;
                        romanNumeral = romanNumeral.Substring(1);
                        break;
                    case 'X':
                        if (romanNumeral.Length > 1) {
                            if (romanNumeral[1] == 'C')
                            {
                                num += 90;
                                romanNumeral = romanNumeral.Substring(2);
                            }
                            else if (romanNumeral[1] == 'L')
                            {
                                num += 40;
                                romanNumeral = romanNumeral.Substring(2);
                            }
                            else
                            {
                                num += 10;
                                romanNumeral = romanNumeral.Substring(1);
                            }
                        }
                        else
                        {
                            num += 10;
                            romanNumeral = romanNumeral.Substring(1);
                        }
                        break;
                    case 'V':
                        num += 5;
                        romanNumeral = romanNumeral.Substring(1);
                        break;
                    case 'I':
                        if (romanNumeral.Length > 1) {
                            if (romanNumeral[1] == 'X')
                            {
                                num += 9;
                                romanNumeral = romanNumeral.Substring(2);
                            }
                            else if (romanNumeral[1] == 'V')
                            {
                                num += 4;
                                romanNumeral = romanNumeral.Substring(2);
                            }
                            else
                            {
                                num += 1;
                                romanNumeral = romanNumeral.Substring(1);
                            }
                        }
                        else
                        {
                            num += 1;
                            romanNumeral = romanNumeral.Substring(1);
                        }
                        break;
                }
            }
            return num;
        }
        static void Main(string[] args) {
            string x = "MDCLXVI";
            int y = 1666;
            Console.WriteLine("{0} in denary is: {1}",x,FromRoman(x));
            Console.WriteLine("{0} in roman numerals is: {1}", y, ToRoman(y));
        }
    }
}
