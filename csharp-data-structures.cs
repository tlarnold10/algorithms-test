// arrays - done
// linked lists - done
// stacks - done
// queues - done
// hash tables - done
// trees
// heaps
// graphs

using System;
using System.Collections.Generic;
using System.Collections;

namespace data
{
    class dataStructures
    {
        public static int x = 5;
        public static void Main(string[] args)
        {
            // FunArray();
            // string[] some_words = {"hey", "would", "you", "cuddle", "me"};
            // FunWithLinkedList(some_words);
            // FunWithStacks();
            // FunWithQueues();
            // FunWithHashTables();
            FunWithRecursion();
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

        public static void FunWithQueues()
        {
            Queue<string> exampleQueue = new Queue<string>();
            exampleQueue.Enqueue("The");
            exampleQueue.Enqueue("bees");
            exampleQueue.Enqueue("are");
            exampleQueue.Enqueue("in");
            exampleQueue.Enqueue("the");
            foreach(string str in exampleQueue)
            {
                Console.WriteLine(str);
            }
            exampleQueue.Enqueue("trap");
            exampleQueue.Enqueue("!");
            exampleQueue.Dequeue();
            foreach(string str in exampleQueue)
            {
                Console.WriteLine(str);
            }
        }

        public static void FunWithHashTables()
        {
            Hashtable ht = new Hashtable();
            ht.Add("hello", "world");
            ht.Add("stuff", "things");
            ICollection keys = ht.Keys;
            foreach (string key in keys)
            {
                Console.WriteLine("Key: " + key);
                Console.WriteLine("Value: " + ht[key]);
            }
        }

        public static void FunWithRecursion()
        {
            int y = 20;
            if(x <= 20)
            {
                Console.WriteLine(x);
                x++;
                FunWithRecursion();
            }   
            Console.WriteLine(y);
        }
