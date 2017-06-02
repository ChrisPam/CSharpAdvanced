using System;
using System.Collections.Generic;
using System.Linq;

public class PoisonousPlants
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        var plants = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var dieDays = new int[num];
        var lastPlant = new Stack<int>();
        lastPlant.Push(0);
        for (int i = 1; i < num; i++)
        {
            int lastDay = 0;
            while(lastPlant.Count > 0 && plants[lastPlant.Peek()] >= plants[i])
            {
                lastDay = Math.Max(lastDay, dieDays[lastPlant.Pop()]);
            }

            if(lastPlant.Count > 0)
            {
                dieDays[i] = lastDay + 1;
            }
            lastPlant.Push(i);
        }
        Console.WriteLine(dieDays.Max());
    }
}