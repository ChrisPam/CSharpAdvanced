using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var text = Console.ReadLine();

        var regex = new Regex(@"[^0-9]");
        var matches = regex.Matches(text);

        Console.WriteLine($"Non-digits: {matches.Count}");
    }
}

