using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> usernames = new HashSet<string>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            usernames.Add(Console.ReadLine());
        }

        foreach (var username in usernames)
        {
            Console.WriteLine(username);
        }
    }
}