using System;
using System.Collections.Generic;
using System.Linq;

public class MatrixOfPalindromes
{
    public static void Main()
    {
        var matriceLength = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var rowsLength = matriceLength[0];
        var colLength = matriceLength[1];

        var matrice = new string[rowsLength][];

        for (int i = 0; i < rowsLength; i++)
        {
            var rowList = new List<string>();
            var firstChar = Convert.ToChar(97 + i);
            for (int middleLetter = i; middleLetter < colLength + i; middleLetter++)
            {
                var middleChar = Convert.ToChar(97 + middleLetter);
                rowList.Add($"{firstChar}{middleChar}{firstChar}");
            }
            matrice[i] = rowList.ToArray();
        }

        for (int row = 0; row < rowsLength; row++)
        {
            Console.WriteLine(string.Join(" ", matrice[row]));
        }
    }
}
