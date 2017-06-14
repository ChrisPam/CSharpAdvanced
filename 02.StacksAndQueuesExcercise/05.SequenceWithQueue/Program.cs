using System;
using System.Collections.Generic;
using System.Linq;

public class SequenceWithQueue
{
    public static void Main()
    {
        var number = long.Parse(Console.ReadLine());

        var sequence = new Queue<long>();
        var result = new Queue<long>();
        var s1 = number;
        sequence.Enqueue(s1);
        result.Enqueue(s1);


        for (int i = 0; sequence.Count - 1 < 50; i++)
        {
            var s2 = sequence.Peek() + 1;
            var s3 = 2 * sequence.Peek() + 1;
            var s4 = sequence.Peek() + 2;

            sequence.Dequeue();
            sequence.Enqueue(s2);
            sequence.Enqueue(s3);
            sequence.Enqueue(s4);
            if(result.Count < 50)
            {
                result.Enqueue(s2);
            }
            if(result.Count < 50)
            {
                result.Enqueue(s3);
            }
            if(result.Count < 50)
            {
                result.Enqueue(s4);
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}