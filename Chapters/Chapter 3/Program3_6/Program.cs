using System;

namespace Program3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring the variables
            string postcode;
            int AgeInYears;
            String Name;
            const float BasicPremium = 330f;
            float price;



            Console.WriteLine(" INSURANCE QUOTE");

            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine();

            // Gets the name of the user
            Console.WriteLine("Please enter your name");
            Name = Console.ReadLine();
            Console.WriteLine();

            // Gets the age of the user
            Console.WriteLine("Please enter your age in years");
            AgeInYears = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            // Gets the postcode area of the user
            Console.WriteLine("Enter the postcode area e.g ST");
            postcode = Console.ReadLine();
            Console.WriteLine();

            // Addresses the user by name
            Console.WriteLine("Hello, " + Name);
            Console.WriteLine();

            // Sets the price to the Basic Premium
            price = BasicPremium;

            if (AgeInYears < 25)
            { // If they are under 25 then premium is doubled
                Console.WriteLine("You're under 25 years old");
                Console.WriteLine("Ooops, you may have a lot of insurance to pay");
                Console.WriteLine("This doubles your premium");
                Console.WriteLine();
                price *= 2;
                
            }

            if (postcode == "ST")
            { // If postcode area is ST then they are local, giving a 10% discount
                Console.WriteLine("You live in the \"ST\" area");
                Console.WriteLine("Excellent, insurance in this area is lower than average");
                Console.WriteLine("This gives you a 10% discount off of your premium");
                Console.WriteLine();
                price *= 0.9f;
            }
            else
            { // Else they don't live in a discounted area and they don't get a discounted area
                Console.WriteLine("It looks like you don’t live in a discounted area");
                Console.WriteLine();
            }

            // After all of that, the code prints out the new premium
            Console.WriteLine("You have to pay £{0} for your insurance",price);
            Console.ReadLine();
        }
    }
}
