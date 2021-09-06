using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DataStructures.Arrays
{
    class ArrayFindIndex
    {
        static void Main()
        {
            string[] items = { "ball", "keyboard", "apple", "book", "ball" };

            int FindIndex(string[] array, string searchWord)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Contains(searchWord))
                    {
                        return i;
                    }
                }

                Console.WriteLine("Not found");
                return -1;
            }

            int search = FindIndex(items, "app");
            Console.WriteLine(search);

            // Array class method
            int findIndex = Array.FindIndex(items, item => item.Contains("app"));
            Console.WriteLine(findIndex);
        }
    }
}
