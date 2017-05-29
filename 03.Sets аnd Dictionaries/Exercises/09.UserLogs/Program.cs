using System;
using System.Collections.Generic;
using System.Linq;

public class UserLogs
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var userLogs = new Dictionary<string, Dictionary<string, int>>();

        while (input[0].ToLower() != "end")
        {
            var ipArr = input[0].Split('=');
            var ip = ipArr[1];

            var usernameArr = input[2].Split('=');
            var username = usernameArr[1];

            if (!userLogs.ContainsKey(username))
            {
                userLogs[username] = new Dictionary<string, int>();
            }

            if (!userLogs[username].ContainsKey(ip))
            {
                userLogs[username][ip] = 0;
            }

            userLogs[username][ip]++;


            input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        foreach (var users in userLogs.OrderBy(x => x.Key))
        {
            Console.WriteLine(users.Key + ":");
            var result = "";
            foreach (var ip in users.Value)
            {
                result += $"{ ip.Key} => { ip.Value}, ";
            }
            result = result.Remove(result.Length - 2);
            result = result.Insert(result.Length, ".");
            Console.WriteLine(result);

        }
    }
}