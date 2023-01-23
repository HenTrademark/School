using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program6_1 {
    internal class Program {
        static string secretword = "Computer";
        
        static void Main(string[] args) {
            int menuoption;
            do {
                OutputMenu();
                menuoption = Convert.ToInt32(Console.ReadLine()); // Asks the user to enter a menu option

                switch (menuoption) { // Switches the menu option
                    case 1: ChangeWord(); break; // If 1, change the secret word
                    case 2: GuessWord(); break; // If 2, guess the secret word
                    case 3: Quit(); break; // If 3, quit the program
                }
            }
            while (menuoption == 1 || menuoption == 2);


            Console.ReadLine();
        } // End of main
        static void OutputMenu() { // Declares the "OutputMenu" procedure
            Console.WriteLine("Welcome to the guessing program menu - choose your option");
            Console.WriteLine("1 - change the secret word");
            Console.WriteLine("2 - Make a guess");
            Console.WriteLine("3 - Quit");
        } // End of procedure "OutputMenu"
        static void ChangeWord() { // Declares the "ChangeWord" procedure
            Console.WriteLine("What is the secret word");
            secretword = Console.ReadLine(); 
        } // End of procedure "ChangeWord"
        static void GuessWord() { // Declares the "GuessWord" procedure
            string guess;
            Console.WriteLine("guess the secret word");
            guess = Console.ReadLine();
            if (guess == secretword) { // if right
                Console.WriteLine("Well done - you have guessed the secret word");
            }
            else { // if wrong
                Console.WriteLine("sorry that is not the secret word");
            }
        } // End of procedure "GuessWord"
        static void Quit() { // Declares the "Quit" procedure
            Console.WriteLine("thank you for playing secret word");
            Environment.Exit(0);
        } // End of procedure "Quit"
    } // End of class "Program"
} // End of namespace "Program6_1"
