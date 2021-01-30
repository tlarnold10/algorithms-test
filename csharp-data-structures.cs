// arrays - done
// linked lists - done
// stacks
// queues
// hash tables
// trees
// heaps
// graphs

using System;
using System.Collections.Generic;

namespace data
{
    class dataStructures
    {
        public static void Main(string[] args)
        {
            // FunArray();
            string[] some_words = {"hey", "would", "you", "cuddle", "me"};
            FunWithLinkedList(some_words);
        }

        public static void FunArray()
        {
            int[] array_example= {1, 2, 3, 4, 5, 6, 7};
            foreach(int i in array_example)
            {
                Console.WriteLine(i);
            }
        }

        public static void FunWithLinkedList(string[] words)
        {
            LinkedList<string> comment = new LinkedList<string>(words);
            foreach (string word in comment)
            {
                Console.WriteLine(word);
            }
            comment.RemoveLast();
            comment.RemoveFirst();
            foreach (string word in comment)
            {
                Console.WriteLine(word);
            }
            comment.AddFirst("bitchin");
            comment.AddLast("balls");
            foreach (string word in comment)
            {
                Console.WriteLine(word);
            }
        }
    }
}