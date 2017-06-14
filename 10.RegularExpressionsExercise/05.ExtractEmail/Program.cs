using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var text = Console.ReadLine();
        var regex = new Regex("\\s([a-zA-Z0-9][\\w+\\.-]+[\\w])@[\\w-]+[a-zA-Z0-9]+(\\.[\\w]+\\.[\\w]+|\\.[\\w]+)+");
        var matches = regex.Matches(text);

        foreach (var match in matches)
        {
            Console.WriteLine(match.ToString().TrimStart().TrimEnd());
        }

    }
}