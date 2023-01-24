using System;

namespace RailFenceCipher {
    class Program {
        public static string Encode(string s, int n) {
            if (s == "") { return ""; }
            string[] rails = new string[n];
            for (int i = 0; i < n; i++) {
                rails[i] = "";
            }

            bool down = true;
            int rail = 0;
            for (int count = 0; count < s.Length; count++) {
                rails[rail] += s[count];

                if (down) { rail++; }
                else { rail--; }

                if (rail == 0) { down = true; }
                else if (rail == n - 1) { down = false; }
            }

            string str = String.Join("", rails);

            return str;
        }

        public static string Decode(string s, int n) {
            int[] nums = new int[n];
            int next1 = 2 * n - 2;
            int next2 = 0;
            for (int r = 0; r < n; r++) {
                int curr = r;
                int count = 0;
                while (curr < s.Length) {
                    if (curr < s.Length && next1 > 0) {
                        curr += next1;
                        count++;
                    }
                    if (curr < s.Length && next2 > 0) {
                        curr += next2;
                        count++;
                    }
                }
                nums[r] = count;
                next1 -= 2;
                next2 += 2;
            }
            string[] rails = new string[n];
            for (int i = 0; i < n; i++) {
                rails[i] = s.Substring(0, nums[i]);
                s = s.Substring(nums[i]);
            }

            // SOMETHING WRONG FROM HERE
            bool down = true;
            int rail = 0;
            string ans = "";
            for (int count = 0; count < s.Length; count++) {
                ans += rails[rail][0];
                rails[rail] = rails[rail].Substring(1);

                if (down) { rail++; }
                else { rail--; }

                if (rail == 0) { down = true; }
                else if (rail == n - 1) { down = false; }
            }
            
            return ans;
        }
        static void Main(string[] args) {
            Console.WriteLine(Decode("0481357926",3));
        }
    }
}
