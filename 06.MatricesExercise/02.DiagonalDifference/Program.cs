using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var matrice = new int[n][];
        for (int i = 0; i < n; i++)
        {
            matrice[i] = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        var primaryDiagonalSum = 0;
        var secondaryDiagonalSum = 0;

        for (int i = 0; i < n; i++)
        {
            primaryDiagonalSum += matrice[i][i];
            secondaryDiagonalSum += matrice[i][n - i - 1];
        }
        var diff = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
        Console.WriteLine(diff);
    }
}
