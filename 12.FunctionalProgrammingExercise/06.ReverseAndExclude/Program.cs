using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

        var divideNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(string.Join(" ", numbers.Reverse().Where(n => n % divideNumber != 0)));

    }
}
