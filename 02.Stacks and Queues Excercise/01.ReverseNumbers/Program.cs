using System;
using System.Collections.Generic;

public class ReverseNumbers
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var numbers = new Stack<int>();
        foreach (var number in input)
        {
            numbers.Push(int.Parse(number));
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}