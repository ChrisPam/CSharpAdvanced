using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BoundedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(' ').Select(int.Parse);
            var lowerBound = data.Min();
            var upperBound = data.Max();

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse);

            Console.WriteLine(string.Join(" ", numbers.Where(x => x >= lowerBound).Where(x => x <= upperBound)));

        }
    }
}
