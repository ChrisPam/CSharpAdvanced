using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(string.Join(" ", Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .Distinct()
            .Where(x => x >= 10)
            .Where(x => x <= 20)
            .Take(2)
            .ToList()));
    }
}