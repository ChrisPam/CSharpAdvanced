using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FindAndSumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var numbers = new List<long>();
            foreach (var word in input)
            {
                long number;
                bool isNumber = long.TryParse(word, out number);
                if (isNumber)
                {
                    numbers.Add(number);
                }
            }
            if(numbers.Count != 0)
            {
                Console.WriteLine(numbers.Sum());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
