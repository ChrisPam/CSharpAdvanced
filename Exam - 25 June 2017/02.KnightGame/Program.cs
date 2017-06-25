using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        char[][] board = new char[n][];
        var knights = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().ToCharArray();
            board[i] = line;
        }
        var count = 0;
        while (true)
        {
            for (int row = 0; row < n; row++)
            {
                if (board[row].Contains('K'))
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (board[row][col] == 'K')
                        {
                            // Get index of top left positions
                            var leftTopTopRow = row - 2;
                            var leftTopTopCol = col - 1;
                            var leftTopBotRow = row - 1;
                            var leftTopBotCol = col - 2;

                            // Get index of top right positions
                            var rightTopTopRow = row - 2;
                            var rightTopTopCol = col + 1;
                            var rightTopBotRow = row - 1;
                            var rightTopBotCol = col + 2;

                            // Get index of bottom left positions
                            var leftBotTopRow = row + 1;
                            var leftBotTopCol = col - 2;
                            var leftBotBotRow = row + 2;
                            var leftBotBotCol = col - 1;

                            // Get index of bottom right positions
                            var rightBotTopRow = row + 1;
                            var rightBotTopCol = col + 2;
                            var rightBotBotRow = row + 2;
                            var rightBotBotCol = col + 1;

                            CheckKnightPosition(n, board, knights, leftTopTopRow, leftTopTopCol, row, col);
                            CheckKnightPosition(n, board, knights, leftTopBotRow, leftTopBotCol, row, col);
                            CheckKnightPosition(n, board, knights, rightTopTopRow, rightTopTopCol, row, col);
                            CheckKnightPosition(n, board, knights, rightTopBotRow, rightTopBotCol, row, col);
                            CheckKnightPosition(n, board, knights, leftBotTopRow, leftBotTopCol, row, col);
                            CheckKnightPosition(n, board, knights, leftBotBotRow, leftBotBotCol, row, col);
                            CheckKnightPosition(n, board, knights, rightBotTopRow, rightBotTopCol, row, col);
                            CheckKnightPosition(n, board, knights, rightBotBotRow, rightBotBotCol, row, col);
                        }
                    }
                }
            }
            if (knights.Values.Sum() == 0)
                break;

            if (knights.Values.Sum() > knights.Count)
            {
                count++;
                var result = knights.OrderByDescending(x => x.Value);

                var key = result.First().Key.Split(new char[] { '|' });
                var firstRow = int.Parse(key[0].ToString());
                var firstCol = int.Parse(key[1].ToString());
                board[firstRow][firstCol] = '0';
                knights.Clear();
            }

        }
        Console.WriteLine(count);
    }
    public static void CheckKnightPosition(int n, char[][] board, Dictionary<string, int> knights, int destRow, int destCol, int row, int col)
    {
        if (!isOutOfBoard(destRow, destCol, n))
        {
            if (board[destRow][destCol] == 'K')
            {
                var key = $"{row}|{col}";
                if (!knights.ContainsKey(key))
                {
                    knights[key] = 0;
                }
                knights[key]++;
            }
        }
    }
    private static bool isOutOfBoard(int destinationRow, int destinationCol, int n)
    {
        if (destinationRow > n - 1 || destinationCol > n - 1 || destinationRow < 0 || destinationCol < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}