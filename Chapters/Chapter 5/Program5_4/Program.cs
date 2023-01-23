// This program will help a charity to run its own lottery. 

using System;
using System.Collections;

namespace Program5_4 {
    internal class Program {
        static void Main(string[] args) {
            // Declaring variables
            ArrayList numbers = new ArrayList();
            Random rnd = new Random();
            Console.WriteLine("Welcome to the charity lottery!\n");

            // Random numbers or Picked?
            Console.WriteLine("To play, 5 numbers (from 1 - 60) will be picked");
            Console.WriteLine("To pick numbers, you can either:");
            Console.WriteLine("  a) Pick your own numbers");
            Console.WriteLine("  b) Have the charity pick your numbers\n");
            Console.Write("Pick your option (a or b): ");
            string sel = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (sel == "a") { // User picks the numbers
                int number = 0;
                for (int i = 1; i <= 5; i++) { // Repeats 5 times
                    bool valid = false; 
                    while (valid == false) { // Asks for an input and sees if it is valid
                        Console.Write("Enter number {0}: ",i);
                        number = int.Parse(Console.ReadLine());
                        if (number < 1 || number > 60) { Console.WriteLine("Invalid number."); }
                        else { valid = true; } // If number is not valid, it'll ask again for a valid number
                        Console.WriteLine(); // If it is, makes valid true, stopping the while loop
                    } // After getting a valid result, the number is added to the end of "numbers"
                    numbers.Add(number); 
                }
            }
            else { // Picks the numbers randomly
                // If they didn't choose a valid value for sel, will randomly pick numbers for the person
                if (sel != "b") { Console.WriteLine("Not a valid input. Randomly picking numbers"); }
                for (int i = 0; i < 5; i++) { // Repeats 5 times
                    // Adds 5 numbers to the end of "numbers" (That are 1 to 60)
                    numbers.Add(rnd.Next(1,61)); // 1 <= x < 61
                }
            }

            int count = 0; // Check for multiples of 10
            for (int i = 0; i < 5 && count == 0; i++) { // Checks all 5 things or while count is 0
                // If there is, add 1 to count
                if ((int)numbers[i] % 10 == 0) { count++; }
            }
            if (count > 0) {
                Console.WriteLine("One of your numbers is a multiple of 10!");
                Console.WriteLine("This means you get another number\n");
                numbers.Add(rnd.Next(1,61)); // 1 <= x < 61
            }

            Console.Write("Your lottery numbers: | ");
            for (int i = 0; i < numbers.Count; i++) {
                // After that, it shows the numbers in "numbers"
                Console.Write("{0} | ",numbers[i]);
            }
            Console.WriteLine();
        }
    }
}
