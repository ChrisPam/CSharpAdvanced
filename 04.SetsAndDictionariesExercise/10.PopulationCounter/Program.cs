using System;
using System.Collections.Generic;
using System.Linq;

public class PopulationCounter
{
    public static void Main()
    {
        var input = Console.ReadLine().Split('|');

        var populations = new Dictionary<string, Dictionary<string, long>>();

        while (input[0].ToLower() != "report")
        {
            var city = input[0];
            var country = input[1];
            var population = long.Parse(input[2]);

            if (!populations.ContainsKey(country))
            {
                populations[country] = new Dictionary<string, long>();
            }

            if (!populations[country].ContainsKey(city))
            {
                populations[country][city] = 0;
            }

            populations[country][city] = population;


            input = Console.ReadLine().Split('|');
        }



        foreach (var population in populations.OrderByDescending(x => x.Value.Values.Sum()))
        {
            long populationValue = 0;
            foreach (var city in population.Value)
            {
                populationValue += city.Value;
            }
            Console.WriteLine($"{population.Key} (total population: {populationValue})");
            foreach (var city in population.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }

        }
    }
}
