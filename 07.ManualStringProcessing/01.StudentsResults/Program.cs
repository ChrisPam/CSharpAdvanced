using System;
using System.Collections.Generic;
using System.Linq;

public class StudentsResults
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var grades = new Dictionary<string, List<double>>();
        for (int i = 0; i < n; i++)
        {
            var nameAndGrades = Console.ReadLine()
                .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var name = nameAndGrades[0].Trim();

            if (!grades.ContainsKey(name))
            {
                grades[name] = new List<double>();
            }
            var listWithGrades = nameAndGrades[1]
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            grades[name] = listWithGrades;
        }

        Console.WriteLine(string.Format("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|", 
            "Name", "CAdv", "COOP", "AdvOOP", "Average"));
        foreach (var userWithGrades in grades)
        {
            var name = userWithGrades.Key;
            var firstGrade = userWithGrades.Value[0];
            var secondGrade = userWithGrades.Value[1];
            var thirdGrade = userWithGrades.Value[2];

            Console.WriteLine(string.Format("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",
                name, firstGrade, secondGrade, thirdGrade, userWithGrades.Value.Average()));
        }
    }
}
