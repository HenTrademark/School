using System;
using System.Runtime.InteropServices;
using System.Transactions;

namespace Stacks {
    internal class Stack1 {
        // Global variables
        public static int max = 10;
        public static int stkptr = -1;
        public static int[] Stack = new int[max];
        public static bool isFull() { // isFull
            return stkptr == 9;
        }
        public static bool isEmpty() { // isEmpty
            return stkptr == -1;
        }
        public static void push(int data) { // Push
            // In C#, data types have to be specified
            if (isFull()) {
                Console.WriteLine("Stack full");
            }
            else {
                stkptr++;
                Stack[stkptr] = data;
            }
        }
        public static int pop() { // Pop
            if (isEmpty()) {
                Console.WriteLine("Stack empty");
                return 0;
            }
            else {
                int data = Stack[stkptr];
                stkptr--;
                return data;
            }
        }
        public static int size() {
            return stkptr + 1;
        }
        public static void display() {
            int[] arr = new int[size()];
            for (int i = 0; i < size(); i++) {
                arr[i] = Stack[i];
            }
            Console.Write("Stack items: {0}",String.Join(", ",arr));
        }
    }
    internal class Program {
        static bool done = false;
        static void Menu() {
            Console.WriteLine();
            Console.Write("Current Stack top item: ");
            if (Stack1.isEmpty()) { Console.WriteLine("[]"); }
            else { Console.WriteLine("[{0}]",Stack1.Stack[Stack1.stkptr]); }
            Console.WriteLine("Functions:");
            Console.WriteLine("  0. quit");
            Console.WriteLine("  1. push()");
            Console.WriteLine("  2. pop()");
            Console.WriteLine("  3. isFull()");
            Console.WriteLine("  4. isEmpty()");
            Console.WriteLine("  5. size()");
            Console.WriteLine("  6. display()");
            Console.Write("Enter function (0-6): ");
            int sel = int.Parse(Console.ReadLine());
            Console.WriteLine();
            while (sel < 0 || sel > 6) {
                Console.WriteLine("Not a valid option");
                Console.Write("Enter function (0-6): ");
                sel = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            switch (sel) {
                case 0:
                    done = true;
                    break;
                case 1:
                    Console.WriteLine("Enter item you want to push: ");
                    int data = int.Parse(Console.ReadLine());
                    Stack1.push(data);
                    break;
                case 2:
                    Stack1.pop();
                    break;
                case 3:
                    if (Stack1.isFull()) { Console.WriteLine("Stack is Full"); }
                    else { Console.WriteLine("Stack is not Full"); }
                    break;
                case 4:
                    if (Stack1.isFull()) { Console.WriteLine("Stack is Empty"); }
                    else { Console.WriteLine("Stack is not Empty"); }
                    break;
                case 5:
                    Console.WriteLine("Stack size: {0}",Stack1.size());
                    break;
                case 6:
                    Stack1.display();
                    break;
            }
        }
        static void Main(string[] args) {
            while (!done) {
                Menu();
            }
            Console.WriteLine("\nGoodbye");
        }
    }
}
