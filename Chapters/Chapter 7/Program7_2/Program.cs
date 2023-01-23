using System;

namespace Program7_2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello and welcome to the Space Wars Naming program!");
            string first, last, mother, city, firstspace, lastspace;
            // Getting the names
            Console.Write("Please enter your first name: ");
            first = Console.ReadLine().ToLower();
            Console.Write("Please enter your last name: ");
            last = Console.ReadLine().ToLower();
            Console.Write("Please enter your mother's first name: ");
            mother = Console.ReadLine().ToLower();
            Console.Write("Please enter the city you were born in: ");
            city = Console.ReadLine().ToLower();
            Console.WriteLine();
            // Getting the spacenames
            firstspace = last.Substring(0,3) + first.Substring(0,2);
            lastspace = mother.Substring(0,2) + city.Substring(0,3);
            // Turning the first letter into a capital letter then outputting it
            char x = (char)((int)firstspace[0] - 32);
            char y = (char)((int)lastspace[0] - 32);
            string space1 = x + firstspace.Substring(1);
            string space2 = y + lastspace.Substring(1);
            Console.Write("Your space name is: {0} {1}",space1,space2);
        }
    }
}
// 