using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program
{
    static void Main()
    {
        var text = Console.ReadLine();
        List<string> final = new List<string>();
        Regex rgx = new Regex(@"\[\w+\<(\d+)REGEH(\d+)\>\w+\]");
        var matches = rgx.Matches(text);

        var index = 0;
        foreach (Match match in matches)
        {
            var firstNum = int.Parse(match.Groups[1].ToString());
            var secondNum = int.Parse(match.Groups[2].ToString());
            CheckForOverflow(text, index);
            index += firstNum;
            final.Add(text[index].ToString());

            index += secondNum;
            CheckForOverflow(text, index);
            final.Add(text[index].ToString());
        }
        Console.WriteLine(string.Join("", final));
    }

    private static void CheckForOverflow(string text, int index)
    {
        if (index >= text.Length)
        {
            index = index % (text.Length - 1);
        }
    }
}