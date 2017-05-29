using System;
using System.Collections.Generic;
using System.Linq;

class ReverseNumbers
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Trim()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Stack<int> reversed = new Stack<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            reversed.Push(numbers[i]);
        }
        Console.WriteLine(string.Join(" ", reversed));
        
    }
}
