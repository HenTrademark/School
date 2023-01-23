using System;

namespace Program7_1 {
    internal class Program {
        static void Main(string[] args) {
            string cat = "The domestic cat is a small, typically furry, carnivorous mammal.They are often called house cats when kept as indoor pets or simply cats when there is no need to distinguish them from other felids and felines.Cats are often valued by humans for companionship and for their ability to hunt vermin. There are more than 70 cat breeds, though different associations proclaim different numbers according to their standards.";
            Console.WriteLine("Original string:\n{0}\n",cat);
            //1. replace all instances of cat with dog and cats with dogs - re-output

            string dog = cat.Replace("cat","dog");
            Console.WriteLine("1. Replace the word \"cat(s)\" with \"dog(s)\":\n{0}\n",dog);

            //2. find the length of the string - output the length

            int length = cat.Length;
            Console.WriteLine("2. Find the length of the original string:\n{0}\n",length);

            //3. Return the substring "They are often called house cats" and output this substring

            string phrase = "They are often called house cats";
            int indofphr = cat.IndexOf(phrase);
            int lenofphr = phrase.Length;
            string substring = cat.Substring(indofphr,lenofphr); // .Substring()
            Console.WriteLine("3. Output the substring:\n{0}\n",substring);

            //4. output the index of the first example of "cat"

            int index = cat.IndexOf("cat");
            Console.WriteLine("4. The index of the first example of \"cat\":\n{0}\n",index);

            //5. Insert the sentence "There are a number of different breeds." after the end of the first sentence.

            int indofdot = cat.IndexOf('.'); // Finds the index of the end of the first sentence
            string inserted = cat.Insert(indofdot + 1,"There are a number of different breeds.");
            Console.WriteLine("5. Insert \"There are a number of different breeds.\" after the first sentence:\n{0}\n",inserted);

            //6. Remove the first sentence and output it

            // Uses the same index of dot from before 
            string removed = cat.Remove(0,indofdot + 1); // Removes everything from the start to the dot (inclusive)
            Console.WriteLine("6. Remove the first sentence:\n{0}\n",removed);

            //7. Split the string into an array of substrings

            string[] strings = cat.Split('.');
            Console.WriteLine("7. Split the string into an array of substrings:");
            foreach (string s in strings) { Console.WriteLine(s.Trim()); }

            // All of the comments are self explanitory
        }
    }
}
