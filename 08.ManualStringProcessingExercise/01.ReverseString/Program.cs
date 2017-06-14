using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class ReverseString
{
    public static void Main()
    {
        var input = Console.ReadLine().ToArray();
        Array.Reverse(input);
        Console.WriteLine(input);
    }
}
