using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageOfDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($@"{Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .Average():f2}");
        }
    }
}
