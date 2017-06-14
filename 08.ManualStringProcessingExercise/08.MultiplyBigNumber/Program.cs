using System;
using System.Collections.Generic;
using System.Linq;

public class MultiplyBigNumber
{
    public static void Main()
    {
        var firstNumber = Console.ReadLine().ToCharArray();
        var secondNumber = Console.ReadLine();

        var max = firstNumber.Length;

        var result = new Stack<long>();
        long reminder = 0;

        if(int.Parse(secondNumber) == 0)
        {
            Console.WriteLine(0);
            return;
        }
        for (int i = max - 1; i >= 0; i--)
        {
            var multiplySum = (long)Char.GetNumericValue(firstNumber[i]) * int.Parse(secondNumber) + reminder;
            var sumArr = digitArr(multiplySum).ToList();
            if (i == 0 && multiplySum > 9)
            {
                result.Push(multiplySum);
                break;
            }
            if (multiplySum > 9)
            {
                reminder = sumArr[1];

                sumArr.RemoveAt(1);
            }
            else
            {
                if (reminder > 0)
                    reminder = 0;
            }
            var numToPush = sumArr[0];

            result.Push(numToPush);
        }
        Console.WriteLine(string.Join("", result).TrimStart(new Char[] { '0' }));
    }
    public static long[] digitArr(long n)
    {
        if (n == 0) return new long[1] { 0 };

        var digits = new List<long>();

        for (; n != 0; n /= 10)
            digits.Add(n % 10);

        var arr = digits.ToArray();
        return arr;
    }
}
