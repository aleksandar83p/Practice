using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Practice.BalancedBrackets
{
    class BalancedBrackets
    {
        // Write a program to examine whether the pairs and the orders of parentheses are balanced in expression or not
        static void Main()
        {
            string checkString = "The (quick brown<fox {jumps <}over>the lazy dog) ";

            Stack<char> parentheses = new Stack<char>(); // ()
            Stack<char> brackets = new Stack<char>();    // []
            Stack<char> braces = new Stack<char>();      // {}
            Stack<char> chevrons = new Stack<char>();    // <>

            char openParenthes = '(';
            char closedParenthes = ')';
            char openBracket = '[';
            char closedBracket = ']';
            char openBraces = '{';
            char closedBraces = '}';
            char openChevron = '<';
            char closedChevron = '>';

            bool resultParentheses = IsItBalanced(checkString, parentheses, openParenthes, closedParenthes);
            bool resultBrackets = IsItBalanced(checkString, brackets, openBracket, closedBracket);
            bool resultBraces = IsItBalanced(checkString, braces, openBraces, closedBraces);
            bool resultChevrons = IsItBalanced(checkString, chevrons, openChevron, closedChevron);

            bool isAllOK = resultParentheses && resultBrackets && resultBraces && resultChevrons;
            Console.WriteLine(isAllOK);

            bool IsItBalanced(string forCheck, Stack<char> stack, char open, char close)
            {
                for (int i = 0; i < forCheck.Length; i++)
                {
                    char currentCharacter = (char)checkString[i];

                    if (currentCharacter == open)
                    {
                        stack.Push(currentCharacter);
                    }
                    else if (currentCharacter == close)
                    {
                        if (stack.Count == 0)
                        {
                            return false;
                        }

                        stack.Pop();
                    }
                }

                if (stack.Count > 0)
                {
                    return false;
                }

                return true;
            }
        }
    }
}
