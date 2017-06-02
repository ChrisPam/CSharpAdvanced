using System;
using System.Collections.Generic;
using System.Linq;

public class StackFibonacci
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        var fibNumbers = new Stack<long>();

        fibNumbers.Push(0);
        fibNumbers.Push(1);

        for (int i = 0; i < number - 1; i++)
        {
            var firstNumber = fibNumbers.Pop();
            var lastNumber = fibNumbers.Pop();
            var resultNumber = firstNumber + lastNumber;
            fibNumbers.Push(firstNumber);
            fibNumbers.Push(resultNumber);
        }
        Console.WriteLine(fibNumbers.Pop());
    }
}