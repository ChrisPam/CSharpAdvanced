using System;
using System.Collections.Generic;
using System.Linq;

public class LegoBlocks
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var firstMatrix = new int[n][];
        var secondMatrix = new int[n][];
        
        for (int row = 0; row < n; row++)
        {
            firstMatrix[row] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
        
        for (int row = 0; row < n; row++)
        {
            secondMatrix[row] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
        for (int row = 0; row < n; row++)
        {
            secondMatrix[row] = secondMatrix[row].Reverse().ToArray();
        }
        
        var matriceElementsLength = 0;
        var isEqual = true;
        var lastElementsLength = 0;
        for (int i = 0; i < n; i++)
        {
            int[] resultMatrixRow = firstMatrix[i].Concat(secondMatrix[i]).ToArray();
            firstMatrix[i] = resultMatrixRow;
            if (i == 0)
            {
                lastElementsLength = resultMatrixRow.Length;
            }
            matriceElementsLength += resultMatrixRow.Length;
            if (lastElementsLength != resultMatrixRow.Length)
            {
                isEqual = false;
            }
        }
        if (isEqual)
        {
            // Logic for print the whole matrix
        
            for (int row = 0; row < n; row++)
            {
                Console.Write("[");
                Console.Write(string.Join(", ", firstMatrix[row]));
                Console.WriteLine("]");
            }
        
        }
        else
        {
            Console.WriteLine($"The total number of cells is: {matriceElementsLength}");
        }
        var debug = 0;
    }
}