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
            // string[] some_words = {"hey", "would", "you", "cuddle", "me"};
            // FunWithLinkedList(some_words);
            FunWithStacks();
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

        public static void FunWithStacks()
        {
            Stack<string> exampleStack = new Stack<string>();
            exampleStack.Push("The");
            exampleStack.Push("bees");
            exampleStack.Push("are");
            exampleStack.Push("in");
            exampleStack.Push("the");
            foreach(string str in exampleStack)
            {
                Console.WriteLine(str);
            }
            exampleStack.Push("trap");
            exampleStack.Push("!");
            exampleStack.Pop();
            foreach(string str in exampleStack)
            {
                Console.WriteLine(str);
            }
        }
    }
}