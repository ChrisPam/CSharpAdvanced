using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var people = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        var resultPeople = new HashSet<string>();
        var input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        while (input[0].ToLower() != "print")
        {
            if (input[0].ToLower() == "add filter")
            {
                if (input[1].ToLower() == "starts with")
                {
                    people.Where(x => x.IndexOf(input[2]) != 0).ToList().ForEach(x => resultPeople.Add(x));
                }
                else if (input[1].ToLower() == "ends with")
                {
                    people.Where(x => x.IndexOf(input[2]) != x.Length - input[2].Length).ToList().ForEach(x => resultPeople.Add(x));
                }
                else if (input[1].ToLower() == "length")
                {
                    people.Where(x => x.Length == int.Parse(input[2])).ToList().ForEach(x => resultPeople.Add(x));

                }
                else if (input[1].ToLower() == "contains")
                {
                    people.Where(x => x.Contains(input[2])).ToList().ForEach(x => resultPeople.Add(x));
                }
            }
            else if (input[0].ToLower() == "remove filter")
            {
                if (input[1].ToLower() == "starts with")
                {
                    people.Where(x => x.IndexOf(input[2]) == 0).ToList().ForEach(x => resultPeople.Add(x));
                }
                else if (input[1].ToLower() == "ends with")
                {
                    people.Where(x => x.IndexOf(input[2]) == x.Length - input[2].Length).ToList().ForEach(x => resultPeople.Add(x));

                }
                else if (input[1].ToLower() == "length")
                {
                    people.Where(x => x.Length != int.Parse(input[2])).ToList().ForEach(x => resultPeople.Add(x));

                }
                else if (input[1].ToLower() == "contains")
                {
                    people.Where(x => x.Contains(input[2])).ToList().ForEach(x => resultPeople.Add(x));

                }
            }

            input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        }
        Console.WriteLine(string.Join(" ", resultPeople));
    }

}
