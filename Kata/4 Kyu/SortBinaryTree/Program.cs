using System;
using System.Collections.Generic;

namespace SortBinaryTree {
    public class Node {
        public Node Left;
        public Node Right;
        public int Value;

        public Node(Node l,Node r,int v) {
            Left = l;
            Right = r;
            Value = v;
        }
    }
    internal class Program {
        public static List<int> TreeByLevels(Node node) {
            
            return null;
        }
        static void Main(string[] args) {
            Console.WriteLine(TreeByLevels(new Node(new Node(null, new Node(null, null, 4), 2), new Node(new Node(null, null, 5), new Node(null, null, 6), 3), 1)));
        }
    }
}
