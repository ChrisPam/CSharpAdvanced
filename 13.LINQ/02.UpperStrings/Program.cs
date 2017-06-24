using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.UpperStrings
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split(' ')
                .Select(x => x.ToString().ToUpper())
                .ToList()));
        }
    }
}
