using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SimpleTextEditor
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var versions = new Stack<string>();
        string text = "";
        versions.Push(text);
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (input[0] == "1")
            {
                // logic for add string to text
                var word = input[1];
                text += word;
                versions.Push(text);
            }
            else if(input[0] == "2")
            {
                // logic for erase count chars from text
                var count = int.Parse(input[1]);
                StringBuilder str = new StringBuilder();
                text = text.Substring(0, text.Length - count);
                versions.Push(text);
            }
            else if(input[0] == "3")
            {
                // logic for return the element on position INDEX from text
                int index = int.Parse(input[1]);
                Console.WriteLine(text[index - 1]);
            }
            else if(input[0] == "4")
            {
                // undoes count times
                versions.Pop();
                text = versions.Peek();
            }
        }
    }
}