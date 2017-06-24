using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MapDistricts
{
    class Program
    {
        static void Main(string[] args)
        {
            var populationInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<long>> population = new Dictionary<string, List<long>>();
            foreach (var item in populationInput)
            {
                var data = item.Split(new char[] { ':' },StringSplitOptions.RemoveEmptyEntries);
                var town = data[0];
                var district = data[1];
                if (!population.ContainsKey(town))
                {
                    population[town] = new List<long>();
                }
                population[town].Add(long.Parse(district));
            }
            var minDistrict = long.Parse(Console.ReadLine());
            population = population.Where(x => x.Value.Sum() > minDistrict).OrderByDescending(x => x.Value.Sum()).ToDictionary(x => x.Key, x => x.Value);
            foreach (var kvp in population)
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(" ", kvp.Value.OrderByDescending(x => x).Take(5))}");
            }
        }
    }
}
