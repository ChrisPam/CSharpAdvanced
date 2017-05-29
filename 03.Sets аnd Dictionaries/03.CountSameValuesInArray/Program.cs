using System;
using System.Collections.Generic;
using System.Linq;

public class CountSameValuesInArray
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
        var numbersCounts = new SortedDictionary<double, int>();
        foreach (var number in inputNumbers)
        {
            if (!numbersCounts.ContainsKey(number))
            {
                numbersCounts[number] = 0;
            }
            numbersCounts[number]++;
        }

        foreach (var numbersCountPair in numbersCounts)
        {
            Console.WriteLine($"{numbersCountPair.Key} - {numbersCountPair.Value} times");
        }
    }
}