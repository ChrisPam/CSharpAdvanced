using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var startInterval = input[0];
        var endInterval = input[1];
        var numbers = new List<int>();
        for (int i = startInterval; i <= endInterval; i++)
        {
            numbers.Add(i);
        }
        var condition = Console.ReadLine();
        Predicate<string> oddOrEven = x => x == "odd";

        if (!oddOrEven(condition))
        {
            numbers.Where(n => n % 2 == 0).ToList().ForEach(x => Console.Write(x + " "));
        }
        else
        {
            numbers.Where(n => n % 2 != 0).ToList().ForEach(x => Console.Write(x + " "));
        }

    }
}