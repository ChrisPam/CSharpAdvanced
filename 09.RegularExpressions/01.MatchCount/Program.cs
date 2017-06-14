using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var matchWord = Console.ReadLine();
        var text = Console.ReadLine();

        Regex regex = new Regex(matchWord);
        var matches = regex.Matches(text);

        Console.WriteLine(matches.Count);
    }
}