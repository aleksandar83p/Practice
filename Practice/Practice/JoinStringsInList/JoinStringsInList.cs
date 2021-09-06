using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Practice.JoinStringsInList
{
    class JoinStringsInList
    {
        // Write an algorithm that joins strings in a list with a space between words
        // Example: this is a list of 3 strings "Hello wo rld"
        static void Main()
        {
            List<string> turtles = new List<string>();
            turtles.Add("Leo");
            turtles.Add("Donnie");
            turtles.Add("Raph");
            turtles.Add("Mikey");

            string turtlesCombine = JoinStrings(turtles);
            Console.WriteLine(turtlesCombine);

            string JoinStrings(List<string> strings)
            {
                return string.Join(" ", strings);
            }
        }
    }
}
