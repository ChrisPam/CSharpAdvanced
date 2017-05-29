using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Stack<int> outputNumbers = new Stack<int>();
        for (int i = 1; i <= n; i++)
        {
            int[] inputNumbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();


            if (inputNumbers[0] == 2)
            {
                outputNumbers.Pop();
            }
            else if(inputNumbers[0] == 1)
            {
                outputNumbers.Push(inputNumbers[1]);
            }
            else
            {
                Console.WriteLine(outputNumbers.Max());
            }
        }
    }
}
