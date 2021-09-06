using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DataStructures.Arrays
{
    class ArrayBinarySearch
    {
        static void Main()
        {
            int[] numbers = { 2, 10, 1, 65, 45, 89, 111, 74, 32, 22, 61, -1 };

            int ArrayBinarySearch(int[] array, int key)
            {
                int left = 0;
                int right = array.Length;

                while (left < right)
                {
                    int mid = (left + right) / 2;

                    if (array[mid] == key)
                    {
                        Console.WriteLine("Nalazi se na indeksu " + mid);
                        return mid;
                    }
                    else if (array[mid] > key)
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                Console.WriteLine("Trazeni broj nije u nizu");
                return -1;
            }

            Array.Sort(numbers);
            int Found = ArrayBinarySearch(numbers, 89);
            int NotFound = ArrayBinarySearch(numbers, 222);
            Console.WriteLine(Found);
            Console.WriteLine(NotFound);

            // Array class method
            int BSFound = Array.BinarySearch(numbers, 111);
            int BSNotFounr = Array.BinarySearch(numbers, 11);
            Console.WriteLine(BSFound);
            Console.WriteLine(BSNotFounr);
        }
    }
}
