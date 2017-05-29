using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        HashSet<double> firstSet = new HashSet<double>();
        HashSet<double> secondSet = new HashSet<double>();

        var n = input[0];
        var m = input[1];

        for (int i = 1; i <= n; i++)
        {
            firstSet.Add(double.Parse(Console.ReadLine()));
        }
        for (int i = 1; i <= m; i++)
        {
            secondSet.Add(double.Parse(Console.ReadLine()));
        }

        firstSet.IntersectWith(secondSet);

        foreach (var item in firstSet)
        {
            Console.WriteLine(item);
        }
    }
}