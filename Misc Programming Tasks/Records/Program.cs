using System;

namespace Records {
    internal class Program {
        struct Books { // This defines a record called "Books"
            // These are attributes
            public string Title; // This is a string with the identifier "Title"
            public string Author; // This is a string with the identifier "Author"
            public string Subject; // This is a string with the identifier "Subject"
            public int BookID; // This is an integer with the identifier "BookID"
        }
        static void Main(string[] args) {
            Books[] Book1 = new Books[5]; // Assigning data values
            for (int i = 0; i < 5; i++) {
                Console.Write("What is the title of book {0}: ",i + 1);
                Book1[i].Title = Console.ReadLine();
                Console.Write("What is the author of book {0}: ",i + 1);
                Book1[i].Author = Console.ReadLine();
                Console.Write("What is the subject of book {0}: ",i + 1);
                Book1[i].Subject = Console.ReadLine();
                Console.Write("What is the ID of book {0}: ",i + 1);
                Book1[i].BookID = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            // Displaying the record data
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Book title: {0}\nBook author: {1}\nBook subject: {2}\nBook ID: {3}\n",Book1[i].Title,Book1[i].Author,Book1[i].Subject,Book1[i].BookID);
            }  
        }
    }
}
