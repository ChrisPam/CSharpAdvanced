using System;
using System.Collections.Generic;
using System.Linq;

public class SoftUniParty
{
    public static void Main()
    {
        SortedSet<string> people = new SortedSet<string>();
        SortedSet<string> vipPeople = new SortedSet<string>();

        var input = Console.ReadLine();

        while (input.ToLower() != "party")
        {
            input.ToCharArray();
            try
            {
                int num = int.Parse(input[0].ToString());
                vipPeople.Add(input);
            }
            catch (Exception)
            {
                people.Add(input);
            }

            input = Console.ReadLine();
        }

        input = Console.ReadLine();
        while (input.ToLower() != "end")
        {
            try
            {
                int num = int.Parse(input[0].ToString());
                vipPeople.Remove(input);
            }
            catch (Exception)
            {
                people.Remove(input);
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(people.Count() + vipPeople.Count);
        foreach (var vipPerson in vipPeople)
        {
            Console.WriteLine(vipPerson);
        }
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }
    }
}