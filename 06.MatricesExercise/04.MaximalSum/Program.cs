using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        var matriceLength = Console.ReadLine()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        var matrice = new int[matriceLength[0]][];
        for (int row = 0; row < matriceLength[0]; row++)
        {
            matrice[row] = Console.ReadLine()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        }

        var squareMaxSum = int.MinValue;
        var x1 = 0;
        var x2 = 0;
        var x3 = 0;
        var y1 = 0;
        var y2 = 0;
        var y3 = 0;
        var z1 = 0;
        var z2 = 0;
        var z3 = 0;
        for (int row = 0; row < matrice.Length - 2; row++)
        {
            for (int col = 0; col < matrice[row].Length - 2; col++)
            {
                var squareNewSum = matrice[row][col]
                    + matrice[row][col + 1]
                    + matrice[row][col + 2]
                    + matrice[row + 1][col]
                    + matrice[row + 1][col + 1]
                    + matrice[row + 1][col + 2]
                    + matrice[row + 2][col]
                    + matrice[row + 2][col + 1]
                    + matrice[row + 2][col + 2];

                if (squareNewSum > squareMaxSum)
                {
                    squareMaxSum = squareNewSum;
                    x1 = matrice[row][col];
                    x2 = matrice[row][col + 1];
                    x3 = matrice[row][col + 2];
                    
                    y1 = matrice[row + 1][col];
                    y2 = matrice[row + 1][col + 1];
                    y3 = matrice[row + 1][col + 2];

                    z1 = matrice[row + 2][col];
                    z2 = matrice[row + 2][col + 1];
                    z3 = matrice[row + 2][col + 2];
                }
            }
        }
        Console.WriteLine($"Sum = {squareMaxSum}");
        Console.WriteLine($"{x1} {x2} {x3}");
        Console.WriteLine($"{y1} {y2} {y3}");
        Console.WriteLine($"{z1} {z2} {z3}");

    }
}