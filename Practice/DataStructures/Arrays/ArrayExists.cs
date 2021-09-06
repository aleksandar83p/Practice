using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DataStructures.Arrays
{
    class ArrayExists
    {
        static void Main()
        {
            string[] items = { "ball", "keyboard", "apple", "book", "ball" };

            bool DoesItExist(string[] array, string searchWord)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Contains(searchWord))
                    {
                        return true;
                    }
                }

                return false;
            }

            bool doesItExist = DoesItExist(items, "key");
            Console.WriteLine(doesItExist);

            // Array class method
            bool exist = Array.Exists(items, item => item.Contains("app"));
            Console.WriteLine(exist);
        }
    }
}
