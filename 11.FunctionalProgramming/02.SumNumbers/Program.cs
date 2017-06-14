using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ', ',' },
            StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);

        var count = 0;
        numbers.ToList().ForEach(n => count++);

        Console.WriteLine(count);
        Console.WriteLine(numbers.Sum());
    }
}