using System;
using System.Collections.Generic;
using System.Linq;

public class HotPotato
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var step = int.Parse(Console.ReadLine());
        var circle = new Queue<string>(input);

        var counter = 1;
        while (circle.Count > 1)
        {
            for (int i = 1; i < step; i++)
            {
                circle.Enqueue(circle.Dequeue());
            }
            if (isPrime(counter))
            {
                Console.WriteLine($"Prime {circle.Peek()}");
            }
            else
            {
                Console.WriteLine($"Removed {circle.Dequeue()}");
            }
            counter++;

        }
        Console.WriteLine($"Last is {circle.Dequeue()}");
    }

    public static bool isPrime(int counter)
    {
        var numberDividers = 0;
        if (counter != 1)
        {
            for (int i = 2; i < counter; i++)
            {
                if (counter % i == 0)
                {
                    numberDividers = numberDividers + 1;

                }
                else
                {
                    numberDividers = numberDividers + 0;
                }
            }

            if (numberDividers == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
