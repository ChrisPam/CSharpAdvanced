using System;
using System.Collections.Generic;

public class MaximumElement
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Stack<int> numbers = new Stack<int>();
        int maxNumber = int.MinValue;

        for (int i = 1; i <= n; i++)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if(input[0] == "1")
            {
                // logic for push element x to stack

                int number = int.Parse(input[1]);
                numbers.Push(number);

                if(number > maxNumber)
                {
                    maxNumber = number;
                }

            }
            else if(input[0] == "2")
            {
                // logic for pop last element from stack
                numbers.Pop();
                maxNumber = int.MinValue;
            }
            else if(input[0] == "3")
            {
                // logic for print max element in stack
                Console.WriteLine(maxNumber);
            }
        }
    }
}