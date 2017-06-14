using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main()
    {
        Console.ReadLine()
            .Split(new char[] { ' ', ',' },
            StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .Select(num => num += num * 0.20)
            .ToList()
            .ForEach(num => Console.WriteLine(string.Format("{0:f2}", num)));
    }
}