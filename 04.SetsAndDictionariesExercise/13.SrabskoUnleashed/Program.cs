using System;
using System.Collections.Generic;
using System.Linq;

public class SrabskoUnleashed
{
    public static void Main()
    {
        //singer @venue ticketsPrice ticketsCount
        var input = Console.ReadLine().Split(new string[] { " @" }, StringSplitOptions.RemoveEmptyEntries);

        var concerts = new Dictionary<string, Dictionary<string, int>>();
        while (input[0].ToLower() != "end")
        {
            if (input.Length == 2)
            {
                var name = string.Join(" ", input[0].Trim());
                var rightPart = new List<string>(input[1]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray());
                if (rightPart.Count >= 3)
                {
                    try
                    {
                        var peopleOnConcert = int.Parse(rightPart[rightPart.Count - 1]);
                        rightPart.RemoveAt(rightPart.Count - 1);
                        var ticketPrice = int.Parse(rightPart[rightPart.Count - 1]);
                        rightPart.RemoveAt(rightPart.Count - 1);
                        var placeList = new List<string>();
                        for (int i = 0; i < rightPart.Count; i++)
                        {
                            placeList.Add(rightPart[i]);
                        }
                        var place = string.Join(" ", placeList);
                        if (!concerts.ContainsKey(place))
                        {
                            concerts[place] = new Dictionary<string, int>();
                        }
                        if (!concerts[place].ContainsKey(name))
                        {
                            concerts[place][name] = 0;
                        }
                        concerts[place][name] += peopleOnConcert * ticketPrice;
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            input = Console.ReadLine().Split(new string[] { " @" }, StringSplitOptions.RemoveEmptyEntries);
        }
        foreach (var concert in concerts)
        {
            Console.WriteLine($"{concert.Key}");
            foreach (var singer in concert.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
            }
        }
    }
}