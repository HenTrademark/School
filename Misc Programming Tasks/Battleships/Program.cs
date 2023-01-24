using System;
using System.Text.RegularExpressions;

namespace Battleships {
    internal class BoardFeatures {
        private static Random _rand = new Random();
        private static int _longestLength = 0;
        private static string[] _index = new string[] { "[0] ", "[1] ", "[2] ", "[3] ", "[4] ", "[5] ", "[6] ", "[7] ", "[8] ", "[9] " };
        
        public static int GetLength() { return _longestLength; }
        public static void PrintBoard(string[,] board) {
            Console.Write("-------");
            for (int x = 0; x < 10; x++) { // This makes the horizontal lines at the top
                for (int count = 0; count < _longestLength + 2; count++) {
                    Console.Write("-");
                }
                Console.Write("-");
            }
            Console.WriteLine();
            Console.Write("|     | ");
            for (int x = 0; x < 10; x++) { Console.Write("{0} | ",_index[x]); }
            Console.Write("\n");
            Console.Write("—------");
            for (int x = 0; x < 10; x++) { // This makes the horizontal lines under each grid space
                for (int count = 0; count < _longestLength + 2; count++) {
                    Console.Write("—");
                }
                Console.Write("-");
            }

            Console.Write("\n");
            for (int i = 0; i < 10; i++) { 
                Console.Write("| [{0}] | ",i);
                for (int x = 0; x < 10; x++) { Console.Write("{0} | ",board[i,x]); }
                Console.Write("\n");
                Console.Write("—------");
                for (int x = 0; x < 10; x++) { 
                    for (int count = 0; count < _longestLength + 2; count++) {
                        Console.Write("—");
                    }
                    Console.Write("-");
                }
                Console.Write("\n");
            }
        }
        public static void MakeBoard(string[,] board, int[] count) {
            bool validplace;

            for (int x = 0; x < count[0]; x++) {
                validplace = false;
                while (!validplace) {
                    int row = _rand.Next(10);
                    int col = _rand.Next(10);
                    int direction = _rand.Next(4);

                    switch (direction) {
                        case 0: // Up
                            if (row < 4 || board[row, col] != "" || board[row - 1, col] != "" ||
                                board[row - 2, col] != "" || board[row - 3, col] != "" || board[row - 4, col] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Carrier";
                            board[row - 1, col] = "Carrier";
                            board[row - 2, col] = "Carrier";
                            board[row - 3, col] = "Carrier";
                            board[row - 4, col] = "Carrier";
                            break;
                        case 1: // Right
                            if (col > 5 || board[row, col] != "" || board[row, col + 1] != "" ||
                                board[row, col + 2] != "" || board[row, col + 3] != "" || board[row, col + 4] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Carrier";
                            board[row, col + 1] = "Carrier";
                            board[row, col + 2] = "Carrier";
                            board[row, col + 3] = "Carrier";
                            board[row, col + 4] = "Carrier";
                            break;
                        case 2: // Down
                            if (row > 5 || board[row, col] != "" || board[row + 1, col] != "" ||
                                board[row + 2, col] != "" || board[row + 3, col] != "" || board[row + 4, col] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Carrier";
                            board[row + 1, col] = "Carrier";
                            board[row + 2, col] = "Carrier";
                            board[row + 3, col] = "Carrier";
                            board[row + 4, col] = "Carrier";
                            break;
                        case 3: // Left
                            if (col < 4 || board[row, col] != "" || board[row, col - 1] != "" ||
                                board[row, col - 2] != "" || board[row, col - 3] != "" || board[row, col - 4] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Carrier";
                            board[row, col - 1] = "Carrier";
                            board[row, col - 2] = "Carrier";
                            board[row, col - 3] = "Carrier";
                            board[row, col - 4] = "Carrier";
                            break;
                    }
                }
            }

            for (int x = 0; x < count[1]; x++) {
                validplace = false;
                while (!validplace) {
                    int row = _rand.Next(10);
                    int col = _rand.Next(10);
                    int direction = _rand.Next(4);

                    switch (direction) {
                        case 0: // Up
                            if (row < 3 || board[row, col] != "" || board[row - 1, col] != "" ||
                                board[row - 2, col] != "" || board[row - 3, col] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Destroyer";
                            board[row - 1, col] = "Destroyer";
                            board[row - 2, col] = "Destroyer";
                            board[row - 3, col] = "Destroyer";
                            break;
                        case 1: // Right
                            if (col > 6 || board[row, col] != "" || board[row, col + 1] != "" ||
                                board[row, col + 2] != "" || board[row, col + 3] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Destroyer";
                            board[row, col + 1] = "Destroyer";
                            board[row, col + 2] = "Destroyer";
                            board[row, col + 3] = "Destroyer";
                            break;
                        case 2: // Down
                            if (row > 6 || board[row, col] != "" || board[row + 1, col] != "" ||
                                board[row + 2, col] != "" || board[row + 3, col] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Destroyer";
                            board[row + 1, col] = "Destroyer";
                            board[row + 2, col] = "Destroyer";
                            board[row + 3, col] = "Destroyer";
                            break;
                        case 3: // Left
                            if (col < 3 || board[row, col] != "" || board[row, col - 1] != "" ||
                                board[row, col - 2] != "" || board[row, col - 3] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Destroyer";
                            board[row, col - 1] = "Destroyer";
                            board[row, col - 2] = "Destroyer";
                            board[row, col - 3] = "Destroyer";
                            break;
                    }
                }
            }

            for (int x = 0; x < count[2]; x++) {
                validplace = false;
                while (!validplace) {
                    int row = _rand.Next(10);
                    int col = _rand.Next(10);
                    int direction = _rand.Next(4);

                    switch (direction) {
                        case 0: // Up
                            if (row < 2 || board[row, col] != "" || board[row - 1, col] != "" ||
                                board[row - 2, col] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Ship";
                            board[row - 1, col] = "Ship";
                            board[row - 2, col] = "Ship";
                            break;
                        case 1: // Right
                            if (col > 7 || board[row, col] != "" || board[row, col + 1] != "" ||
                                board[row, col + 2] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Ship";
                            board[row, col + 1] = "Ship";
                            board[row, col + 2] = "Ship";
                            break;
                        case 2: // Down
                            if (row > 7 || board[row, col] != "" || board[row + 1, col] != "" ||
                                board[row + 2, col] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Ship";
                            board[row + 1, col] = "Ship";
                            board[row + 2, col] = "Ship";
                            break;
                        case 3: // Left
                            if (col < 2 || board[row, col] != "" || board[row, col - 1] != "" ||
                                board[row, col - 2] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Ship";
                            board[row, col - 1] = "Ship";
                            board[row, col - 2] = "Ship";
                            break;
                    }
                }
            }

            for (int x = 0; x < count[3]; x++) {
                validplace = false;
                while (!validplace) {
                    int row = _rand.Next(10);
                    int col = _rand.Next(10);
                    int direction = _rand.Next(4);

                    switch (direction) {
                        case 0: // Up
                            if (row < 1 || board[row, col] != "" || board[row - 1, col] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Patrol";
                            board[row - 1, col] = "Patrol";
                            break;
                        case 1: // Right
                            if (col > 8 || board[row, col] != "" || board[row, col + 1] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Patrol";
                            board[row, col + 1] = "Patrol";
                            break;
                        case 2: // Down
                            if (row > 8 || board[row, col] != "" || board[row + 1, col] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Patrol";
                            board[row + 1, col] = "Patrol";
                            break;
                        case 3: // Left
                            if (col < 1 || board[row, col] != "" || board[row, col - 1] != "") {
                                break;
                            }

                            validplace = true;
                            board[row, col] = "Patrol";
                            board[row, col - 1] = "Patrol";
                            break;
                    }
                }
            }

            string longest = "";
            for (int row = 0; row < 10; row++) {
                for (int col = 0; col < 10; col++) {
                    if (board[row, col].Length % 2 == 1) {
                        board[row, col] += " "; }
                    if (board[row, col].Length > longest.Length) {
                        longest = board[row, col]; }
                }
            }

            for (int row = 0; row < 10; row++) {
                for (int col = 0; col < 10; col++) {
                    while (board[row, col].Length < longest.Length) {
                        board[row, col] = " " + board[row, col] + " ";
                    }
                }

                while (_index[row].Length < longest.Length) {
                    _index[row] = " " + _index[row] + " ";
                }
            }
            
            _longestLength = longest.Length;
        }
    }
    internal class Robot {
        
        public static string[,] Bot = new string[,] { 
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" }
        };
        public static string[,] Board = new string[,] { // NOT USED UNTIL COMPUTER VS PLAYER
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" }
        };
        
        public static void MakeBoard(int[] count) {
            BoardFeatures.MakeBoard(Bot, count);
        }

        public static string GetSpace(int row, int col) {
            return Bot[row, col];
        }
    }

    internal class Player {
        private static int _uncovered = 0;
        private static int _score = 0;
        private static string[] _index = new string[] { "[0] ", "[1] ", "[2] ", "[3] ", "[4] ", "[5] ", "[6] ", "[7] ", "[8] ", "[9] " };
        public static string[,] Bot = new string[,] {
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" }
        };
        public static string[,] Board = new string[,] { // NOT USED UNTIL COMPUTER VS PLAYER
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "", "", "" }
        };
        
        static void PadBoard(string[,] board) {
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    if (board[i, j].Length % 2 == 1) {
                        board[i, j] += " ";
                    }

                    while (board[i, j].Length < BoardFeatures.GetLength()) {
                        board[i, j] = " " + board[i, j] + " ";
                    }
                }
            }
        }

        public static void MakeBoard(int[] count) {
            BoardFeatures.MakeBoard(Board, count);
        }

        private static void Sink() {
            string r, c;
            PadBoard(Bot);
            BoardFeatures.PrintBoard(Bot);
            do {
                Console.WriteLine("Pick a place to sink:");
                Console.Write("row: ");
                r = Console.ReadLine();
                Console.Write("column: ");
                c = Console.ReadLine();
                if (!(Regex.IsMatch(r ?? string.Empty, "^[0-9]$") &&
                      (Regex.IsMatch(c ?? string.Empty, "^[0-9]$")))) {
                    Console.WriteLine("One or more of the inputs are invalid");
                    Console.WriteLine("Please enter a valid place");
                }

                Console.WriteLine();
            } while (!(Regex.IsMatch(r ?? string.Empty, "^[0-9]$") &&
                       (Regex.IsMatch(c ?? string.Empty, "^[0-9]$"))));

            int row = int.Parse(r!), col = int.Parse(c!);

            if (Robot.GetSpace(row, col).Trim() == "") {
                Bot[row, col] = "X";
            }
            else {
                _score++;
                Bot[row, col] = Robot.GetSpace(row, col).Trim();
            }

            _uncovered++;
        }
        
        private static void Game() {
            while (_uncovered < 100) {
                Sink();
            }
            PadBoard(Bot);
            BoardFeatures.PrintBoard(Bot);
            Console.WriteLine("You won!");
            Console.WriteLine("You did it in {0} tries", _uncovered);
        }
        
        public static void Prerequisites() {
            string ships;
            Console.WriteLine("Welcome to Battleships!");
            Console.WriteLine("In this game you guess where the enemy ships are to sink them!");
            Console.WriteLine("\nIn this game there's a maximum and minimum amount of ships you can have");
            Console.WriteLine("    Carriers take up 5 spaces.    Max: 3.  Min: 1");
            Console.WriteLine("    Destroyers take up 4 spaces.  Max: 4.  Min: 1");
            Console.WriteLine("    Ships take up 3 spaces.       Max: 6.  Min: 1");
            Console.WriteLine("    Patrols take up 2 spaces.     Max: 9.  Min: 0\n");
            do {
                Console.WriteLine("Enter how many ships you want of each");
                Console.Write("(Enter in form: \"C,D,S,P\"): ");
                ships = Console.ReadLine();
                Console.WriteLine();
                if (!Regex.IsMatch(ships ?? string.Empty, "^[1-3],[1-4],[1-6],[0-9]$")) {
                    Console.WriteLine("Wrong format for imputting. Enter a valid imput\nExample: \"2,2,3,5\"\n");
                }
            } while (!Regex.IsMatch(ships ?? string.Empty, "^[1-3],[1-4],[1-6],[0-9]$"));

            int[] shipCounts = { int.Parse(ships![0].ToString()), int.Parse(ships![2].ToString()),
                int.Parse(ships![4].ToString()), int.Parse(ships![6].ToString()) };
            MakeBoard(shipCounts);
            Robot.MakeBoard(shipCounts);
            Game();
        }
    }
    internal class Program {
        static void Main(string[] args) { 
            Player.Prerequisites();
        }
    }
}
