using System;
using System.Collections.Generic;
using System.Linq;

public class FormattingNumbers
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(new char[] { ' ', '\t' },
            StringSplitOptions.RemoveEmptyEntries);
        var a = long.Parse(input[0]);
        var aToHex = a.ToString("X");
        var aToBinary = Convert.ToString(a, 2);
        if (aToBinary.Length >= 10)
        {
            aToBinary = aToBinary.Substring(0, 10);
        }
        var b = decimal.Parse(input[1]);
        var c = decimal.Parse(input[2]).ToString("f3");
        Console.WriteLine($"|{aToHex.PadRight(10)}|{aToBinary.PadLeft(10, '0')}|{b,10:f2}|{c.PadRight(10)}|");
    }
}