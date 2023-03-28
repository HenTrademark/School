using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Program9_1 {
    class Program {
        static void Main(string[] args) {
            bool quit = false;
            while (!quit) {
                string sel;
                do {
                    Console.WriteLine("This is a password entry program - do you want to:");
                    Console.WriteLine("[1] - Add a new username and password");
                    Console.WriteLine("[2] - Output the username and password file");
                    Console.WriteLine("[3] - Quit the program");
                    Console.Write("(Enter 1-3): ");
                    sel = Console.ReadLine();
                    Console.WriteLine();
                    if (!Regex.IsMatch(sel, "^[1-3]\\z")) {
                        Console.WriteLine("Invalid input");
                        Console.WriteLine("Enter an integer from 1 to 3\n");
                    }
                } while (!Regex.IsMatch(sel, "^[1-3]\\z"));

                switch (sel) {
                    case "1":
                        Console.Write("Enter username: ");
                        string user = Console.ReadLine();
                        Console.Write("Enter password: ");
                        string pass = Console.ReadLine();
                        File.AppendAllText("Passwords.txt", 
                            "====================\nUsername: " + user + "\nPassword: " + pass + "\n====================\n\n");
                        Console.WriteLine("\n");
                        break;
                    case "2":
                        Console.WriteLine(File.ReadAllText("Passwords.txt"));
                        break;
                    case "3":
                        Console.WriteLine("Okay, goodbye o/");
                        quit = true;
                        break;
                }
            }
        }
    }
}