using System;
using System.Collections.Generic;

namespace IsInteresting
{
    internal class Program
    {
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            string num = number.ToString();
            int len = num.Length;

            // Over 99
            if (number < 98) { return 0; }
            if (number == 98 || number == 99) { return 1; }

            // Awesome phrases
            for (int i = 0; i < awesomePhrases.Count; i++)
            {
                if (number == awesomePhrases[i]) { return 2; }
            }

            // Digit followed by zeros
            int notzeros = 0;
            for (int i = 1; i < len && notzeros == 0; i++)
            {
                if (num[i] != '0') { notzeros++; }
            }
            if (notzeros == 0) { return 2; }

            // Digits are the same number
            int notsame = 0;
            for (int i = 1; i < len && notsame == 0; i++)
            {
                if (num[0] != num[i]) { notsame++; }
            }
            if (notsame == 0) { return 2; }

            // Incrementingly sequential
            int notinc = 0;
            for (int i = 1; i < len && notinc == 0; i++)
            {
                if (int.Parse(num[0].ToString()) + i != int.Parse(num[i].ToString())) { notinc++; }
                if (int.Parse(num[i - 1].ToString()) == 9 && int.Parse(num[i].ToString()) == 0) { notinc--; }
            }
            if (notinc == 0) { return 2; }

            // Decrementingly sequential
            int notdec = 0;
            for (int i = 1; i < len && notdec == 0; i++)
            {
                if ((int.Parse(num[0].ToString()) - i) != int.Parse(num[i].ToString())) { notdec++; }
            }
            if (notdec == 0) { return 2; }

            // Palindrome
            string rev = "";
            foreach (char c in num) { rev = c + rev; }
            if (rev == num) { return 2; }

            // Returning 1s
            for (int x = 1; x <= 2; x++)
            {

                string newnum = (number + x).ToString();

                // Awesome phrases
                for (int i = 0; i < awesomePhrases.Count; i++)
                {
                    if (number == awesomePhrases[i] - x) { return 1; }
                }

                // Digits followed by zeros
                notzeros = 0;
                for (int i = 1; i < newnum.Length && notzeros == 0; i++)
                {
                    if (newnum[i] != '0') { notzeros++; }
                }
                if (notzeros == 0) { return 1; }

                // Digits all the same
                notsame = 0;
                for (int i = 1; i < newnum.Length && notsame == 0; i++)
                {
                    if (num[0] != newnum[i]) { notsame++; }
                }
                if (notsame == 0) { return 1; }

                // Incrementingly sequential
                notinc = 0;
                for (int i = 1; i < newnum.Length && notinc == 0; i++)
                {
                    if (int.Parse(newnum[0].ToString()) + i != int.Parse(newnum[i].ToString())) { notinc++; }
                    if (int.Parse(newnum[i - 1].ToString()) == 9 && int.Parse(newnum[i].ToString()) == 0) { notinc--; }
                }
                if (notinc == 0) { return 1; }

                // Decrementingly sequential
                notdec = 0;

                for (int i = 1; i < newnum.Length && notdec == 0; i++)
                {
                    if ((int.Parse(newnum[0].ToString()) - i) != int.Parse(newnum[i].ToString())) { notdec++; }
                }
                if (notdec == 0) { return 1; }

                // Palindrome
                rev = "";
                foreach (char c in newnum) { rev = c + rev; }
                if (rev == newnum) { return 1; }
            }

            return 0;
        }

        static void Main()
        {
            Console.WriteLine("Enter a number you might think is interesting");
            Console.WriteLine("  If 0, it isn't interesting.\n  If 1, the number would be interesting in 1 or 2 numbers.\n  If 2, the number is interesting");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(IsInteresting(number, new List<int>() { 1337, 256 }));
        }
    }
}
