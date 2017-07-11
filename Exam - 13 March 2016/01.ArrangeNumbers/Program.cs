using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var integers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
        var resultedNumbers = new List<string>();
        foreach (var item in integers)
        {
            var resultList = new List<string>();
            var temp = item.ToString().ToCharArray();
            foreach (var digit in temp)
            {
                switch (digit)
                {
                    case '1':
                        resultList.Add("one");
                        break;
                    case '2':
                        resultList.Add("two");
                        break;
                    case '3':
                        resultList.Add("three");
                        break;
                    case '4':
                        resultList.Add("four");
                        break;
                    case '5':
                        resultList.Add("five");
                        break;
                    case '6':
                        resultList.Add("six");
                        break;
                    case '7':
                        resultList.Add("seven");
                        break;
                    case '8':
                        resultList.Add("eight");
                        break;
                    case '9':
                        resultList.Add("nine");
                        break;
                    case '0':
                        resultList.Add("zero");
                        break;
                }
                resultList.Add("-");
            }
            resultedNumbers.Add(string.Join("", resultList).Substring(0, string.Join("", resultList).Length - 1));
        }
        var sortedNumbers = new List<string>();
        resultedNumbers = resultedNumbers.OrderBy(x => x).ToList();
        foreach (var item in resultedNumbers)
        {
            var temp = item.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new List<string>();

            foreach (var word in temp)
            {
                switch (word)
                {
                    case "one":
                        result.Add("1");
                        break;
                    case "two":
                        result.Add("2");
                        break;
                    case "three":
                        result.Add("3");
                        break;
                    case "four":
                        result.Add("4");
                        break;
                    case "five":
                        result.Add("5");
                        break;
                    case "six":
                        result.Add("6");
                        break;
                    case "seven":
                        result.Add("7");
                        break;
                    case "eight":
                        result.Add("8");
                        break;
                    case "nine":
                        result.Add("9");
                        break;
                    case "zero":
                        result.Add("0");
                        break;
                }
            }
            sortedNumbers.Add(string.Join("", result));
        }
        Console.WriteLine(string.Join(", ", sortedNumbers));
    }
}