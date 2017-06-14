using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var username = Console.ReadLine();

        while (username != "END")
        {
            var regex = new Regex(@"^[\w-]{3,16}$");
            var matches = regex.Matches(username);

            if (matches.Count > 0)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
            username = Console.ReadLine();
        }

    }
}
