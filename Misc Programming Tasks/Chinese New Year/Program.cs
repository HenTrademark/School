using System;

namespace Chinese_New_Year
{
    internal class Program
    {
        public static bool validation(int day, int month, int year) {
            bool leap; // Checks if the year is a leap year
            if (year % 4 == 0) { // If the year is divisible by 4 it is a leap year
                if (year % 100 == 0) { // If also divisible by 100 it isn't one
                    if (year % 400 == 0) { // If also divisible by 400 then it is
                        leap = true;
                    } // Div by 4 and 100 but not 400 it isn't
                    else { leap = false; }
                } // Div by 4 but not 100 it is
                else { leap = true; } 
            } // Not div by 4
            else { leap = false; }

            if (month < 1 || month > 12) {
                return false; // Checks the month 1 <= month <= 12
            }

            if (day < 1) { return false; } // Checks the day is 1<=
            
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) {
                if (day > 31) { return false; } // Checks the months Jan, Mar, May, Jul, Aug, Oct, and Dec for the day to be <=31
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11) {
                if (day > 30) { return false; } // Checks the months Apr, Jun, Sep, and Nov for the day to be <=30
            }
            else { // Checks for Feb depending on whether the year is a leap year or not
                if (leap) { // On leap years Feb has 29 days
                    if (day > 29) { return false; }
                }
                else { // On non-leap years Feb has 28 days
                    if (day > 28) { return false; }
                }
            }

            // If after all that it hasn't come out as false, then:
            return true;
        }
        static void Main(string[] args)
        {
            // Declaring variables
            string DOB;
            int DOByear;
            int modYear;
            int DOBmonth;
            int DOBday;

            string Animal = null;
            string Sign = null;

            // Getting the details out of the user
            Console.WriteLine("What is your birthdate?");
            Console.Write("Please put answer in the form (DD/MM/YYYY): ");
            DOB = Console.ReadLine();
            DOBday = Convert.ToInt32(DOB.Substring(0,2));
            DOBmonth = Convert.ToInt32(DOB.Substring(3, 2));
            DOByear = Convert.ToInt32(DOB.Substring(6));
            Console.WriteLine();

            // Validation
            if (validation(DOBday,DOBmonth,DOByear) == false) {
                Console.WriteLine("Not a valid day/month/year.");
            }
            else { // If valid, then go on with the program
                // Zodiac sign
                modYear = (DOByear - 1900) % 12;
                if (modYear == 0) { Animal = "Rat"; }
                else if (modYear == 1)  { Animal = "Ox"; }
                else if (modYear == 2)  { Animal = "Tiger"; }
                else if (modYear == 3)  { Animal = "Rabbit"; }
                else if (modYear == 4)  { Animal = "Dragon"; }
                else if (modYear == 5)  { Animal = "Snake"; }
                else if (modYear == 6)  { Animal = "Horse"; }
                else if (modYear == 7)  { Animal = "Goat"; }
                else if (modYear == 8)  { Animal = "Monkey"; }
                else if (modYear == 9)  { Animal = "Rooster"; }
                else if (modYear == 10) { Animal = "Dog"; }
                else if (modYear == 11) { Animal = "Pig"; }

                // Western astrological sign
                if ((DOBmonth == 3 && DOBday >= 21) || (DOBmonth == 4 && DOBday <= 19)) { Sign = "Aries"; }
                else if ((DOBmonth == 4 && DOBday >= 20) || (DOBmonth == 5 && DOBday <= 20)) { Sign = "Taurus"; }
                else if ((DOBmonth == 5 && DOBday >= 21) || (DOBmonth == 6 && DOBday <= 20)) { Sign = "Gemini"; }
                else if ((DOBmonth == 6 && DOBday >= 21) || (DOBmonth == 7 && DOBday <= 22)) { Sign = "Cancer"; }
                else if ((DOBmonth == 7 && DOBday >= 23) || (DOBmonth == 8 && DOBday <= 22)) { Sign = "Leo"; }
                else if ((DOBmonth == 8 && DOBday >= 23) || (DOBmonth == 9 && DOBday <= 22)) { Sign = "Virgo"; }
                else if ((DOBmonth == 9 && DOBday >= 23) || (DOBmonth == 10 && DOBday <= 22)) { Sign = "Libra"; }
                else if ((DOBmonth == 10 && DOBday >= 23) || (DOBmonth == 11 && DOBday <= 21)) { Sign = "Scorpio"; }
                else if ((DOBmonth == 11 && DOBday >= 22) || (DOBmonth == 12 && DOBday <= 21)) { Sign = "Sagittarius"; }
                else if ((DOBmonth == 12 && DOBday >= 22) || (DOBmonth == 1 && DOBday <= 19)) { Sign = "Capricorn"; }
                else if ((DOBmonth == 1 && DOBday >= 20) || (DOBmonth == 2 && DOBday <= 18)) { Sign = "Aquarius"; }
                else if ((DOBmonth == 2 && DOBday >= 19) || (DOBmonth == 3 && DOBday <= 20)) { Sign = "Pisces"; }

                Console.WriteLine("You were born in the year of the {0}", Animal);
                Console.WriteLine("Your star sign is: {0}",Sign);
            }
        }
    }
}
