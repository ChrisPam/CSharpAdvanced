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
        while (inputLine != "END")
        {
            if (inputLine.Contains("+%20"))
            {
                inputLine = inputLine.Replace("+%20", " ");
            }
            inputLine = inputLine.Replace('+', ' ');
            inputLine = inputLine.Replace("%20", " ");
            inputLine = Regex.Replace(inputLine, "\\s+", " ");
            var query = new Dictionary<string, List<string>>();
            var regex = new Regex(@"([\w:\/.\s%*\-!,;#]+)\s*=\s*([\w:\/.\s%*\-!,;#]+)(:?\n+|&|)");
            var matches = regex.Matches(inputLine);

            foreach (Match match in matches)
            {
                var key = match.Groups[1].ToString().Trim();
                var value = match.Groups[2].ToString().Trim();
                if (!query.ContainsKey(key))
                {
                    query[key] = new List<string>();
                }
                query[key].Add(value);
            }
            foreach (var kvp in query)
            {
                if (kvp.Value.Count > 1)
                {
                    Console.Write($"{kvp.Key}=[{string.Join(", ", kvp.Value)}]");
                }
                else
                {
                    Console.Write($"{kvp.Key}=[{string.Join("", kvp.Value)}]");
                }
            }
            Console.WriteLine();

            inputLine = Console.ReadLine();
        }
    }
}
