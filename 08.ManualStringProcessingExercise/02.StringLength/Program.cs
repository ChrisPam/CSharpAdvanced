using System;
using System.Collections.Generic;
using System.Linq;

public class StringLength
{
    public static void Main()
    {
        var text = Console.ReadLine();
        if (text.Length < 20)
        {
            Console.WriteLine(text.Substring(0) + new string('*', 20 - text.Length));
        }
        else
        {
            Console.WriteLine(text.Substring(0, 20));
        }
    }
}