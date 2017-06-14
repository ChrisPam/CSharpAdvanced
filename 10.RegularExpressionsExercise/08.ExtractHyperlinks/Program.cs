using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var results = new Queue<string>();

        StringBuilder sb = new StringBuilder();
        while (inputLine != "END")
        {
            sb.Append(inputLine + " ");
            inputLine = Console.ReadLine();
        }
        var regex = new Regex(@"<a\s+[^>]*?href\s*=(.*?)>.*?<\s*\/\s*a\s*>");
        var matches = regex.Matches(sb.ToString());

        foreach (Match match in matches)
        {
            var href = match.Groups[1].ToString().Trim();
            var result = "";
            if (href.ToCharArray()[0] == '"')
            {
                var temp = href.Split(new[] { '"' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                result = temp[0];
            }
            else if (href.ToCharArray()[0] == '\'')
            {
                var temp = href.Split(new[] { '\'' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                result = temp[0];
            }
            else
            {
                var temp = href.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                result = temp[0];
            }

            results.Enqueue(result);
        }

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
}