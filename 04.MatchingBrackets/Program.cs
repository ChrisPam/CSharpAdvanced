using System;
using System.Collections.Generic;

class MatchingBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();

        char[] openingBrackets = { '(', '[', '{' };
        char[] closingBrackets = { ')', ']', '}' };

        Stack<int> brackets = new Stack<int>();

        int startIndex = 0;
        int endIndex = 0;
        for (int i = 0; i < input.Length; i++)
        {

            foreach (var bracket in openingBrackets)
            {
                if (input[i].Equals(bracket))
                {
                    brackets.Push(i);
                    startIndex = i;
                    break;
                }
            }

            foreach (var bracket in closingBrackets)
            {
                if (input[i].Equals(bracket))
                {
                    var start = brackets.Peek();
                    brackets.Pop();
                    endIndex = i;
                    string result = "";
                    for (int j = start; j <= i; j++)
                    {
                        result += input[j];
                    }
                    Console.WriteLine(result);
                }
            }
        }

    }
}