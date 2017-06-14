using System;
using System.Collections.Generic;
using System.Linq;

public class ParseTags
{
    public static void Main()
    {
        var text = Console.ReadLine();

        var startIndex = text.IndexOf("<upcase>");
        var endIndex = text.IndexOf("</upcase>");

        while(startIndex >= 0 && endIndex >= 0)
        {
            var stringToRemove = text.Substring(startIndex, endIndex + 9 - startIndex);
            var upcaseString = text.Substring(startIndex + 8, endIndex - 8 - startIndex );
            text = text.Replace(stringToRemove, upcaseString.ToUpper());

            startIndex = text.IndexOf("<upcase>");
            endIndex = text.IndexOf("</upcase>");
        }

        Console.WriteLine(text);
    }
}
