using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        SortedSet<string> compounds = new SortedSet<string>();

        for (int i = 1; i <= n; i++)
        {
            foreach (var element in Console.ReadLine().Split(' ').ToArray())
            {
                compounds.Add(element);
            } 
        }

        Console.WriteLine(string.Join(" ", compounds));
    }
}