using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Queues {
    internal class Priority {
        // Variables
        static ArrayList queue = new ArrayList();
        static int maxsize = 10;
        static int size = 0;

        static bool finished = false;

        // Funciton "isFull" - Check if it's full
        static bool isFull() {
            // If maxsize is equal to size, return true
            return maxsize == size;
        }

        // Function "isEmpty" - Check if it's empty
        static bool isEmpty() {
            // If the size is 0, return true
            return size == 0;
        }

        // Procedure "enQueue" - add to queue
        static void enQueue(string item) {
            // If the queue is full, then inform the user
            if (isFull()) { Console.WriteLine("Queue full"); }
            // If the queue is empty, then add it 
            else if (isEmpty()) {
                queue.Add(item);
                size++;
            }
            // Else add to the size, set the next rear and add the item
            else {
                int priority = int.Parse(item[0].ToString());
                bool found = false;
                for (int i = 0; i < size && found == false; i++) { // For each item in the queue
                    string q = queue[i].ToString(); // Store the item
                    int qp = int.Parse(q[0].ToString()); // Find the priority
                    if (priority < qp) { // If the qp is over the item's priority
                        queue.Insert(i,item); // Insert the item into the queue
                        size++; // Add one to the size
                        found = true;
                    }
                }
                if (!found) {
                    queue.Add(item);
                    size++;
                }
            }
        }

        // Function "deQueue" - remove from the queue
        static string deQueue() {
            if (isEmpty()) {
                Console.WriteLine("Queue is empty");
                return "";
            }
            string item = queue[0].ToString();
            size--;
            queue.RemoveAt(0);
            return item;
        }

        // Procedure "view" - Show the queue
        static void view() {
            if (isEmpty()) { Console.WriteLine("Queue is empty"); }
            else {
                Console.WriteLine("Queue contents:");
                for (int i = 0; i < size; i++) {
                    Console.Write(queue[i]);
                    if (i != size - 1) { Console.Write(" | "); }
                }
                Console.WriteLine();
            }
        }

        // Procedure "reset" - Resets the whole queue back to the original
        static void reset() {
            queue = new ArrayList();
            size = 0;
        }

        // Menu
        public static void Menu() { // All options for the programs
            while (!finished) {
                Console.WriteLine("Options for Priority Queue:");
                Console.WriteLine("  0. Quit");
                Console.WriteLine("  1. enQueue()");
                Console.WriteLine("  2. deQueue()");
                Console.WriteLine("  3. isFull()");
                Console.WriteLine("  4. isEmpty()");
                Console.WriteLine("  5. view()");
                Console.WriteLine("  6. reset()");
                int sel = -1;
                while (sel < 0 || sel > 6) { // Asks for a number until the number is valid
                    Console.Write("Enter your selection (0-6): ");
                    sel = int.Parse(Console.ReadLine());
                    if (sel < 0 || sel > 6) {
                        Console.WriteLine("Not a valid option.");
                        Console.WriteLine("Pick a number from 0 to 6\n");
                    }
                    Console.WriteLine();
                }
                switch (sel) {
                    case 0: // If 0, go back to the program class
                        finished = true;
                        Program.Menu();
                        break;
                    case 1: // If 1, enQueue an item
                        Regex rx = new Regex("^[1-3]{1}[A-Z]{2}$");
                        /*      Regex (Regular Expression)
                            ^        - Start of line
                            [1-3]{1} - (1, 2 or 3) once
                            [A-Z]{2} - (Any capital letter) twice
                            $        - End of line
                         */
                        string item = "";
                        while (!rx.IsMatch(item)) {
                            Console.Write("Enter the item: ");
                            item = Console.ReadLine().ToUpper();
                            if (!rx.IsMatch(item)) {
                                Console.WriteLine("Item doesn't match the format");
                                Console.WriteLine("Format: <1, 2 or 3><Letter A-Z><Letter A-Z>");
                            }
                            Console.WriteLine();
                        }
                        enQueue(item);
                        break;
                    case 2: // If 2, deQueue an item
                        deQueue();
                        break;
                    case 3: // If 3, check if the queue is full
                        if (isFull()) { Console.WriteLine("Queue is full"); }
                        else { Console.WriteLine("Queue is not full"); }
                        break;
                    case 4: // If 4, check if the queue is empty
                        if (isEmpty()) { Console.WriteLine("Queue is empty"); }
                        else { Console.WriteLine("Queue is not empty"); }
                        break;
                    case 5: // If 5, view the queue's contents
                        view();
                        break;
                    case 6: // If 6, reset queue's contents
                        reset();
                        break;
                }
            }
        }
    }
    internal class Circular {
        // Variables
        static string[] queue = new string[5];
        static int maxsize = 5;
        static int size = 0;
        static int front = 0;
        static int rear = -1;

        static bool finished = false;

		// Funciton "isFull"
        static bool isFull() {
			// If maxsize is equal to size, return true
            return maxsize == size;
        }
		
		// Function "isEmpty"
        static bool isEmpty() {
			// If the size is 0, return true
            return size == 0;
        }

		// Procedure "enQueue" - add to queue
        static void enQueue(string item) {
			// If the queue is full, then inform the user
            if (isFull()) { Console.WriteLine("Queue full"); }
			// Else add to the size, set the next rear and add the item
            else {
                size++;
                rear = (rear+1) % maxsize;
                queue[rear] = item;
                Console.WriteLine("Item enqueued");
            }
        }
        
        // Function "deQueue" - remove from the queue
        static string deQueue() {
            // If the queue is empty, then inform the user and return nothing
            if (isEmpty()) { Console.WriteLine("Queue is empty"); return null; }
            // Else set the front item to "item", increment front and return the item
            size--;
            string item = queue[front];
            front = (front + 1) % maxsize;
            Console.WriteLine("Item dequeued");
            return item;
        }

        // Procedure "view" - Show the queue
        static void view() {
            if (isEmpty()) { Console.WriteLine("Queue is empty"); }
            else {
                Console.WriteLine("Queue contents:");
                for (int i = 0; i < size; i++) {
                    Console.Write(queue[i]);
                    if (i != size - 1) { Console.Write(" | "); }
                }
                Console.WriteLine();
            }
        }

        // Procedure "reset" - Resets the whole queue back to the original
        static void reset() {
            queue = new string[maxsize];
            size = 0;
            front = 0;
            rear = -1;
        }

        // Menu 
        public static void Menu() { // All options for the programs
            while (finished == false) {
                Console.WriteLine("Options for Circular Queue:");
                Console.WriteLine("  0. Quit");
                Console.WriteLine("  1. enQueue()");
                Console.WriteLine("  2. deQueue()");
                Console.WriteLine("  3. isFull()");
                Console.WriteLine("  4. isEmpty()");
                Console.WriteLine("  5. view()");
                Console.WriteLine("  6. reset()");
                int sel = -1;
                while (sel < 0 || sel > 6) { // Asks for a number until the number is valid
                    Console.Write("Enter your selection (0-6): ");
                    sel = int.Parse(Console.ReadLine());
                    if (sel < 0 || sel > 6) {
                        Console.WriteLine("Not a valid option.");
                        Console.WriteLine("Pick a number from 0 to 6\n");
                    }
                    Console.WriteLine();
                }
                switch (sel) {
                    case 0: // If 0, go back to the program class
                        finished = true;
                        break;
                    case 1: // If 1, enQueue and item
                        Console.Write("Enter the item: ");
                        string item = Console.ReadLine();
                        enQueue(item);
                        break;
                    case 2: // If 2, deQueue an item
                        deQueue();
                        break;
                    case 3: // If 3, check if the queue is full
                        if (isFull()) { Console.WriteLine("Queue is full"); }
                        else { Console.WriteLine("Queue is not full"); }
                        break;
                    case 4: // If 4, check if the queue is empty
                        if (isEmpty()) { Console.WriteLine("Queue is empty"); }
                        else { Console.WriteLine("Queue is not empty"); }
                        break;
                    case 5: // If 5, view the queue's contents
                        view();
                        break;
                    case 6: // If 6, reset queue's contents
                        reset();
                        break;
                }
                Console.WriteLine();
            }
        }
    }
    internal class NonCircular {
        // Variables
        static string[] queue = new string[5];
        static int maxsize = 5;
        static int size = 0;
        static int front = 0;
        static int rear = -1;

        static bool finished = false;

        // Funciton "isFull"
        static bool isFull() {
            // If maxsize is equal to size, return true
            return maxsize == size;
        }

        // Function "isEmpty"
        static bool isEmpty() {
            // If the size is 0, return true
            return size == 0;
        }

        // Procedure "enQueue" - add to queue
        static void enQueue(string item) {
            // If the queue is full, then inform the user
            if (isFull()) { Console.WriteLine("Queue full"); }
            // Else add to the size, set the next rear and add the item
            else if (rear == maxsize - 1) { Console.WriteLine("You cannot add more items"); }
            else {
                size++;
                rear += 1;
                queue[rear] = item;
                Console.WriteLine("Item enqueued");
            }
        }

        // Function "deQueue" - remove from the queue
        static string deQueue() {
            // If the queue is empty, then inform the user and return nothing
            if (isEmpty()) { Console.WriteLine("Queue is empty"); return null; }
            // Else set the front item to "item", increment front and return the item
            size--;
            string item = queue[front];
            front += 1;
            Console.WriteLine("Item dequeued");
            return item;
        }

        // Procedure "view" - Show the queue
        public static void view() {
            if (isEmpty()) { Console.WriteLine("Queue is empty"); }
            else {
                Console.WriteLine("Queue contents:");
                for (int i = 0; i < size; i++) {
                    Console.Write(queue[i]);
                    if (i != size - 1) { Console.Write(" | "); }
                }
                Console.WriteLine();
            }
        }

        // Procedure "reset" - Resets the whole queue back to the original
        static void reset() {
            queue = new string[maxsize];
            size = 0;
            front = 0;
            rear = -1;
        }

        // Menu 
        public static void Menu() { // All options for the programs
            while (finished == false) {
                Console.WriteLine("Options for NonCircular Queue:");
                Console.WriteLine("  0. Quit");
                Console.WriteLine("  1. enQueue()");
                Console.WriteLine("  2. deQueue()");
                Console.WriteLine("  3. isFull()");
                Console.WriteLine("  4. isEmpty()");
                Console.WriteLine("  5. view()");
                Console.WriteLine("  6. reset()");
                int sel = -1;
                while (sel < 0 || sel > 6) { // Asks for a number until the number is valid
                    Console.Write("Enter your selection (0-6): ");
                    sel = int.Parse(Console.ReadLine());
                    if (sel < 0 || sel > 6) {
                        Console.WriteLine("Not a valid option.");
                        Console.WriteLine("Pick a number from 0 to 6\n");
                    }
                    Console.WriteLine();
                }
                switch (sel) {
                    case 0: // If 0, go back to the program class
                        finished = true;
                        break;
                    case 1: // If 1, enQueue and item
                        Console.Write("Enter the item: ");
                        string item = Console.ReadLine();
                        enQueue(item);
                        break;
                    case 2: // If 2, deQueue an item
                        item = deQueue();
                        if (item != null) { Console.WriteLine("deQueued item: {0}",item); }
                        break;
                    case 3: // If 3, check if the queue is full
                        if (isFull()) { Console.WriteLine("Queue is full"); }
                        else { Console.WriteLine("Queue is not full"); }
                        // Check if the queue can add more items
                        if (rear == maxsize - 1) { Console.WriteLine("You cannot add more items"); }
                        else { Console.WriteLine("You can add more items"); }
                        break;
                    case 4: // If 4, check if the queue is empty
                        if (isEmpty()) { Console.WriteLine("Queue is empty"); }
                        else { Console.WriteLine("Queue is not empty"); }
                        // Check if the queue can add more items
                        if (rear == maxsize - 1) { Console.WriteLine("You cannot add more items"); }
                        else { Console.WriteLine("You can add more items"); }
                        break;
                    case 5: // If 5, view the queue's contents
                        view();
                        break;
                    case 6: // If 6, reset queue's contents
                        reset();
                        break;
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program {
        public static bool done = false;
        static void Main(string[] args) {
            while (!done) {
                Menu();
                Console.WriteLine();
            }
            Console.WriteLine("Goodbye! o/");
        }
        
        public static void Menu() { // All options for the programs
            Console.WriteLine("Options:");
            Console.WriteLine("  0. Quit");
            Console.WriteLine("  1. NonCircular Queue");
            Console.WriteLine("  2. Circular Queue");
            Console.WriteLine("  3. Priority Queue");
            int sel = -1;
            while (sel < 0 || sel > 3) {
                Console.Write("Enter your selection (0-3): ");
                sel = int.Parse(Console.ReadLine());
                if (sel < 0 || sel > 3) {
                    Console.WriteLine("Not a valid option");
                    Console.WriteLine("Enter a number from 0-3");
                }
                Console.WriteLine();
            }
            switch (sel) {
                case 0:
                    done = true; break;
                case 1:
                    NonCircular.Menu(); break;
                case 2:
                    Circular.Menu(); break;
                case 3:
                    Console.WriteLine("How the Priority queue works:");
                    Console.WriteLine("  Each thing has a priority");
                    Console.WriteLine("    1 is high priority");
                    Console.WriteLine("    2 is medium priority");
                    Console.WriteLine("    3 is low priority");
                    Console.WriteLine("  The next 2 chars are capital letters");
                    Console.WriteLine("\nOnly strings taking this format will work");
                    Console.WriteLine(); Priority.Menu(); break;
            }
        }
    }
}
