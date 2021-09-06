using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DataStructures.Arrays
{
    class ArrayFindLast
    {
        static void Main()
        {
            string[] items = { "ball1", "keyboard", "apple", "book", "ball2" };

            string FindLast(string[] array, string searchWord)
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i].Contains(searchWord))
                    {
                        return array[i];
                    }
                }

                return "Not Found";
            }

            string findLast = FindLast(items, "a");
            Console.WriteLine(findLast);

            // Array class method            
            string arrayFindLast = Array.FindLast(items, item => item.Contains("a"));
            Console.WriteLine(arrayFindLast);

        }
    }
}
