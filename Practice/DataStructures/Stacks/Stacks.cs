using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DataStructures.Stacks
{
    class Stacks
    {
        static void Main()
        {
            // STACK: First in last out.

            /*
            A stack is a LIFO (last in first out) data structure.
            Think of stack as a collection of items where anything
            you insert in a stack will be placed at the top and if
            you need to remove something, it will be removed from the top.
            A stack of plates or a book stack are two common examples of a stack.
            ---           
            The Push() method is used to add a (push) element to the stack. The item is added to the top of the stack. 
            The Pop() method is used to remove elements from a stack. The Pop() method removes the top most item from the stack.
            The Peek() method returns the topmost element of a Stack<T> without removing it
            The Count property of the Stack class returns the number of elements in a stack
            The Clear() method of Stack<T> removes all elements from a stack
            */

            Stack<int> myStack = new Stack<int>();            

            myStack.Push(5);
            myStack.Push(32);
            myStack.Push(7);
            myStack.Pop();  // 7 out
            myStack.Push(9);

            Console.WriteLine("myStack:");
            foreach (var item in myStack)
            {
                Console.WriteLine(item);  // 9, 32, 5
            }

            int howMany = myStack.Count;
            Console.WriteLine("myStack contains: " + howMany + " object");

            int Peek = myStack.Peek();
            Console.WriteLine(Peek);
        }
    }
}
