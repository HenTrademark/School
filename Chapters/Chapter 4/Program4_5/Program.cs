// This program asks a user whether they want to add items to their basket, and then inputs the price of the item if they say yes. When they have finished adding items the program should output how many items are in the basket and the total price for those items

using System;

namespace Program4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The Basket Program

            // Declaring variables
            char more = 'Y';
            int bask = 0;
            float price = 0f;
            do { // Asks if the person wants to add an item into the basket
                Console.WriteLine("Do you want to put an item in your basket? (Y/N)");
                more = char.Parse(Console.ReadLine().ToUpper());
                if (more == 'Y') { // If more is Y, asks for the price of the item
                    Console.WriteLine("What is the price of your item?");
                    price += float.Parse(Console.ReadLine());
                    bask++;
                }
            } while (more == 'Y'); // Says the items in the basket and rounds it to 2DP (for £)
            Console.WriteLine("You have {0} item(s) in your basket, and its value is £{1}",bask,Math.Round(price,2));
        }
    }
}
