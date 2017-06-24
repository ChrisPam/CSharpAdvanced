using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstName
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var letters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x).ToList();

            var isFound = false;
            foreach (var letter in letters)
            {
                var temp = names.Where(x => x.ToLower().FirstOrDefault() == Convert.ToChar(letter.ToLower())).ToList();
                if(temp.Count > 0)
                {
                    names = temp;
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                names.Clear();
            }
            if (names.Count != 0)
            {
                Console.WriteLine(names[0]);
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
