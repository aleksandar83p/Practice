using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DataStructures.Arrays
{
    class ArrayReverse
    {
        static void Main()
        {
            string[] items = { "ball", "keyboard", "apple", "book" };

            string[] ArrayReverse(string[] array)
            {
                string[] reverse = new string[array.Length];
                int number = 0;

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    reverse[number] = array[i];
                    number++;
                }

                return reverse;
            }

            string[] reversed = ArrayReverse(items);
            foreach (var item in reversed)
            {
                Console.WriteLine(item);
            }

            // Array class method
            Array.Reverse(items);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
