using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var text = Console.ReadLine();

        var regex = new Regex(@"[0-9]+");
        var matches = regex.Matches(text);

        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}
