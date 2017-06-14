using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var text = Console.ReadLine();

        var regex = new Regex("\\b([a-zA-Z])(\\w){2,24}\\b");
        var matches = regex.Matches(text);

        List<string> usernames = new List<string>();
        foreach (var match in matches)
        {
            usernames.Add(match.ToString());
        }
        var maxLength = int.MinValue;
        var firstUsername = "";
        var secondUsername = "";
        for (int i = 0; i < usernames.Count - 1; i++)
        {
            var first = usernames[i];
            var second = usernames[i + 1];

            var sum = first.Length + second.Length;
            if (sum  > maxLength)
            {
                maxLength = sum;
                firstUsername = first;
                secondUsername = second;
            }
        }
        
        if(usernames[usernames.Count - 1].Length + usernames[usernames.Count - 2].Length > maxLength)
        {
            firstUsername = usernames[usernames.Count - 1];
            secondUsername = usernames[usernames.Count - 2];
        }
        Console.WriteLine(firstUsername);
        Console.WriteLine(secondUsername);
    }
}
