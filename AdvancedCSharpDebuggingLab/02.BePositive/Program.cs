namespace BePositive
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BePositiveMain
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                List<long> numbers = Console.ReadLine()
                    .Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToList();

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    long currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(currentNum);
                        found = true;
                    }
                    else
                    {
                        try
                        {
                            currentNum += numbers[j + 1];
                        }
                        catch (Exception)
                        {

                            continue;
                        }


                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                        }
                        j++;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
                Console.WriteLine();
            }
        }
    }
}