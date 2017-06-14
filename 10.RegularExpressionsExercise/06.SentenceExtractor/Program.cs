using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    public static void Main()
    {
        var keyword = Console.ReadLine();
        var text = Console.ReadLine();

        var regex = new Regex("([\\w+\\s\\s]+[.?!]|\\s+[^.!?]*[.!?])");
        var matches = regex.Matches(text);

        foreach (var match in matches)
        {
            var hasKeyWord = false;
            var sentence = match.ToString().Split(new char[] { ' ', ',', '!', '.', '\'', '"', '?', ';' },StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in sentence)
            {
                if(keyword == word)
                {
                    hasKeyWord = true;
                    break;
                }
            }
            if (hasKeyWord)
            {
                Console.WriteLine(match.ToString());
            }

        }
    }
}