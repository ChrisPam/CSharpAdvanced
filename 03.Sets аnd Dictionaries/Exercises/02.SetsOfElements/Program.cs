using System;
using System.Collections.Generic;
using System.Linq;

public class SetsOfElements
{
    public static void Main()
    {
        var commandValues = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var n = int.Parse(commandValues[0]);
        var m = int.Parse(commandValues[1]);

        var nHash = new HashSet<double>();
        var mHash = new HashSet<double>();

        for (int i = 1; i <= n; i++)
        {
            nHash.Add(double.Parse(Console.ReadLine()));
        }
        for (int i = 1; i <= m; i++)
        {
            mHash.Add(double.Parse(Console.ReadLine()));
        }
        nHash.IntersectWith(mHash);
        Console.WriteLine(string.Join(" ", nHash));
    }
}
