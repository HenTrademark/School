using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace Program8_1 {
    class Program {
        static Random _rand = new Random();
        static int _com;
        static int _pla;
        static bool Menu() {
            Console.WriteLine("There is a game where you and the computer roll dice and whoever gets to 30 first wins");
            string ans = "";
            do {
                Console.WriteLine("Do you want to play?");
                Console.Write("(Y or N): ");
                ans = Console.ReadLine().ToUpper();
                if (!Regex.IsMatch(ans,"^(Y|N)$")) {
                    Console.WriteLine("\nInput not correct. Please enter \"Y\" or \"N\"\n");
                }
            } while (!Regex.IsMatch(ans,"^(Y|N)$"));

            if (ans == "Y") { PlayGame(); }

            return ans == "Y";
        }
        static void PlayGame() {
            int num;
            _com = 0;
            _pla = 0;
            if (_rand.Next(2) == 0) {
                Console.WriteLine("Computer goes first.\n");
                Console.Write("\nComputer is rolling now");
                for (int i = 0; i < 3; i++) {
                    Thread.Sleep(250); Console.Write(".");
                }
                num = RollDice();
                Console.WriteLine("\n\nComputer rolled a {0}",num);
                _com += num;
            }
            else { Console.WriteLine("You go first.\n"); }

            while (_com < 30 && _pla < 30) {
                Console.WriteLine("Scores: Player - {0}, Computer - {1}",_pla,_com);
                Console.WriteLine("Your turn!");
                Console.Write("Press ENTER to roll the dice");
                Console.ReadLine();
                num = RollDice();
                Console.WriteLine("You rolled a {0}!",num);
                _pla += num;
                if (_pla < 30) {
                    Console.WriteLine("Scores: Player - {0}, Computer - {1}",_pla,_com);
                    Console.Write("\nComputer is rolling now");
                    for (int i = 0; i < 3; i++) {
                        Thread.Sleep(250); Console.Write("."); }
                    num = RollDice();
                    Console.WriteLine("\n\nComputer rolled a {0}",num);
                    _com += num;
                }
            }
            string whowon = _com >= 30 ? "Computer won..." : "Player won!";
            Console.WriteLine(whowon);
        }
        static int RollDice() {
            return _rand.Next(1,7);
        }
        static void Main(string[] args) {
            bool play = Menu();
            if (play) {
                bool again = true;
                do {
                    string ans = "";
                    do {
                        Console.WriteLine("Do you want to play again?");
                        Console.Write("(Y or N): ");
                        ans = Console.ReadLine().ToUpper();
                        if (!Regex.IsMatch(ans,"^(Y|N)$")) {
                            Console.WriteLine("\nInput not correct. Please enter \"Y\" or \"N\"\n");
                        }
                    } while (!Regex.IsMatch(ans,"^(Y|N)$"));
                    again = ans == "Y";
                    if (again) { PlayGame(); }
                } while (again);
                Console.WriteLine("\nOkay, Good game!"); 
            } else { Console.WriteLine("Boo you're boring"); }
        }
    }
}