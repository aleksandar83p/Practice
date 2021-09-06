using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Practice.Anagram
{
    class Anagram
    {
        // Write an algorithm that checks anagram, whether the strings are the same.
        // An example of this is true: car = arc

        static void Main()
        {
            Console.WriteLine("Enter first word");
            string firstWord = Console.ReadLine();

            Console.WriteLine("Enter second word");
            string secondWord = Console.ReadLine();

            bool result = Anagram(firstWord, secondWord);
            Console.WriteLine(result);

            bool Anagram(string firstWord, string secondWord)
            {
                byte[] asciiFirstWord = Encoding.ASCII.GetBytes(firstWord);
                byte[] asciiSecondWord = Encoding.ASCII.GetBytes(secondWord);

                Array.Sort(asciiFirstWord);
                Array.Sort(asciiSecondWord);                

                if (asciiFirstWord.SequenceEqual(asciiSecondWord))
                {
                    return true;
                }

                return false;
            }
        }
    }
}
