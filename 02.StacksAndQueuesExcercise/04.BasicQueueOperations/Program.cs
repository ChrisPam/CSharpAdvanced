using System;
using System.Collections.Generic;
using System.Linq;

public class BasicQueueOperations
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var countToPush = int.Parse(input[0]);
        var countToPop = int.Parse(input[1]);
        var checkNumber = int.Parse(input[2]);

        var numbersInput = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        var numbers = new Queue<double>();

        for (int i = 0; i <= countToPush - 1; i++)
        {
            numbers.Enqueue(numbersInput[i]);
        }
        for (int i = 0; i <= countToPop - 1; i++)
        {
            numbers.Dequeue();
        }

        if (numbers.Contains(checkNumber))
        {
            Console.WriteLine("true");
        }
        else
        {
            if (numbers.Count() == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}