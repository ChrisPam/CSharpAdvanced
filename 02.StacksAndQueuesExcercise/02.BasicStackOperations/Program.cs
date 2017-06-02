using System;
using System.Collections.Generic;
using System.Linq;

public class BasicStackOperations
{
    public static void Main()
    {
        string[] commands = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var n = double.Parse(commands[0]);
        var s = double.Parse(commands[1]);
        var x = double.Parse(commands[2]);

        Stack<double> numbers = new Stack<double>();

        List<double> input = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList(); 

        for (int i = 0; i < n; i++)
        {
            numbers.Push(input[i]);
        }

        for (int i = 0; i < s; i++)
        {
            numbers.Pop();
        }
        if (numbers.Contains(x))
        {
            Console.WriteLine("true");
        }
        else if(numbers.Count == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine(numbers.Min());
        }
    }
}