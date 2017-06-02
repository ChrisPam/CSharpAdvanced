using System;
using System.Collections.Generic;
using System.Linq;

class SquareWithMaximumSum
{
    static void Main()
    {
        var matriceLength = Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        var matrice = new int[matriceLength[0]][];
        for (int row = 0; row < matriceLength[0]; row++)
        {
            matrice[row] = Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        }

        var squareMaxSum = int.MinValue;
        var x1 = 0;
        var x2 = 0;
        var y1 = 0;
        var y2 = 0;
        for (int row = 0; row < matrice.Length - 1; row++)
        {
            for (int col = 0; col < matrice[row].Length - 1; col++)
            {
                var squareNewSum = matrice[row][col] 
                    + matrice[row + 1][col] 
                    + matrice[row][col + 1]
                    + matrice[row + 1][col + 1];
                
                if(squareNewSum > squareMaxSum)
                {
                    squareMaxSum = squareNewSum;
                    x1 = matrice[row][col];
                    x2 = matrice[row][col + 1];
                    y1 = matrice[row + 1][col];
                    y2 = matrice[row + 1][col + 1];
                }
            }
        }
        Console.WriteLine($"{x1} {x2}");
        Console.WriteLine($"{y1} {y2}");
        Console.WriteLine(squareMaxSum);
    }
}