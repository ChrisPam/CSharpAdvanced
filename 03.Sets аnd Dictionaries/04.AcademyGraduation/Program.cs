using System;
using System.Collections.Generic;
using System.Linq;

public class AcademyGraduation
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var academy = new SortedDictionary<string, List<double>>();

        for (int i = 1; i <= n; i++)
        {
            var name = Console.ReadLine();
            List<double> grades = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            if (!academy.ContainsKey(name))
            {
                academy[name] = new List<double>();
            }
            academy[name] = grades;
        }

        foreach (var persons in academy)
        {
            double gradesSum = 0;
            var gradesCount = 0;
            foreach (var grade in persons.Value)
            {
                gradesSum += grade;
                gradesCount++;
            }
            Console.WriteLine($"{persons.Key} is graduated with {gradesSum / gradesCount}");
        }
    }
}