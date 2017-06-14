using System;
using System.Collections.Generic;
using System.Linq;

public class UnicodeCharacters
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var result = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            result.Add(GetEscapeSequence(input[i]));
        }
        Console.WriteLine(string.Join("", result));
    }

    public static string GetEscapeSequence(char c)
    {
        return "\\u" + ((int)c).ToString("x4");
    }
}