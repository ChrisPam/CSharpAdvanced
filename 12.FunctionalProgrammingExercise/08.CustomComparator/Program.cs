using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
        var oddNumbers = new List<int>();
        var evenNumbers = new List<int>();
        foreach (var number in numbers)
        {
            if(Math.Abs(number) % 2 == 0)
            {
                evenNumbers.Add(number);
            }
            else
            {
                oddNumbers.Add(number);
            }
        }
        Console.WriteLine("{0} {1}", string.Join(" ", evenNumbers.OrderBy(x => x)), string.Join(" ", oddNumbers.OrderBy(x => x)));
    }
}