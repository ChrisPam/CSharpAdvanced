using System;
using System.Collections.Generic;

public class UniqueUsernames
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var usernames = new HashSet<string>();

        for (int i = 1; i <= n; i++)
        {
            usernames.Add(Console.ReadLine());
        }

        foreach (var user in usernames)
        {
            Console.WriteLine(user);
        }
    }
}