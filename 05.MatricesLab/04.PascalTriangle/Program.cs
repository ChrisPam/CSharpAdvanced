using System;
using System.Collections.Generic;
using System.Linq;

class PascalTriangle
{
    static void Main()
    {
        var number = long.Parse(Console.ReadLine());

        var matrix = new List<List<long>>();
        if(number < 0)
        {
            return;
        }
        matrix.Add(new List<long>());
        matrix[0].Add(1);

        for (int i = 1; i < number; i++)
        {
            matrix.Add(new List<long>());
            matrix[i].Add(1);
            for (int j = 0; j < matrix[i - 1].Count - 1; j++)
            {
                matrix[i].Add(matrix[i - 1][j] + matrix[i - 1][j + 1]);
            }

            matrix[i].Add(1);
        }

        for (int i = 0; i < matrix.Count; i++)
        {
            Console.WriteLine(string.Join(" ", matrix[i]));
        }
    }
}
