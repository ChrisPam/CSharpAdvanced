using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

        var input = Console.ReadLine();
        while (input != "end")
        {
            switch (input)
            {
                case "add":
                    numbers = numbers.Select(x => x + 1);
                    break;
                case "multiply":
                    numbers = numbers.Select(x => x * 2);
                    break;
                case "subtract":
                    numbers = numbers.Select(x => x - 1);
                    break;
                case "print":
                    numbers.ToList().ForEach(x => Console.Write(x + " "));
                    Console.WriteLine();
                    break;
            }
            input = Console.ReadLine();
        }
    }
}