using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();

        while (input != "END")
        {
            var regex = new Regex(@"([01][0-9]):([0-5][0-9]):([0-5][0-9])(?:\s)[A|P]M");
            var match = regex.Match(input);

            if (match.Success)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }

            input = Console.ReadLine();
        }
    }
}