using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Practice.OddNumbers
{
    class OddNumbers
    {
        // Write an algorithm that displays only odd numbers in an array
        static void Main()
        {
            int[] numbres = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 22, 36, 47, 54, 61, 72, 83, 94 };

            OddNumbers(numbres);

            void OddNumbers(int[] array)
            {
                foreach (var number in array)
                {
                    if ((number % 2) != 0)
                    {
                        Console.WriteLine(number);
                    }
                }
            }
        }
    }
}
