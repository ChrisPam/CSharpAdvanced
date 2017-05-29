using System;
using System.Collections.Generic;
using System.Linq;

class SimpleCalculator
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        Stack<string> calculator = new Stack<string>();

        for (int i = input.Length -1; i >= 0; i--)
        {
            calculator.Push(input[i]);
        }
        while (calculator.Count != 1)
        {
            var firstNumber = calculator.Pop();
            var command = calculator.Pop();
            var secondNumber = calculator.Pop();

            if(command == "+")
            {
                calculator.Push((double.Parse(firstNumber) + double.Parse(secondNumber)).ToString());
            }
            else if(command == "-")
            {
                calculator.Push((double.Parse(firstNumber) - double.Parse(secondNumber)).ToString());
            }
        }

        Console.WriteLine(calculator.Peek());
    }
}
