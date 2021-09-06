using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DataStructures.Arrays
{
    class ArrayFind
    {
        // Find item that contains letter, return first item
        static void Main()
        {
            string[] items = { "ball", "keyboard", "apple", "book", "ball" };

            string DoesItExist(string[] array, string searchWord)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Contains(searchWord))
                    {
                        return array[i];
                    }
                }

                return "Not Found";
            }

            string doesItExist = DoesItExist(items, "k");
            Console.WriteLine(doesItExist);

            string find = Array.Find(items, item => item.Contains("a"));
            Console.WriteLine(find);
        }
    }
}
