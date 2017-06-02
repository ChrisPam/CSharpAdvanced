using System;

class RecursiveFibonacci
{
    private static long[] fibNumbers;
    public static void Main()
    {
        var nthNumber = int.Parse(Console.ReadLine());
        fibNumbers = new long[nthNumber];
        var result = GetFibonaci(nthNumber);
        Console.WriteLine(result);
    }

    public static long GetFibonaci(int nthNumber)
    {
        if (nthNumber <= 2)
        {
            return 1;
        }
        if (fibNumbers[nthNumber - 1] != 0)
        {
            return fibNumbers[nthNumber - 1];
        }
        return fibNumbers[nthNumber - 1] = GetFibonaci(nthNumber - 1) + GetFibonaci(nthNumber - 2);
    }
}
