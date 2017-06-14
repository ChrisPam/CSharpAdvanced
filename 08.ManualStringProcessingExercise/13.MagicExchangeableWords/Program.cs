using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' },
            StringSplitOptions.RemoveEmptyEntries);

        var palindromes = new HashSet<string>();

        foreach (var word in text)
        {
            if (isPalindrome(word))
            {
                palindromes.Add(word);
            }
        }

        Console.WriteLine($"[{string.Join(", ", palindromes.OrderBy(x => x))}]");

    }

    public static bool isPalindrome(string word)
    {
        var count = word.Length;
        if (count % 2 == 0)
        {
            var firstPart = word.Take(count / 2).ToArray();
            var secondPart = word.Skip(count / 2).Take(count / 2).Reverse().ToArray();
            if (string.Join("", firstPart) == string.Join("", secondPart))
            {
                return true;
            }
        }
        else if (count / 2.0 == 1)
        {
            var firstPart = word.ToArray()[0];
            var secondPart = word.ToArray()[1];
            if (firstPart == secondPart)
            {
                return true;
            }
        }
        else
        {
            var firstPart = word.Take((int)count / 2).ToArray();
            var secondPart = word.Skip((count / 2) + 1).Take((int)count / 2).Reverse().ToArray();
            if (string.Join("", firstPart) == string.Join("", secondPart))
            {
                return true;
            }
        }
        return false;
    }
}
