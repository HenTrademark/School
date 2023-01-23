using System;

namespace Deadfish
{
    internal class Program
    {
        public static int[] Parse(string data)
        {
            int[] arr = new int[0];
            int x = 0;
            while (data.Length > 0)
            {
                if (data[0] == 'i') { x++; }
                if (data[0] == 'd') { x--; }
                if (data[0] == 's') { x *= x; }
                if (data[0] == 'o') 
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = x;
                }
                data = data.Substring(1);
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = Parse("iiisdoso");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
