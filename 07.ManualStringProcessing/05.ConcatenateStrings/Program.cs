using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ConcatenateStrings
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            sb.Append(Console.ReadLine()).Append(" ");
        }

        Console.WriteLine(sb);
    }
}