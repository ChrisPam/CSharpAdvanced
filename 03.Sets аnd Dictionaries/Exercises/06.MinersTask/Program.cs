using System;
using System.Collections.Generic;
using System.Linq;

public class MinerTask
{
    public static void Main()
    {
        var mine = new Dictionary<string, int>();
        var input = Console.ReadLine();
        while (input.ToLower() != "stop")
        {
            var resource = input;
            var quantity = int.Parse(Console.ReadLine());

            if (!mine.ContainsKey(resource))
            {
                mine[resource] = 0;
            }
            mine[resource] += quantity;

            input = Console.ReadLine();
        }

        foreach (var resource in mine)
        {
            Console.WriteLine($"{resource.Key} -> {resource.Value}");
        }
    }
}
