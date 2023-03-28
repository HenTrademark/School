﻿using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Program9_2 {
    class Program {
        static void Main(string[] args) {
            if (!File.Exists("Passwords.txt")) { File.Create("Passwords.txt"); }
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
                        using (StreamWriter SW = new StreamWriter("Passwords.txt", true)) {
                            SW.WriteLine("====================\nUsername: " + user + "\nPassword: " + pass + "\n====================\n");
                            SW.Close();
                        }
                        Console.WriteLine("\nSuccessfully added details\n");
                        break;
                    case "2":
                        using (StreamReader SR = new StreamReader("Passwords.txt")) {
                            while (SR.Peek() > -1) {
                                Console.WriteLine(SR.ReadLine());
                            }
                            SR.Close();
                        }
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