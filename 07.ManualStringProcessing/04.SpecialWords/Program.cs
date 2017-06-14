using System;
using System.Collections.Generic;
using System.Linq;

public class SpecialWords
{
    public static void Main()
    {
        var specialWords = Console.ReadLine().Split(new[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);
        var text = Console.ReadLine().Split(new char[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' ' },
            StringSplitOptions.RemoveEmptyEntries);
        var wordsCounts = new Dictionary<string, int>();
        foreach (var specialWord in specialWords)
        {
            wordsCounts[specialWord] = 0;
        }
        foreach (var word in text)
        {
            if (specialWords.Contains(word))
            {
                wordsCounts[word]++;
            }
        }

        foreach (var wordCount in wordsCounts)
        {
            Console.WriteLine($"{wordCount.Key} - {wordCount.Value}");
        }
    }
}