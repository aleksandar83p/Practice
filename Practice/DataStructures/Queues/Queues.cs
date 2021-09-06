using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DataStructures.Queues
{
    class Queues
    {
        // QUEUE: First in first out. Enforcing fairness(waitlist), players turn in games
        static void Main()
        {
            /*           
            A Queue represents a first-in, first-out (FIFO) collection of objects.
            An example of a queue is a line of people waiting.
              
            Enqueue() method adds an object to the end of the Queue<T>
            Dequeue() method removes and returns the object at the beginning of the Queue<T>
            Contain() method determines whether an element is in the Queue<T>
            Clear() method removes all objects from the Queue<T>
            Peek() method returns the object at the beginning of the Queue<T> 
            ToArray() method copies the Queue<T> elements to a new array
            */

            Queue<int> myQueue = new Queue<int>();

            myQueue.Enqueue(5);
            myQueue.Enqueue(12);
            myQueue.Enqueue(3);
            myQueue.Enqueue(97);
            myQueue.Dequeue();  // 5 out
            myQueue.Enqueue(55);

            Console.WriteLine("myQueue:");
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);  // 12, 3, 97, 55
            }

            bool contains = myQueue.Contains(3);
            Console.WriteLine(contains);

            int beginning = myQueue.Peek();
            Console.WriteLine(beginning);

            Console.WriteLine("Queue.ToArray");
            int[] queueArray = myQueue.ToArray();
            foreach(var num in queueArray)
            {
                Console.WriteLine(num);
            }
        }
    }
}
