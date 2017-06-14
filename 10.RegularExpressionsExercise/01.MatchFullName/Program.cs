using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var username = Console.ReadLine();

        while (username != "end")
        {
            var regex = new Regex("^[A-Z]{1}[a-z]+\\s[A-Z][a-z]+$");
            var match = regex.Match(username);

            if (match.Success)
            {
                Console.WriteLine(match);
            }

            username = Console.ReadLine();
        }
    }
}
