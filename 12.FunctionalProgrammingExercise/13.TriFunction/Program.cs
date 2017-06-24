using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in names)
            {
                var sum = GetSumOfLetters(name);
                if(sum >= n)
                {
                    Console.WriteLine(name);
                    break;
                }
            }
        }

        private static long GetSumOfLetters(string name)
        {
            var sum = 0;
            foreach (var letter in name)
            {
                sum += (int)letter;
            }
            return sum;
        }
    }
}
