using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, int> people = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var name = input[0];
            var age = input[1];

            people[name] = int.Parse(age);
        }
        var condition = Console.ReadLine();
        var sortAge = int.Parse(Console.ReadLine());
        var filtered = FilterPeople(people, condition, sortAge);
        var format = Console.ReadLine();
        DisplayPeople(filtered, format);
    }

    private static void DisplayPeople(Dictionary<string, int> filtered, string format)
    {
        if(format.Split(' ').Length == 2)
        {
            foreach (var person in filtered)
            {
                Console.WriteLine($"{person.Key} - {person.Value}");
            }
        }
        else if(format.Split(' ')[0] == "name")
        {
            foreach (var person in filtered)
            {
                Console.WriteLine($"{person.Key}");
            }
        }
        else if(format.Split(' ')[0] == "age")
        {
            foreach (var person in filtered)
            {
                Console.WriteLine($"{person.Value}");
            }
        }
    }

    private static Dictionary<string, int> FilterPeople(Dictionary<string, int> people, string condition, int sortAge)
    {
        if (condition == "older")
        {
            people = people.Where(p => p.Value >= sortAge).ToDictionary(p => p.Key, p => p.Value);
        }
        else if (condition == "younger")
        {
            people = people.Where(p => p.Value <= sortAge).ToDictionary(p => p.Key, p => p.Value);
        }

        return people;
    }
}