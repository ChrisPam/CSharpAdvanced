using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var text = Console.ReadLine();

        var regex = new Regex("[^\\s]+");
        var matches = regex.Matches(text);

        foreach (var match in matches)
        {
            var firstLetter = match.ToString().ToCharArray()[0];
            if (firstLetter.ToString().ToUpper() == firstLetter.ToString())
            {
                Console.WriteLine(match);
            }
        }
    }
}
