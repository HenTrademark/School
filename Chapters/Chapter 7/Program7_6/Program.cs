using System;

namespace Program7_6 {
    internal class Program {
        static void Main(string[] args) {
            // Feed in a string containing the sentence "I am going to check every word of this sentence for the keywords"
            string str = "I am going to check every word of this sentence for the keywords";

            // Split the string into an array of the individual words making up the sentence
            string[] splitstr = str.Split(' '); // Splits by the spaces

            // check the array of words for instances of the keywords
            string[] keywords = new string[] { "check","word","sentence" };
            bool key;

            foreach (string s in splitstr) {
                key = false; // While i is less than the length and while key is false
                for (int i = 0; i < keywords.Length && key == false; i++) {
                    if (s == keywords[i]) { key = true; }
                }

                // Output sentence with key words highlighted
                switch (key) { // If key, turn yellow. If not, turn green
                    case true: Console.ForegroundColor = ConsoleColor.Yellow; break;
                    case false: Console.ForegroundColor = ConsoleColor.Green; break;
                }
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Console.ResetColor(); // Resets colour
        }
    }
}
