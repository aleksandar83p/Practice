using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Practice.Palindrome
{
    class Palindrome
    {
        static void Main()
        {
            Console.WriteLine("Enter first word");
            string firstWord = Console.ReadLine();

            Console.WriteLine("Enter second word");
            string secondWord = Console.ReadLine();

            bool result = IsItPalindrome(firstWord, secondWord);
            Console.WriteLine(result);

            bool IsItPalindrome(string firstWord, string secondWord)
            {
                char[] stringToChars = secondWord.ToCharArray();
                char[] reverse = new char[stringToChars.Length];
                int number = 0;

                for (int i = stringToChars.Length - 1; i >= 0; i--)
                {
                    reverse[number] = stringToChars[i];
                    number++;
                }

                string reverseSecondWord = string.Join("", reverse);
                // string reverseSecondWord = new string(reverse);

                if (firstWord == reverseSecondWord)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
