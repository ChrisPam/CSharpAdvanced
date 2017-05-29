using System;
using System.Collections.Generic;

class ReverseStrings
{
    static void Main()
    {
        string input = Console.ReadLine();
        Stack<char> reversedString = new Stack<char>();

        foreach (var letter in input)
        {
            reversedString.Push(letter);
        }

        Console.WriteLine(string.Join("", reversedString));

    }
}