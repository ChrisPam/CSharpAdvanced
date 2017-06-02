using System;
using System.Collections.Generic;
using System.Linq;

class SumOfAllElementsOfMatrix
{
    static void Main()
    {
        var matricesLength = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var rowsLength = matricesLength[0];
        var colsLength = matricesLength[1];
        int[][] matrice = new int[rowsLength][];

        var sum = 0;
        for (int row = 0; row < matrice.GetLength(0); row++)
        {
            var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            matrice[row] = input;
            sum += input.Sum();
        }
        Console.WriteLine(rowsLength);
        Console.WriteLine(colsLength);
        Console.WriteLine(sum);
    }
}