using System;

namespace SwimmingPool {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter length of the pool in m: ");
            float length = float.Parse(Console.ReadLine());
            Console.Write("Enter width of the pool in m: ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Enter depth of the pool in m (shallow end): ");
            float shallow = float.Parse(Console.ReadLine());
            Console.Write("Enter depth of the pool in m (deep end): ");
            float deep = float.Parse(Console.ReadLine());

            float volume = (deep + shallow) * 0.5f * width * length;

            Console.WriteLine("\nThe volume of water needed to fill this pool is: {0}m^3",volume);
        }
    }
}
