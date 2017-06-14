using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(string.Join(", ", Console.ReadLine()
            .Split(new char[] { ' ', ',' },
            StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(num => num % 2 == 0)
            .OrderBy(num => num).ToArray()));
    }
}
