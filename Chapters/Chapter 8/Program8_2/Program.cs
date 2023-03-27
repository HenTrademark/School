// I didn't like the way that the original table looked so I made a new one

using System;
using System.Text.RegularExpressions;

namespace Program8_2 {
    class Program {
        static void Main(string[] args) {
            //  Defines the 2 boards. "board" -> background board, "Board" -> visible board
            char[,] board = new char[10, 10], Board = new char[10, 10];
            // Defines the point counter
            int points = 0, row = 0, col = 0;
            // Gives both boards appropriate values to play the game
            MakeBoard(board, Board);
            // Repeats 10 times or until all 6 treasure plots have been uncovered
            for (int i = 0; i < 10 && points < 60; i++) {
                // Prints the board
                PrintBoard(Board);
                // Gets valid plot coordinates and stores them in the array
                Validation(ref row, ref col);
                // With the information gotten, calculates whether the user gets points or not
                CalculatePoints(row, col, board, Board, ref points, ref i);
            }
            // Prints the board
            PrintBoard(Board);
            // Validates whether the user won or lost, then writes the points they got
            string writeline = points == 60 ? "\nYou won!" : "\nYou lost...";
            Console.WriteLine(writeline);
            Console.WriteLine("You got {0} points",points);
        }

        static void CalculatePoints(int row, int col, char[,] board, char[,] Board, ref int points, ref int i) {
            // If the user already picked the plot before
            if (Board[row, col] != ' ') {
                Console.WriteLine("You've already picked that plot! ");
                // Gives a go back to the user, but keeps the points the same
                i--;
            }
            // If the user picks a plot with treasure
            else if (board[row, col] == 'T') {
                Console.WriteLine("You found treasure! Added 10 points");
                // Update the visible board
                Board[row, col] = 'T';
                // Give the user 10 points
                points += 10;
            }
            else{
                // If anything else happens (i.e. Picked a new plot without treasure)
                Console.WriteLine("Missed the treasure...");
                // Update visible board
                Board[row, col] = 'X';
                // No points, no retry
            }
        }

        static void Validation(ref int row, ref int col) {
            // Defines a row and col placeholder string for inputs
            string strrow = "", strcol = "";
            do {
                // Takes inputs for row and col
                Console.Write("Enter a row number: ");
                strrow = Console.ReadLine();
                Console.Write("Enter a column number: ");
                strcol = Console.ReadLine();
                Console.WriteLine();
                // If either of them are not in the right format (any integer from 0 to 9), tells them that
                if (!Regex.IsMatch(strrow, "^[0-9]\\z") || !Regex.IsMatch(strcol, "^[0-9]\\z")) {
                    Console.WriteLine("Invalid input detected");
                    Console.WriteLine("Please enter a integer from 0 to 9\n");
                }
            } while (!Regex.IsMatch(strrow, "^[0-9]\\z") || !Regex.IsMatch(strcol, "^[0-9]\\z"));
            // sets the row and col to the valid inputs
            row = int.Parse(strrow);
            col = int.Parse(strcol);
        }

        static void MakeBoard(char[,] board, char[,] Board) {
            // Sets every character in both "board" and "Board" to ' '
            for (int a = 0; a < 10; a++) {
                for (int b = 0; b < 10; b++) {
                    board[a,b] = ' ';
                    Board[a,b] = ' ';
                }
            }
            // For "board", places 'T' in 6 random places
            Random r = new Random();
            int row = 0, col = 0;
            for (int i = 0; i < 6; i++) {
                row = r.Next(10);
                col = r.Next(10);
                if (board[row, col] == ' ') { board[row, col] = 'T'; }
                else { i--; }
            }
            
        }

        static void PrintBoard(char[,] board) {
            // Builds the board
            Console.WriteLine("  || 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |");
            Console.WriteLine("============================================");
            for (int i = 0; i < 10; i++) {
                Console.Write("{0} ||",i);
                for (int j = 0; j < 10; j++) {
                    Console.Write(" {0} |",board[i,j]);
                }
                Console.WriteLine("\n--------------------------------------------");
            }
        }
    }
}