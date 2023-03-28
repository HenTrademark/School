using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Program9_3 {
    class Program {
        static void Main(string[] args) {
            // If FootballTeam.txt doesn't exist, make it and set count to 0
            if (!File.Exists("FootballTeam.txt")) {
                File.Create("FootballTeam.txt");
                File.WriteAllText("Count.txt","0");
            }
            // Repeat until done
            bool done = false;
            while (!done) {
                // set a variable to count
                int count = int.Parse(File.ReadAllText("Count.txt"));
                // Gets selection from Menu subsystem
                string sel = Menu();
                switch (sel) {
                    case "1":
                        // AddPlayer returns a number for count
                        File.WriteAllText("Count.txt",AddPlayer(count));
                        Console.WriteLine();
                        break;
                    case "2":
                        // Shows the team with all of their information
                        ViewTeam(count);
                        break;
                    case "3":
                        // Calculates the team value from the stats
                        Console.WriteLine("Total team value: {0}\n",TeamValue(count));
                        break;
                    case "4":
                        // Quits the program
                        Console.WriteLine("Okay, goodbye o/");
                        done = true;
                        break;
                }
            }
        }

        static string Menu() {
            string sel = "";
            do { // Does this until valid inputs are made
                Console.WriteLine("Welcome to your fantasy team - do you want to:");
                Console.WriteLine("[1] Add a new player");
                Console.WriteLine("[2] View the team");
                Console.WriteLine("[3] Calculate the team's value");
                Console.WriteLine("[4] Quit the program");
                Console.Write("(1-4): ");
                sel = Console.ReadLine();
                Console.WriteLine();
                // If the input is not valid then tell the user
                if (!Regex.IsMatch(sel, "^[1-4]\\z")) {
                    Console.WriteLine("Input incorrect");
                    Console.WriteLine("Please enter an integer from 1 to 4\n");
                }
            } while (!Regex.IsMatch(sel, "^[1-4]\\z"));
            // returns the valid selection from the user
            return sel;
        }

        static string AddPlayer(int count) {
            string name, goals, yellow, red;
            if (count == 5) { // If the team is full then ask the user whether they should clear the team
                Console.WriteLine("Your team is full!");
                Console.WriteLine("Do you want to remove all players?");
                Console.Write("(Y/N): ");
                string sel = Console.ReadLine()?.ToUpper();
                Console.WriteLine();
                // "Y" and it happens, anything else they don't
                switch (sel) { 
                    case "Y":
                        File.Delete("FootballTeam.txt");
                        File.Create("FootballTeam.txt");
                        Console.WriteLine("Deleted all people");
                        return "0";
                    case "N":
                        Console.WriteLine("You won't be able to add new members until you remove all members");
                        return "5";
                    default:
                        Console.WriteLine("Not a valid option.");
                        Console.WriteLine("You won't be able to add new members until you remove all members");
                        return "5";
                }
            }
            // If the team has space, ask for details
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Number of goals: ");
            goals = Console.ReadLine();
            Console.Write("Enter Number of Yellow cards: ");
            yellow = Console.ReadLine();
            Console.Write("Enter Number of Red cards: ");
            red = Console.ReadLine();
            Console.WriteLine();
            // If goals, yellow and red aren't numbers then won't write it down
            if (!Regex.IsMatch(goals, "^[0-9]+\\z") || !Regex.IsMatch(yellow, "^[0-9]+\\z") ||
                !Regex.IsMatch(red, "^[0-9]+\\z")) {
                Console.WriteLine("One of the inputs are not in the correct format.");
                Console.WriteLine("Everything but the name should be a number.\n");
                return count.ToString();
            }
            // If they are then it will be recorded
            using StreamWriter SW = new StreamWriter("FootballTeam.txt", true);
            SW.WriteLine(name+"|"+goals+"|"+yellow+"|"+red);
            SW.Close();
            // Increments the count and sends that to the count file
            return (count + 1).ToString();
        }

        static void ViewTeam(int count) {
            // If theres nobody on the team, tell the user that
            if (count == 0) Console.WriteLine("There's no players on your team!\n");
            // Uses StreamReader to show each player on the team in a nice way
            using StreamReader SR = new StreamReader("FootballTeam.txt");
            while (SR.Peek() > -1) {
                string line = SR.ReadLine();
                string[] lines = line.Split('|');
                Console.WriteLine("====================");
                Console.WriteLine("Name: " + lines[0]);
                Console.WriteLine("Goals: " + lines[1]);
                Console.WriteLine("Yellow Cards: " + lines[2]);
                Console.WriteLine("Red Cards: " + lines[3]);
                Console.WriteLine("====================\n");
            }
            SR.Close();
        }

        static int TeamValue(int count) {
            // If there's nobody on the team then tell the user that
            if (count == 0) {
                Console.WriteLine("You have nobody on your team!\n");
                return 0;
            }
            // If the team isn't empty, use StreamReader to read the team file
            using StreamReader SR = new StreamReader("FootballTeam.txt");
            int goals = 0, yellow = 0, red = 0;
            // For each line in the file add the goals, yellow cards and red cards 
            while (SR.Peek() > 0) {
                string line = SR.ReadLine();
                string[] lines = line.Split('|');
                goals += int.Parse(lines[1]);
                yellow += int.Parse(lines[2]);
                red += int.Parse(lines[3]);
            }
            SR.Close();
            // Shows the user the totals of all, returns the calculated points
            Console.WriteLine($"Total goals scored: {goals}");
            Console.WriteLine($"Total yellow cards: {yellow}");
            Console.WriteLine($"Total goals scored: {red}\n");
            return 10 * goals - 2 * yellow - 5 * red;
        }
    }
}