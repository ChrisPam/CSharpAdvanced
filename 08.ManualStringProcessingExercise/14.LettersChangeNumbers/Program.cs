using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();

        var regex = new Regex(@"([a-zA-Z]){1}([\d]+)([a-zA-Z]){1}");
        var matches = regex.Matches(input);

        var sum = 0.0;

        foreach (Match combination in matches)
        {
            var firstLetter = combination.Groups[1];
            var number = double.Parse(combination.Groups[2].ToString());
            var secondLetter = combination.Groups[3];

            var matchSum = 0.0;

            if(whatCase(firstLetter.ToString()) == "uppercase")
            {
                matchSum = number / letterPosition(firstLetter.ToString());
            }
            else
            {
                matchSum = number * letterPosition(firstLetter.ToString());
            }
            if(whatCase(secondLetter.ToString()) == "uppercase")
            {
                matchSum -= letterPosition(secondLetter.ToString());
            }
            else
            {
                matchSum += letterPosition(secondLetter.ToString());
            }
            sum += matchSum;
        }
        Console.WriteLine($"{sum:f2}");
    }

    public static int letterPosition(string firstLetter)
    {
        var letter = Convert.ToChar(firstLetter.ToUpper());
        var position = letter - 64;

        return position;
    }

    public static string whatCase(string firstLetter)
    {
        if(Convert.ToChar(firstLetter) >= 65 && Convert.ToChar(firstLetter) <= 90)
        {
            return "uppercase";
        }
        else
        {
            return "lowercase";
        }
    }
}
