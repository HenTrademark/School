using System;

namespace Program3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring the variables
            const float ST = 0.9f;   // Student discount      10.0%
            const float SN = 0.875f; // Senior discount       12.5%
            const float CH = 0.8f;   // Cardholder discount   20.0%
            const float CN = 0.925f; // Discount voucher       7.5%

            float cost;
            string discount, discountType;

            // Gets the price from the user
            Console.WriteLine("What is the price of your goods?");
            cost = float.Parse(Console.ReadLine());

            // Asks whether they can recieve a discount
            Console.WriteLine("Are you entitled to a concession discount? (Y/N)");
            discount = Console.ReadLine().ToUpper();
            if (discount == "N") // If not, the program prints the price normally
            {
                Console.WriteLine("The price of your goods without any discount is {0}",cost);
            }
            else if (discount == "Y")
            {
                // Gets the type of discount they want
                Console.WriteLine("Please state your concession type:");
                Console.WriteLine("   Enter ST if you are a student");
                Console.WriteLine("   Enter SN if you are a senior citizen");
                Console.WriteLine("   Enter CH if you are a cardholder");
                Console.WriteLine("   Enter CN if you have a discount voucher");
                discountType = Console.ReadLine();

                switch (discountType) // Switches depending on what type of discount it is
                {
                    case "ST":
                        cost *= ST;
                        Console.WriteLine("The price of your goods with a student's discount is {0}",cost);
                        break;
                    case "SN":
                        cost *= SN;
                        Console.WriteLine("The price of your goods with a senior's discount is {0}", cost);
                        break;
                    case "CH":
                        cost *= CH;
                        Console.WriteLine("The price of your goods with a cardholder's discount is {0}", cost);
                        break;
                    case "CN":
                        cost *= CN;
                        Console.WriteLine("The price of your goods with a discount voucher is {0}", cost);
                        break;
                    default: // If none of these, the program prints the price normally
                        Console.WriteLine("Not a valid input");
                        Console.WriteLine("The price of your goods without any discount is {0}", cost);
                        break;

                }

            }
            else // If the input isn't "Y" or "N", the program prints the price normally
            {
                Console.WriteLine("Not a valid input");
                Console.WriteLine("The price of your goods without any discount is {0}", cost);
            }
            
        }
    }
}
