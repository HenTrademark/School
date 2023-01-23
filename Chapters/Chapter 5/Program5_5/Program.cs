using System;
using System.Linq;

namespace Program5_5 {
    internal class Program {
        public struct Superheroes { // New record (structure in C#) with the given 
            public string name;
            public string skill;
            public int lifespan;
            public int strength;
            public float speed;
        }
        static void Main(string[] args) {
            Superheroes[] Superheroes = new Superheroes[0];
            Console.Write("Do you want to create a superhero? (Y/N): ");
            char sel = char.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine();
            if (sel == 'Y') {
                Console.WriteLine("Each superhero has:");
                Console.WriteLine("  An awesome superhero name");
                Console.WriteLine("  A special skill");
                Console.WriteLine("  A lifespan rating (How long they live)");
                Console.WriteLine("  A strength rating (How strong they are)");
                Console.WriteLine("  A speed rating (How fast they are)\n");
                Console.WriteLine("Let's make your first superhero!");
                for (int i = 0; sel == 'Y'; i++) {
                    Array.Resize(ref Superheroes,Superheroes.Length + 1); // Adds 1 to the superheroes array
                    Console.Write("\n\nEnter your superhero's name: ");
                    Superheroes[i].name = Console.ReadLine(); // Gets the name
                    Console.Write("\nEnter your superhero's skill: ");
                    Superheroes[i].skill = Console.ReadLine(); // Gets the skill
                    if (Superheroes.Length == 1) { 
                        // This is the briefing on how the numbered attributes work. Shown once on the first superhero making.
                        Console.WriteLine("\nSuperheroes have to have ratings so they don't get too overpowered");
                        Console.WriteLine("The ratings they need to have are as follows:");
                        Console.WriteLine("  How long the superhero lives (whole number out of 100)");
                        Console.WriteLine("  How strong the superhero is (whole number out of 100)");
                        Console.WriteLine("  How long the superhero lives (decimal number out of 10.0)");
                    }
                    bool valid = false;
                    while (valid == false) { // Repeats until a valid input is typed in
                        Console.Write("\nEnter your superhero's lifespan: ");
                        Superheroes[i].lifespan = int.Parse(Console.ReadLine()); // Gets the lifespan
                        if (Superheroes[i].lifespan < 0 || Superheroes[i].lifespan > 100) {
                            Console.WriteLine("Not a valid input. Number should be between 0 and 100");
                        } // If strength is invalid then user gets to try again, else valid is true
                        else { valid = true; }
                    }
                    valid = false; // Yes the same variable for each checked one 
                    while (valid == false) { // Repeats until a valid input is typed in
                        Console.Write("\nEnter your superhero's strength: ");
                        Superheroes[i].strength = int.Parse(Console.ReadLine()); // Gets the lifespan
                        if (Superheroes[i].strength < 0 || Superheroes[i].strength > 100) {
                            Console.WriteLine("Not a valid input. Number should be between 0 and 100");
                        } // If strength is invalid then user gets to try again, else valid is true
                        else { valid = true; }
                    }
                    valid = false; // Yes the same variable for each checked one 
                    while (valid == false) { // Repeats until a valid input is typed in
                        Console.Write("\nEnter your superhero's speed: ");
                        Superheroes[i].speed = float.Parse(Console.ReadLine()); // Gets the speed
                        if (Superheroes[i].speed < 0 || Superheroes[i].speed > 10) {
                            Console.WriteLine("Not a valid input. Number should be between 0 and 10");
                        } // If strength is invalid then user gets to try again, else valid is true
                        else { valid = true; }
                    }
                    Console.WriteLine();
                    if (Superheroes.Length == 1) {
                        // This is the briefing on how the numbered attributes work. Shown once on the first superhero making.
                        Console.WriteLine("And that's it! You've made your first superhero!");
                    }
                    Console.Write("Would you like to make another superhero? (Y/N): ");
                    sel = char.Parse(Console.ReadLine().ToUpper());
                }
                Console.WriteLine("\n\n");
                for (int i = 0; i < Superheroes.Length; i++) {
                    Console.WriteLine("Superhero {0}: {1}!",i+1,Superheroes[i].name);
                    Console.WriteLine(" Super Skill: {0}",Superheroes[i].skill);
                    Console.WriteLine(" Lifespan rating: {0}/100",Superheroes[i].lifespan);
                    Console.WriteLine(" Strength rating: {0}/100",Superheroes[i].strength);
                    Console.WriteLine(" Speed rating: {0}/10\n",Superheroes[i].speed);
                    Console.WriteLine("====================\n");
                }
                // Make a grid of superheroes
            }
            else {
                if (sel != 'N') { Console.WriteLine("\nInvalid input"); }
                Console.WriteLine("Alright, no superheroes");
               
            }
        }
    }
}
