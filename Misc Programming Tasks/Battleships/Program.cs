using System;
using System.Text.RegularExpressions;

namespace Battleships {
    internal class BoardFeatures {
        private static Random _rand = new Random();
        private static int _longestLength = 0;
        private static string[] _index = new string[] { "[0] ", "[1] ", "[2] ", "[3] ", "[4] ", "[5] " };
        public static int GetLength() { return _longestLength; }
        public static void PrintBoard(string[,] board) {
            Console.Write("-------");
            for (int x = 0; x < 6; x++) { // This makes the horizontal lines at the top
                for (int count = 0; count < _longestLength + 2; count++) {
                    Console.Write("-");
                }
                Console.Write("-");
            }
            Console.WriteLine();
            Console.Write("|     | ");
            for (int x = 0; x < 6; x++) { Console.Write("{0} | ",_index[x]); }
            Console.Write("\n");
            Console.Write("—------");
            for (int x = 0; x < 6; x++) { // This makes the horizontal lines under each grid space
                for (int count = 0; count < _longestLength + 2; count++) {
                    Console.Write("—");
                }
                Console.Write("-");
            }

            Console.Write("\n");
            for (int i = 0; i < 6; i++) { 
                Console.Write("| [{0}] | ",i);
                for (int x = 0; x < 6; x++) { Console.Write("{0} | ",board[i,x]); }
                Console.Write("\n");
                Console.Write("—------");
                for (int x = 0; x < 6; x++) { 
                    for (int count = 0; count < _longestLength + 2; count++) {
                        Console.Write("—");
                    }
                    Console.Write("-");
                }
                Console.Write("\n");
            }
        }
        public static void MakeBoard(string[,] board) {
            bool validplace = false;
            while (!validplace) {
                int row = _rand.Next(6);
                int col = _rand.Next(6);
                int direction = _rand.Next(4);

                switch (direction) {
                    case 0: // Up
                        if (row < 2) { break; }

                        validplace = true;
                        board[row, col] = "Carrier";
                        board[row - 1, col] = "Carrier";
                        board[row - 2, col] = "Carrier";
                        break;
                    case 1: // Right
                        if (col > 3) { break; }
                        validplace = true;
                        board[row, col] = "Carrier";
                        board[row, col + 1] = "Carrier";
                        board[row, col + 2] = "Carrier";
                        break;
                    case 2: // Down
                        if (row > 3) { break; }
                        validplace = true;
                        board[row, col] = "Carrier";
                        board[row + 1, col] = "Carrier";
                        board[row + 2, col] = "Carrier";
                        break;
                    case 3: // Left
                        if (col < 2) { break; }
                        validplace = true;
                        board[row, col] = "Carrier";
                        board[row, col - 1] = "Carrier";
                        board[row, col - 2] = "Carrier";
                        break;
                }
            }
            
            validplace = false;
            while (!validplace) {
                int row = _rand.Next(6);
                int col = _rand.Next(6);
                int direction = _rand.Next(4);

                switch (direction) {
                    case 0: // Up
                        if (row < 1 || board[row,col] != "" || board[row - 1,col] != "") { break; }
                        validplace = true;
                        board[row, col] = "Destroyer";
                        board[row - 1, col] = "Destroyer";
                        break;
                    case 1: // Right
                        if (col > 4 || board[row,col] != "" || board[row,col + 1] != "") { break; }
                        validplace = true;
                        board[row, col] = "Destroyer";
                        board[row, col + 1] = "Destroyer";
                        break;
                    case 2: // Down
                        if (row > 4 || board[row,col] != "" || board[row + 1,col] != "") { break; }
                        validplace = true;
                        board[row, col] = "Destroyer";
                        board[row + 1, col] = "Destroyer";
                        break;
                    case 3: // Left
                        if (col < 1 || board[row,col] != "" || board[row,col - 1] != "") { break; }
                        validplace = true;
                        board[row, col] = "Destroyer";
                        board[row, col - 1] = "Destroyer";
                        break;
                }
            }
            
            validplace = false;
            while (!validplace) {
                int row = _rand.Next(6);
                int col = _rand.Next(6);

                if (board[row, col] == "") {
                    validplace = true;
                    board[row, col] = "Patrol";
                }
            }
            
            validplace = false;
            while (!validplace) {
                int row = _rand.Next(6);
                int col = _rand.Next(6);

                if (board[row, col] == "") {
                    validplace = true;
                    board[row, col] = "Ship";
                }
            }

            string longest = "";
            for (int row = 0; row < 6; row++) {
                for (int col = 0; col < 6; col++) {
                    if (board[row, col].Length % 2 == 1) {
                        board[row, col] += " "; }
                    if (board[row, col].Length > longest.Length) {
                        longest = board[row, col]; }
                }
            }

            for (int row = 0; row < 6; row++) {
                for (int col = 0; col < 6; col++) {
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
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" }
        };
        public static string[,] Board = new string[,] { // NOT USED UNTIL COMPUTER VS PLAYER
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" }
        };
        
        public static void MakeBoard() {
            BoardFeatures.MakeBoard(Bot);
        }

        public static string GetSpace(int row, int col) {
            return Bot[row, col];
        }
    }

    internal class Player {
        private static int _score = 0;
        private static string[] _index = new string[] { "[0] ", "[1] ", "[2] ", "[3] ", "[4] ", "[5] " };
        public static string[,] Bot = new string[,] {
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" }
        };
        public static string[,] Board = new string[,] {
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" },
            { "", "", "", "", "", "" }
        };
        
        static void PadBoard(string[,] board) {
            for (int i = 0; i < 6; i++) {
                for (int j = 0; j < 6; j++) {
                    if (board[i, j].Length % 2 == 1) {
                        board[i, j] += " ";
                    }

                    while (board[i, j].Length < BoardFeatures.GetLength()) {
                        board[i, j] = " " + board[i, j] + " ";
                    }
                }
            }
        }
        public static void MakeBoard() {
            BoardFeatures.MakeBoard(Board);
        }
        public static void Prerequisites() {
            MakeBoard();
            Robot.MakeBoard();
            Game();
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
                if (!(Regex.IsMatch(r ?? string.Empty, "^[0-5]$") &&
                      (Regex.IsMatch(c ?? string.Empty, "^[0-5]$")))) {
                    Console.WriteLine("One or more of the inputs are invalid");
                    Console.WriteLine("Please enter a valid place");
                }

                Console.WriteLine();
            } while (!(Regex.IsMatch(r ?? string.Empty, "^[0-5]$") &&
                       (Regex.IsMatch(c ?? string.Empty, "^[0-5]$"))));

            int row = int.Parse(r!), col = int.Parse(c!);

            if (Robot.GetSpace(row, col).Trim() == "") {
                Bot[row, col] = "X";
            }
            else {
                _score++;
                Bot[row, col] = Robot.GetSpace(row, col).Trim();
            }
        }
        
        private static void Game() {
            while (_score < 7) {
                Sink();
            }
            PadBoard(Bot);
            BoardFeatures.PrintBoard(Bot);
            Console.WriteLine("You won!");
        }
    }
    internal class Program {
        static void Main(string[] args) { 
            Player.Prerequisites();
        }
    }
}
