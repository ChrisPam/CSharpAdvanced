using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MinEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .Where(x => x % 2 == 0)
                .ToList();
            if(numbers.Count != 0)
            {
                Console.WriteLine($"{numbers.Min():f2}");
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
