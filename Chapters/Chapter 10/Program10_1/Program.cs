using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Program10_1 {
    internal class Program {
        private static List<Cat> Cats = new(); // List to store the cats in
        static void Main(string[] args) {
            bool done = false;
            while (!done) { // Menu
                Console.WriteLine(" Welcome to the Cat's Protection Trust Management System! Do you want to:");
                Console.WriteLine(" [1] Add a new cat");
                Console.WriteLine(" [2] Retrieve a cat's details");
                Console.WriteLine(" [3] Update a cat's details");
                Console.WriteLine(" [4] Quit the program\n");
                string sel = "";
                Console.Write(" Pick an option (1-4): ");
                sel = Console.ReadLine();
                switch (sel) {
                    case "1":
                        Cats.Add(new Cat());
                        break;
                    case "2":
                        Console.WriteLine(); // NOT IMPLEMENTED
                        break;
                    case "3":
                        Console.WriteLine(); // NOT IMPLEMENTED
                        break;
                    case "4":
                        done = true;
                        break;
                    default: // If not valid
                        Console.WriteLine("\nNot a valid option");
                        Console.WriteLine("Enter a number from 1 to 4\n");
                        break;
                }
            }
            Console.WriteLine("Alright, goodbye!");
        }
        static int SelectCat() {
            Console.WriteLine("");
            return 0;
        }
    }
    class Cat {
        private string catName;
        private string catBreed;
        private char catGender;
        private double catWeight;
        private bool catNeutered;
        private bool catVaccinated;
        private bool catRehomeReady;

        public Cat() {
            string name, breed, gender, weight, neutered, vaccinated, rehomeReady;
            Console.Write("Enter cat's name: ");
            name = Console.ReadLine();
            Console.Write("\nEnter cat's breed: ");
            breed = Console.ReadLine();
            do {
                Console.Write("\nEnter cat's gender (M/F): ");
                gender = Console.ReadLine().ToUpper();
                if (!Regex.IsMatch(gender,"^(M|F)\\z")) {
                    Console.WriteLine("\nNot a valid input");
                    Console.WriteLine("Please enter M or F");
                }
            } while (!Regex.IsMatch(gender,"^(M|F)\\z"));
            do {
                Console.Write("\nEnter cat's weight (in kg): ");
                weight = Console.ReadLine();
                if (!Regex.IsMatch(weight,"^([0-9]|([0-9]+[.]{1}[0-9]+))\\z")) {
                    Console.WriteLine("\nNot a valid input");
                    Console.WriteLine("Please enter a valid number");
                }
            } while (!Regex.IsMatch(weight,"^([0-9])|([0-9]+[.]{1}[0-9]+)\\z"));
            do {
                Console.Write("\nIs the cat neutered (Y/N): ");
                neutered = Console.ReadLine().ToUpper();
                if (!Regex.IsMatch(neutered,"^(Y|N)\\z")) {
                    Console.WriteLine("\nNot a valid input");
                    Console.WriteLine("Please enter Y or N");
                }
            } while (!Regex.IsMatch(neutered,"^(Y|N)\\z"));
            do {
                Console.Write("\nIs the cat vaccinated (Y/N): ");
                vaccinated = Console.ReadLine().ToUpper();
                if (!Regex.IsMatch(vaccinated,"^(Y|N)\\z")) {
                    Console.WriteLine("\nNot a valid input");
                    Console.WriteLine("Please enter Y or N");
                }
            } while (!Regex.IsMatch(vaccinated,"^(Y|N)\\z"));
            do {
                Console.Write("\nIs the cat ready to be rehomed (Y/N): ");
                rehomeReady = Console.ReadLine().ToUpper();
                if (!Regex.IsMatch(rehomeReady,"^(Y|N)\\z")) {
                    Console.WriteLine("\nNot a valid input");
                    Console.WriteLine("Please enter Y or N");
                }
            } while (!Regex.IsMatch(rehomeReady,"^(Y|N)\\z"));
            catName = name;
            catBreed = breed;
            catGender = char.Parse(gender);
            catWeight = double.Parse(weight);
            catNeutered = neutered == "Y";
            catVaccinated = vaccinated == "Y";
            catRehomeReady = rehomeReady == "Y";
            Console.WriteLine("\n");
        }

        public void ViewCatDetails() {
            Console.WriteLine("Cat's name: {0}",catName);
            Console.WriteLine("Cat's breed: {0}",catBreed);
            Console.WriteLine("Cat's gender: {0}",catGender == 'M' ? "Male" : "Female");
            Console.WriteLine("Cat's weight: {0}kg",catWeight);
            Console.WriteLine("Cat neutered?: {0}",catNeutered ? "Yes" : "No");
            Console.WriteLine("Cat vaccinated?: {0}",catVaccinated ? "Yes" : "No");
            Console.WriteLine("Cat rehome ready?: {0}",catRehomeReady ? "Yes" : "No");
        }
    }
}
