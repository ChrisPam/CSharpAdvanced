using System;
using System.Collections.Generic;
using System.Linq;

public class HotPotato
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var step = int.Parse(Console.ReadLine());
        var circle = new Queue<string>(input);

        while (circle.Count > 1)
        {
            for (int i = 1; i < step; i++)
            {
                circle.Enqueue(circle.Dequeue());
            }
            Console.WriteLine($"Removed {circle.Dequeue()}");
        }
        Console.WriteLine($"Last is {circle.Dequeue()}");
    }
}
