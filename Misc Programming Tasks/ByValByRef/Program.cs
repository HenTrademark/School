using System;

namespace ByValByRef {
    internal class ByVal {
        //Function to calculate deductions from pay
        static float subtract_deductions(float pay,float percent) {
            return (pay * percent) / 100;
        }

        static void calculate_pay(float pay) {
            //Subtract tax on pay at 22%
            pay = pay - subtract_deductions(pay,22);
        }
        public static void menu() {
            float pay;
            pay = 2000;
            calculate_pay(pay);
            Console.WriteLine(pay);
            Console.ReadLine();
        }
    }
    internal class ByRef {
        //Function to calculate deductions from pay
        static float subtract_deductions(float pay,float percent) {
            return (pay * percent) / 100;
        }

        static void calculate_pay(ref float pay) {
            //Subtract tax on pay at 22%
            pay = pay - subtract_deductions(pay,22);
        }
        public static void menu() {
            float pay;
            pay = 2000;
            calculate_pay(ref pay);
            Console.WriteLine(pay);
            Console.ReadLine();
        }
    }
    internal class Program {
        static void Main(string[] args) {
            ByRef.menu();

        }
    }
}
