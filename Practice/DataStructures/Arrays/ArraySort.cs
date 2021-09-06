using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DataStructures.Arrays
{
    class ArraySort
    {
        static void Main()
        {
            int[] numbers = { 1, 8, 9, 20, 44, 3, 6, 7 };
            numbers = Sort(numbers);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            int[] Sort(int[] array)
            {
                int temp;

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                return array;
            }

            // Array class method  
            Array.Sort(numbers);
        }
    }
}
