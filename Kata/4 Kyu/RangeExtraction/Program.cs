using System;
using System.Collections.Generic;

namespace RangeExtraction {
    class Program {
        static List<string> numbers = new List<string>();
        public static void AddToList(int front, int back) {
            if (front - back > 1) {
                var str = back + "-" + front;
                numbers.Add(str);
            }
            else if (front - back == 1) {
                numbers.Add(back.ToString());
                numbers.Add(front.ToString());
            }
            else {
                numbers.Add(front.ToString());
            }
        }
        public static string Extract(int[] args) {
            var front = 0;
            var back = 0;
            for (var i = 0; i < args.Length - 1; i++) {
                if (i != 0) {
                    if (args[i] - 1 != args[i - 1]) {
                        AddToList(front,back);
                        back = args[i];
                    }
                }
                else {
                    back = args[i];
                }
                
                front = args[i];
                if (i == args.Length - 2) {
                    var last = 0.5f;
                    if (args[i + 1] == args[i] + 1) {
                        front = args[i + 1];
                    }
                    else {
                        last = args[i + 1];
                    }

                    AddToList(front,back);

                    if (last % 1 == 0) {
                        numbers.Add(last.ToString());
                    }
                }
            }

            var ans = String.Join(',', numbers);
            return ans;
        }
        private static void Main(string[] args) {
            int[] nums = new int[]
                { 1, 2, 3 };
            
            Console.WriteLine(Extract(nums));
        }
    }
}
