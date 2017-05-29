using System;
using System.Collections.Generic;
using System.Linq;

public class PeriodicTable
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var periodicTable = new HashSet<string>();

        for (int i = 1; i <= n; i++)
        {
            var elements = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var element in elements)
            {
                periodicTable.Add(element);
            }
        }

        Console.WriteLine(string.Join(" ", periodicTable.OrderBy(x => x)));
    }
}