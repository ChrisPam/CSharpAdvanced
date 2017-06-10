using System;
using System.Collections.Generic;
using System.Linq;

public class SquaresInMatrix
{
    public static void Main()
    {
        var matriceLength = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var rowsLength = matriceLength[0];
        var colsLength = matriceLength[1];

        var matrice = new char[rowsLength][];

        for (int row = 0; row < rowsLength; row++)
        {
            matrice[row] = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
        }
        var counter = 0;
        for (int row = 0; row < rowsLength - 1; row++)
        {
            for (int col = 0; col < colsLength -1; col++)
            {
                if (matrice[row][col] == matrice[row + 1][col] &&
                    matrice[row][col + 1] == matrice[row + 1][col + 1] &&
                    matrice[row][col] == matrice[row][col + 1])
                {
                    counter++;
                }
            }
        }

        Console.WriteLine(counter);
    }
}