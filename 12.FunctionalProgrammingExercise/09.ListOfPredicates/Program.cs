using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var range = int.Parse(Console.ReadLine());
        var numbers = new List<int>();
        for (int i = 1; i <= range; i++)
        {
            numbers.Add(i);
        }
        var divideNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        var resultedNumbers = new List<int>();
        resultedNumbers = numbers.Where(x => x % divideNumbers[0] == 0).ToList();
        foreach (var number in divideNumbers)
        {
            resultedNumbers = resultedNumbers.Where(x => x % number == 0).ToList();
        }
        Console.WriteLine(string.Join(" ", resultedNumbers));
    }
}