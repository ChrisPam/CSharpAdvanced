using System;
using System.Collections.Generic;
using System.Linq;

public class CountSymbols
{
    public static void Main()
    {
        var symbols = new SortedDictionary<char, int>();

        var input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            if (!symbols.ContainsKey(input[i]))
            {
                symbols[input[i]] = 0;
            }
            symbols[input[i]]++;
        }

        foreach (var symbol in symbols)
        {
            Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
        }
    }
}
