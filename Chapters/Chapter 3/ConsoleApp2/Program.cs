using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;
            Console.WriteLine("Enter your first number");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your third number");
            num3 = double.Parse(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3) {
                Console.WriteLine("The biggest number is {0}", num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("The biggest number is {0}", num2);
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                Console.WriteLine("The biggest number is {0}", num3);
            }
        }
    }
}
