using System;

namespace DataStructuresTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            int total = 0;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter an integer:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nNumbers in reverse order:  ");
            for (int i = 5; i > -1; i--)
            {
                Console.Write("{0}  ",numbers[i]);
                total += numbers[i];
            }
            Console.WriteLine();
            Console.WriteLine("The total of your numbers is: {0}", total);
            float avg = float.Parse(total.ToString()) / 6;
            Console.WriteLine("The average of your numbers is: {0}", avg);
        }
    }
}
