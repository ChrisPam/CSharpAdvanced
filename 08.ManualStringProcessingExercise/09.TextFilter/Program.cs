using System;
using System.Collections.Generic;
using System.Linq;

public class TextFilter
{
    public static void Main()
    {
        var banWords = Console.ReadLine().Split(new string[] { ", " },
            StringSplitOptions.RemoveEmptyEntries).OrderByDescending(x => x.Length).ToList();

        var text = Console.ReadLine();

        FilterText(banWords, text);
    }

    public static void FilterText(List<string> banWords, string text)
    {
        foreach (var banWord in banWords)
        {
            var hasBanWord = text.IndexOf(banWord);
            while (hasBanWord >= 0)
            {
                text = text.Replace(banWord, new string('*', banWord.Length));
                break;
            }
        }

        Console.WriteLine(text);

    }
}