using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DataStructures.Arrays
{
    class ArrayCopy
    {
        static void Main()
        {
            string[] items = { "ball", "keyboard", "apple", "book" };

            string[] CopyArray(string[] array)
            {
                string[] newArray = new string[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }

                return newArray;
            }

            string[] copied = CopyArray(items);
            foreach (var item in copied)
            {
                Console.WriteLine(item);
            }

            // Array class method
            string[] items2 = new string[items.Length];
            Array.Copy(items, items2, items.Length);
            foreach (var item in items2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
