using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1_Collections_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Array Item 1");

            int i = 1;

            while (i == 1)
            {
                Console.WriteLine("Please enter menu choice:");
                Console.WriteLine();
                Console.WriteLine("Choice 1: Show items in your Queue");
                Console.WriteLine("Choice 2: Add Items to Queue");
                Console.WriteLine("Choice 3: Remove object from end of Queue and put to front of Queue");
                Console.WriteLine("Choice 4: Find an item ");
                Console.WriteLine("Choice 5: Make a copy of current Array");
                Console.WriteLine("Choice 6: Exit");
                int menuchoice = int.Parse(Console.ReadLine());

                switch (menuchoice)
                {
                    case 1:
                        MyQueue.printQueue(q);
                        break;
                    case 2:
                        MyQueue.Enqueue(q);
                        break;
                    case 3:
                        MyQueue.Dequeue(q);
                        break;
                    case 4:
                        MyQueue.Contains(q);
                        break;
                    case 5:
                        MyQueue.ToArray(q);
                        break;
                    case 6:
                        Console.WriteLine("\nGoodBye");
                        i = 2;
                        break;
                }

                Console.WriteLine();
                Console.ReadKey();
            }
        }            
    }
    class MyQueue //Queue Class containing methods
    {
        public static void printQueue(Queue q) // View list of all items in Queue
        {
            Console.WriteLine("Current queue: ");
            foreach (string c in q) Console.Write(c + " ");
            Console.WriteLine();
        }
        public static void Enqueue(Queue q)
        {
            Console.WriteLine("\nPlease enter a value to be added to Queue: ");
            string item = Console.ReadLine();
            q.Enqueue(item);
            printQueue(q);
        } //Display items in the Queue
        public static void  Dequeue(Queue q)//Removes and return the object to beginning of Queue
        {          
            string value = (string)q.Dequeue();
            Console.WriteLine("\n{0} has been removed from front of Queue", value);
            printQueue(q);
        }
        public static void Contains(Queue q)//Check if specific value is in Array
        {
            Console.WriteLine("\nEnter item to check: ");
            string item = Console.ReadLine();
            if (q.Contains(item))
            {
                Console.WriteLine("Yes, {0} is in the queue", item);
            }
            else
            {
                Console.WriteLine("no, {0} is not in the queue", item);
            }
        }
        public static void ToArray(Queue q) // copy of "q" array to copyArray
        {
            Queue copyArray = new Queue(q.ToArray());
            Console.WriteLine("\nCopy of array complete, Items in copied array: ");
            foreach (string c in copyArray) Console.Write(c + " ");
            Console.WriteLine();
        }
    }
}
