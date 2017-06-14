using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var text = Console.ReadLine();

        while (text != "END")
        {
            var regex = new Regex(@"<.*?>");
            var matches = regex.Matches(text);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }

            text = Console.ReadLine();
        }

    }
}
