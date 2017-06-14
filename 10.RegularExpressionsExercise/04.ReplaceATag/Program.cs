using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        while (inputLine.ToLower() != "end")
        {
            var regex = new Regex("<a\\s+href=(.*)>(.*)<\\/a>");
            var matches = regex.Matches(inputLine);

            foreach (Match match in matches)
            {
                var link = match.Groups[1].ToString().ToList();
                var text = match.Groups[2];
                var strToReplace = "[URL href=" + string.Join("", link) + "]" + text.ToString() + "[/URL]";
                inputLine = inputLine.Replace(match.ToString(), strToReplace);
            }
            Console.WriteLine(inputLine);
            inputLine = Console.ReadLine();
        }
    }
}