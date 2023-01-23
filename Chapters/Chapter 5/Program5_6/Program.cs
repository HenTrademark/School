using System;


namespace Program5_6 {
    internal class Program {
        public struct Fruits {
            public char identifier;
            public string name;
            public int value;
        }
        static void Main(string[] args) {
            char[,] grid = new char[,] { { ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' }, // Each one has a space as a placeholder character
                                         { ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                                         { ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                                         { ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                                         { ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                                         { ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                                         { ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                                         { ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                                         { ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                                         { ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' } };

            Random rnd = new Random();

            Fruits[] fruits = new Fruits[7]; // Making the fruits array below
            fruits[0].identifier = 'A'; fruits[0].name = "Apple"; fruits[0].value = rnd.Next(21);
            fruits[1].identifier = 'B'; fruits[1].name = "Banana"; fruits[1].value = rnd.Next(21);
            fruits[2].identifier = 'C'; fruits[2].name = "Cranberry"; fruits[2].value = rnd.Next(21);
            fruits[3].identifier = 'O'; fruits[3].name = "Orange"; fruits[3].value = rnd.Next(21);
            fruits[4].identifier = 'R'; fruits[4].name = "Rasberry"; fruits[4].value = rnd.Next(21);
            fruits[5].identifier = 'S'; fruits[5].name = "Strawberry"; fruits[5].value = rnd.Next(21);
            fruits[6].identifier = 'G'; fruits[6].name = "Grape"; fruits[6].value = rnd.Next(21);

            for (int i = 0; i < 7; i++) { // Repeats 7 times for 7 fruits
                bool done = false; // Control variable 
                while (done == false) {
                    int x = rnd.Next(10);
                    int y = rnd.Next(10);
                    if (grid[x,y] == ' ') { // If the space is empty add the fruit
                        grid[x,y] = fruits[i].identifier;
                        done = true;
                    } // Otherwise repeat and pick a different space
                }
            }
            Console.WriteLine("The grid\n"); // The building process
            Console.WriteLine("   || 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 ");
            Console.WriteLine("===||===|===|===|===|===|===|===|===|===|===");
            for (int i = 0; i < 10; i++) { // Builds the grid line by line, going row by row through the arrays
                Console.WriteLine(" {10} || {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} "
                    ,grid[i,0],grid[i,1],grid[i,2],grid[i,3],grid[i,4],grid[i,5],grid[i,6],grid[i,7],grid[i,8],grid[i,9],i);
            }

            int total = 0;
            for (int i = 0; i < 7; i++) { // Repeats 7 times for 7 fruits
                total += fruits[i].value;
            } // Totals up the score of all of the fruits
            Console.WriteLine("\nTotal value of all fruits: {0}",total);

            int row = 0, column = 0;
            Console.Write("\nDo you want to search for a fruit? (Y/N): ");
            char sel = char.Parse(Console.ReadLine().ToUpper());
            if (sel == 'Y') {
                while (sel == 'Y') {
                    bool valid = false; // Control variable
                    Console.WriteLine("\nSearch for a fruit");
                    while (valid == false) { // Asks for a row and column index until a valid input is put in
                        Console.Write("  Enter the row index: ");
                        row = int.Parse(Console.ReadLine());
                        Console.Write("  Enter the column index: ");
                        column = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (row < 0 || row > 9 || column < 0 || column > 9 ) { // Checks if it is valid
                            Console.WriteLine("Invalid input(s). Numbers have to be between 0 and 9\n");
                        }
                        else { valid = true; }
                    }

                    int index = -1;
                    for (int i = 0; i < 7 && index < 0; i++) { // If there is a fruit then save the index
                        if (fruits[i].identifier == grid[row,column]) { index = i; }
                    } // If the index is still -1, the program didn't find a fruit
                    if (index == -1) { Console.WriteLine("There is no fruit in this plot."); }
                    else { // Shows the details if prompted
                        Console.WriteLine("The letter stored here is: {0}\n" +
                                          "The fruit name is: {1}\n" +
                                          "The value of this fruit is: {2}\n"
                                          ,fruits[index].identifier,fruits[index].name,fruits[index].value);
                    }

                    Console.Write("\nDo you want to search for another fruit? (Y/N): ");
                    sel = char.Parse(Console.ReadLine().ToUpper());
                }// If they don't want to search for another fruit, it ends the program
                if (sel != 'N') { Console.WriteLine("Invalid input"); }
                Console.WriteLine("\nEnding program");
            }
            else { // If they don't want to search for a fruit, it ends the program
                if (sel != 'N') { Console.WriteLine("Invalid input"); }
                Console.WriteLine("\nEnding program");
            }

        }
    }
}
