using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var text = Console.ReadLine();
        var pattern = Console.ReadLine();

        while (true)
        {
            var length = pattern.Count() / 2;
            var startIndex = text.IndexOf(pattern);
            var endIndex = text.LastIndexOf(pattern);
            if (startIndex == -1 || startIndex == endIndex)
            {
                break;
            }

            text = text.Remove(endIndex, pattern.Length);
            text = text.Remove(startIndex, pattern.Length);
            Console.WriteLine("Shaked it.");
            if (pattern.Length <= 1)
                break;
            pattern = pattern.Remove(length, 1);


        }
        Console.WriteLine("No shake.");
        Console.WriteLine(text);
    }
}