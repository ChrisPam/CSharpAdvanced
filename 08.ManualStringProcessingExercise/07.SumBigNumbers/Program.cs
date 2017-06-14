using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var num1 = Console.ReadLine();
        var num2 = Console.ReadLine();

        var max = Math.Max(num1.Length, num2.Length);

        num1 = num1.PadLeft(max, '0');
        num2 = num2.PadLeft(max, '0');

        var firstNum = num1.ToCharArray();
        var secondNum = num2.ToCharArray();
        long reminder = 0;
        var result = new Stack<long>();
        for (int i = max - 1; i >= 0; i--)
        {
            var sum = (long)Char.GetNumericValue(firstNum[i]) + (long)Char.GetNumericValue(secondNum[i]) + reminder;
            var sumArr = digitArr(sum).ToList();
            if (i == 0 && sum > 9)
            {
                result.Push(sum);
                break;
            }
            if (sum > 9)
            {
                reminder = sumArr[1];

                sumArr.RemoveAt(1);
            }
            else
            {
                if(reminder > 0)
                reminder--;
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