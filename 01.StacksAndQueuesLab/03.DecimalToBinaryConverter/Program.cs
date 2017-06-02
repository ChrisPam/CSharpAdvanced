using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        var input = int.Parse(Console.ReadLine());
        Stack<int> binary = new Stack<int>();

        if (input != 0)
        {
            while (input != 0)
            {
                binary.Push(input % 2);
                input /= 2;
            }
        }
        else
        {
            binary.Push(input);
        }

        Console.WriteLine(string.Join("", binary));
    }
}