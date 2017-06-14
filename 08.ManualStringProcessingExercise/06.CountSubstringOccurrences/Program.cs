using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine().ToLower();
        string word = Console.ReadLine().ToLower();

        int counter = 0;
        while (input.IndexOf(word) >= 0)
        {
            var sub = input.IndexOf(word);
            var length = word.Length - 1;
            if(word.Length == 1)
            {
                length = 1;
            }
            input = input.Remove(sub, length);
            counter++;
        }
        Console.WriteLine(counter);
    }
}