using System;
using System.Collections.Generic;
using System.Linq;

class GroupNumbers
{
    static void Main()
    {
        var input = Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var dividingByZero = new List<int>();
        var dividingByOne = new List<int>();
        var dividingByTwo = new List<int>();
        foreach (var item in input)
        {
            if(Math.Abs(item) % 3 == 0)
            {
                dividingByZero.Add(item);
            }
            else if(Math.Abs(item) % 3 == 1)
            {
                dividingByOne.Add(item);
            }
            else if(Math.Abs(item) % 3 == 2)
            {
                dividingByTwo.Add(item);
            }
        }

        Console.WriteLine(string.Join(" ", dividingByZero));
        Console.WriteLine(string.Join(" ", dividingByOne));
        Console.WriteLine(string.Join(" ", dividingByTwo));
    }
}