using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var text = Console.ReadLine();

        var regex = new Regex(@"[aeoiuyAEOIUY]");
        var matches = regex.Matches(text);

        Console.WriteLine($"Vowels: {matches.Count}");
    }
}
