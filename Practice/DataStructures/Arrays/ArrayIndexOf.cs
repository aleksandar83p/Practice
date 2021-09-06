using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DataStructures.Arrays
{
    class ArrayIndexOf
    {
        // trazi po celom imenu
        static void Main()
        {
            string[] items = { "ball", "keyboard", "apple", "book", "ball" };

            int GetIndex(string[] array, string searchWord)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == searchWord)
                    {
                        return i;
                    }
                }

                Console.WriteLine("Not Found");
                return -1;
            }

            int indexof = GetIndex(items, "ball");
            Console.WriteLine(indexof);

            // Array class method
            int indexNumber = Array.IndexOf(items, "apple");
            Console.WriteLine(indexNumber);

        }
    }
}
