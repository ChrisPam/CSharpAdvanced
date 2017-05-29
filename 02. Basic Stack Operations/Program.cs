using System;
using System.Collections.Generic;
using System.Linq;


class BasicStackOperations
{
    static void Main()
    {
        int[] parameters = Console.ReadLine()
            .Trim()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int n = parameters[0];
        int s = parameters[1];
        int x = parameters[2];

        int[] inputNumbers = Console.ReadLine()
            .Trim()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Stack<int> outputNumbers = new Stack<int>();
        for (int i = 0; i < n; i++)
        {
            outputNumbers.Push(inputNumbers[i]);
        }

        for (int i = 0; i < s; i++)
        {
            outputNumbers.Pop();
        }

        bool hasX = outputNumbers.Contains(x);
        if(outputNumbers.Count == 0)
        {
            Console.WriteLine("0");
            return;
        }
        if (hasX)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine(outputNumbers.Min());
        }

    }
}
