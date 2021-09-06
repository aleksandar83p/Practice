using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Practice.LongerString
{
    class LongerString
    {
        // Write an algorithm that shows which string is larger (longer)
        static void Main()
        {
            Console.WriteLine("Enter first word");
            string firstWord = Console.ReadLine();

            Console.WriteLine("Enter second word");
            string secondWord = Console.ReadLine();

            Longer(firstWord, secondWord);

            void Longer(string firstWord, string secondWord)
            {
                if (firstWord.Length > secondWord.Length)
                {
                    Console.WriteLine($"First word \"{firstWord}\" is longer.");
                }

                if (secondWord.Length > firstWord.Length)
                {
                    Console.WriteLine($"Second word \"{secondWord}\" is longer.");
                }

                if (firstWord.Length == secondWord.Length)
                {
                    Console.WriteLine("Both words have same lenght.");
                }
            }
        }
    }
}
