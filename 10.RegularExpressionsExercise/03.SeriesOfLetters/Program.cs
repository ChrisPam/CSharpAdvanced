using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var text = Console.ReadLine();

        var regex = new Regex("(.)\\1+");
        var matches = regex.Matches(text);

        foreach (var match in matches)
        {
            var first = match.ToString();
            var second = match.ToString().First();
            var index = text.IndexOf(first);
            text = text.Remove(index, first.Length);
            text = text.Insert(index, second.ToString());
        }
        Console.WriteLine(text);
    }
}