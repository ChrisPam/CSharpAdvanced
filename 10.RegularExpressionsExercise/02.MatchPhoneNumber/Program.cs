using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            while (number.ToLower() != "end")
            {
                var regex = new Regex("^\\+359(\\s|-)[\\d]\\1[\\d]{3}\\1[\\d]{4}$");
                var match = regex.Match(number);

                if (match.Success)
                {
                    Console.WriteLine(match);
                }

                number = Console.ReadLine();
            }
        }
    }
}
