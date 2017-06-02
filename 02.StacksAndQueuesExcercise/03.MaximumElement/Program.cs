using System;
using System.Collections.Generic;

public class MaximumElement
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Stack<int> numbers = new Stack<int>();
        Stack<int> maxNumbers = new Stack<int>();
        maxNumbers.Push(int.MinValue);
        var max = 0;
        for (int i = 1; i <= n; i++)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if(input[0] == "1")
            {
                // logic for push element x to stack

                int number = int.Parse(input[1]);
                if(number > maxNumbers.Peek())
                {
                    maxNumbers.Push(number);
                }
                numbers.Push(number);
            }
            else if(input[0] == "2")
            {
                // logic for pop last element from stack
                var element = numbers.Pop();
                if(element == maxNumbers.Peek())
                {
                    maxNumbers.Pop();
                }
            }
            else if(input[0] == "3")
            {
                // logic for print max element in stack
                Console.WriteLine(maxNumbers.Peek());
            }
        }
    }
}