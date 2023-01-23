using System;

namespace Program7_3 {
    internal class Program {
        static void Main(string[] args) {
            // Random number from 33 to 127
            Random rnd = new Random();
            string pass = "";
            int points = 0;
            for (int i = 0; i < 8; i++) { // For  8 characters
                int randomnum = rnd.Next(33,127); // 33 <= x < 127
                pass += (char)randomnum; // Converts to char, adds to pass
            }

            // Checks for capitals

            foreach (char c in pass) {
                // If the char is a capital letter then add 10 points
                if ((int)c >= 65 && (int)c <= 90) { points += 10; }
                // If the char is not alphanumeric then add 5 points
                if (((int)c > 32 && (int)c < 48) || ((int)c > 57 && (int)c < 65) || ((int)c > 90 && (int)c < 97) || ((int)c > 122 && (int)c < 127)) 
                { points += 5; }
            }

            Console.WriteLine("Your password is: {0}",pass);
            Console.WriteLine("Your password score is: {0}",points);

            // Weak, Medium, Strong
            switch (points) {
                case (< 25):
                    Console.WriteLine("Your password is weak");
                    break;
                case (< 40):
                    Console.WriteLine("Your password is medium");
                    break;
                case (>= 40):
                    Console.WriteLine("Your password is strong");
                    break;
            }
        }
    }
}
