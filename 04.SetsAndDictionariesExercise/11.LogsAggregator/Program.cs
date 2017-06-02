using System;
using System.Collections.Generic;
using System.Linq;

public class LogsAggregator
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var logs = new Dictionary<string, Dictionary<string, int>>();
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(' ');
            var ip = input[0];
            var username = input[1];
            var duration = int.Parse(input[2]);
            if (!logs.ContainsKey(username))
            {
                logs[username] = new Dictionary<string, int>();
            }

            if (!logs[username].ContainsKey(ip))
            {
                logs[username][ip] = 0;
            }

            logs[username][ip] += duration;
        }
        foreach (var log in logs.OrderBy(x => x.Key))
        {
            Console.Write(log.Key);
            Console.Write($": {log.Value.Values.Sum()} [");
            var result = "";
            foreach (var ip in log.Value.OrderBy(x => x.Key))
            {
                result += $"{ip.Key}, ";
            }
            result = result.Remove(result.Length - 2);
            Console.Write(result);
            Console.WriteLine("]");
        }
    }
}