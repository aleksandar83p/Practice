using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DataStructures.Arrays
{
    class ArrayFindAll
    {
        static void Main()
        {
            string[] items = { "ball", "keyboard", "apple", "book", "ball" };

            string[] FindAll(string[] array, string searchWord)
            {
                string[] newArray = new string[array.Length];
                int number = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Contains(searchWord))
                    {
                        newArray[number] = array[i];
                        number++;
                    }
                }

                return newArray;
            }

            string[] findAll = FindAll(items, "a");
            foreach (var item in findAll)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------");
            // Array class method
            string[] findAllMethod = Array.FindAll(items, item => item.Contains("a"));
            foreach (var item in findAllMethod)
            {
                Console.WriteLine(item);
            }
        }
    }
}
