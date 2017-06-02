using System;
using System.Collections.Generic;
using System.Linq;

public class LegendaryFarming
{
    public static void Main()
    {
        var specialResources = new Dictionary<string, int>();
        var junkResources = new Dictionary<string, int>();
        while (true)
        {
            var input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length - 1; i += 2)
            {
                var quantity = int.Parse(input[i]);
                var resource = input[i + 1].ToLower();

                var motes = 0;
                var fragments = 0;
                var shards = 0;

                if (resource == "motes" || resource == "fragments" || resource == "shards")
                {
                    if(resource == "motes")
                    {
                        motes += quantity;
                    }
                    else if(resource == "fragments")
                    {
                        fragments += quantity;
                    }
                    else if(resource == "shards")
                    {
                        shards += quantity;
                    }
                }
                else
                {
                    if (!junkResources.ContainsKey(resource))
                    {
                        junkResources[resource] = 0;
                    }
                    junkResources[resource] += quantity;
                }

                if (motes >= 250)
                {
                    Console.WriteLine("Dragonwrath obtained!");
                    specialResources["motes"] -= 250;
                    PrintResources(specialResources.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value));
                    PrintResources(junkResources.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value));
                    return;
                }
                else if (fragments >= 250)
                {
                    Console.WriteLine("Valanyr obtained!");
                    specialResources["fragments"] -= 250;
                    PrintResources(specialResources.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value));
                    PrintResources(junkResources.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value));
                    return;
                }
                else if (shards >= 250)
                {
                    Console.WriteLine("Shadowmourne obtained!");
                    specialResources["shards"] -= 250;
 
                    PrintResources(junkResources.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value));
                    return;
                }
            }
        }
    }

    public static void PrintResources(Dictionary<string, int> resources)
    {
        foreach (var resource in resources)
        {
            Console.WriteLine($"{resource.Key}: {resource.Value}");
        }
    }
}