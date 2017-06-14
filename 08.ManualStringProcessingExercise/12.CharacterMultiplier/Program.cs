using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);

        var firstStr = input[0];
        var secondStr = input[1];

        var firstStrChars = new Queue<char>();
        var secondStrChars = new Queue<char>();

        var sum = 0;

        foreach (var letter in firstStr)
        {
            firstStrChars.Enqueue(letter);
        }

        foreach (var letter in secondStr)
        {
            secondStrChars.Enqueue(letter);
        }

        var i = 0;
        while (true)
        {
            if (firstStrChars.Count > 0 && secondStrChars.Count > 0)
            {
                sum += firstStrChars.Dequeue() * secondStrChars.Dequeue();
            }
            else if(firstStrChars.Count > 0 && secondStrChars.Count == 0)
            {
                sum += firstStrChars.Dequeue();
            }
            else if(firstStrChars.Count == 0 && secondStrChars.Count > 0)
            {
                sum += secondStrChars.Dequeue();
            }

            if(firstStrChars.Count == 0 && secondStrChars.Count == 0)
            {
                break;
            }
        }

        Console.WriteLine(sum);

    }
}
