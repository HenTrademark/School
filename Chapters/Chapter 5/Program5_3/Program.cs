// Outputs the 2D array (from Program 5.3) into a grid

using System;

namespace Program5_3
{
    internal class Program
    {
        static void Main(string[] args)
        { //        (Second index)   ->           [0]         [1]      [2]    [3]    [4]      [5]         (First Index) 
            string[,] Board = new string[,] { { "Patrol", "",          "",   "",     "",   ""        }, //     [0]
                                              { "",       "",          "",   "Ship", "",   ""        }, //     [1]
                                              { "",       "",          "",   "",     "",   "Carrier" }, //     [2]
                                              { "",       "Destroyer", "",   "",     "",   "Carrier" }, //     [3]
                                              { "",       "Destroyer", "",   "",     "",   "Carrier" }, //     [4]
                                              { "",       "",          "",   "",     "",   ""        } }; //   [5]
            string[] index = new string[] { "[0]", "[1]", "[2]", "[3]", "[4]", "[5]" };

            // Pads each item in the second index to be as big as the longest one in the board
            string longest = Board[0,0];
            for (int x = 0; x < 6; x++ ) { // i is the fist index, x is the second index
                for (int i = 0; i < 6; i++) { // Checks for the longest item
                    /*  If the current item's length is bigger than the current longest,
                        This sets the longest item to be that current item  */
                    if (Board[i,x].Length > longest.Length) { longest = Board[i,x]; }
                }
            }
            // If longest.Length is odd, make it even by adding 1 space
            if (longest.Length % 2 == 1) { longest += " "; }
            for (int x = 0; x < 6; x++) {
                for (int i = 0; i < 6; i++) { // Pads the items with spaces to match the lengths
                    // If Board[i,x].Length is odd, make it even by adding 1 space (same as longest)
                    if (Board[i,x].Length % 2 == 1) { Board[i,x] += " "; }
                    while (Board[i,x].Length < longest.Length) { 
                        // Pad with spaces to the front and back until the same length as longest
                        Board[i,x] = " " + Board[i,x] + " "; 
                    }
                }
                // Seperate thing for the indexes
                index[x] = index[x] + " ";
                while (index[x].Length < longest.Length) {
                    // Pad with spaces to the front and back until the same length as longest
                    index[x] = " " + index[x] + " ";
                }
            }

            // Making the grid
            Console.WriteLine("The grid:\n");
            Console.Write("-------");
            for (int x = 0; x < 6; x++) { // This makes the horizontal lines at the top
                for (int count = 0; count < longest.Length + 2; count++) {
                    Console.Write("-");
                }
                Console.Write("-");
            }
            Console.WriteLine();
            Console.Write("|     | ");
            for (int x = 0; x < 6; x++) { Console.Write("{0} | ",index[x]); }
            Console.Write("\n");
            Console.Write("—------");
            for (int x = 0; x < 6; x++) { // This makes the horizontal lines under each grid space
                for (int count = 0; count < longest.Length + 2; count++) {
                    Console.Write("—");
                }
                Console.Write("-");
            }

            Console.Write("\n");
            for (int i = 0; i < 6; i++) { // As before, i is the first index, and x is the second
                /*  Console.Write() writes something on the same line, while .WriteLine() goes to the next line
                    The combination of these .Write() statements will make a grid-like shape    */
                Console.Write("| [{0}] | ",i);
                for (int x = 0; x < 6; x++) { Console.Write("{0} | ",Board[i,x]); }
                Console.Write("\n");
                Console.Write("—------");
                for (int x = 0; x < 6; x++) { // This makes the horizontal lines under each grid space
                    for (int count = 0; count < longest.Length + 2; count++) {
                        Console.Write("—");
                    }
                    Console.Write("-");
                }
                Console.Write("\n");
            }
        }
    }
}
