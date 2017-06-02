using System;
using System.Collections.Generic;
using System.Linq;

public class BalancedParenthesis
{
    public static void Main()
    {
        string input = Console.ReadLine();
        char[] openingBrackets = { '(', '[', '{' };
        char[] closingBrackets = { ')', ']', '}' };

        Stack<char> brackets = new Stack<char>();

        for (int i = 0; i < input.Length; i++)
        {
            if (openingBrackets.Contains(input[i]))
            {
                brackets.Push(input[i]);
            }
            else
            {
                if (brackets.Count > 0)
                {
                    var firstPosition = 0;
                    for (int j = 0; j < openingBrackets.Length; j++)
                    {
                        if (brackets.Peek() == openingBrackets[j])
                        {
                            firstPosition = j;
                            break;
                        }
                    }
                    var secondPosition = 0;
                    for (int j = 0; j < closingBrackets.Length; j++)
                    {
                        if (input[i] == closingBrackets[j])
                        {
                            secondPosition = j;
                            break;
                        }
                    }
                    if (firstPosition == secondPosition)
                    {
                        brackets.Pop();
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
        }

        if (brackets.Count == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}